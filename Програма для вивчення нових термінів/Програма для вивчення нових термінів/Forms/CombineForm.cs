using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class CombineForm : Form
    {

        User currentUser;
        List<StudySet> studySetsForCombine = new List<StudySet>();
        public CombineForm()
        {
            InitializeComponent();
            currentUser = AppContext.Instance.CurrentUser;
            SetupUI();
        }

        private void SetupUI()
        {
            int topOffset = 0;
            panelForSets.AutoScroll = true;
            foreach (StudySet studySet in currentUser.StudySets)
            {
                SetsForCombine newButton = new SetsForCombine(studySet);
                newButton.Top = topOffset;
                newButton.Left = 30;
                newButton.StudySetCombined += SetsForCombine_StudySetCombined;
                panelForSets.Controls.Add(newButton);
                topOffset += 100;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainForm newf = new MainForm();
            FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().Where(x => x.Name == "FormForMain").FirstOrDefault();
            mainForm.OpenChildForm(newf);
        }

        private void SetsForCombine_StudySetCombined(object sender, StudySetEventArgs e)
        {
            if (e.IsChecked)
            {
                studySetsForCombine.Add(e.StudySet);
            }
            else
            {
                studySetsForCombine.Remove(e.StudySet);
            }
            changeLabelCombine();
        }

        private void changeLabelCombine()
        {
            int countItems = studySetsForCombine.Sum(set => set.Cards.Count);
            labelCurrentCombine.Text = $"Currently Combining — {studySetsForCombine.Count} sets • {countItems} terms";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || studySetsForCombine.Count == 0)
            {
                //MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppContext.ShowMessage("Please fill in all fields.", "Error", MessageType.Error);
                return;
            }

            CreateNewStudySet();
            //MessageBox.Show("New study set created successfully.\nAll duplicates have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AppContext.ShowMessage("New study set created successfully.\nAll duplicates have been deleted.", "Success", MessageType.Success);
            buttonCancel_Click(sender, e);
        }

        private void CreateNewStudySet()
        {
            StudySet newStudySet = new StudySet { Title = textBox1.Text };
            HashSet<Card> uniqueCards = new HashSet<Card>();

            foreach (var studySet in studySetsForCombine)
            {
                foreach (var card in studySet.Cards)
                {
                    if (uniqueCards.Add(card))
                    {
                        card.TypeLearning = LearningTypeConstants.StillLearning;
                        newStudySet.Cards.Add(card);
                    }
                }
            }

            currentUser.StudySets.Add(new StudySet(newStudySet.Title, "", DateTime.Now, newStudySet.Cards));
            studySetsForCombine.Clear();
            textBox1.Text = "";
            changeLabelCombine();

        }
    }

}
