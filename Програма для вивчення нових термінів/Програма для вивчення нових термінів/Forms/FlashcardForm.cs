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
    public partial class FlashcardForm : Form
    {
        StudySet workingSet;
        List<Card> stillLearningCards;
        int countAll = 1;
        int countKnow = 0;
        int countStillLearning = 0;
        public FlashcardForm(StudySet studySetForFlascards)
        {
            InitializeComponent();
            workingSet = studySetForFlascards;
            
            stillLearningCards = new List<Card>(
            studySetForFlascards.Cards
                .Where(card => card.TypeLearning == LearningTypeConstants.StillLearning)
                .Select(card => new Card(card))
                .OrderBy(card => Guid.NewGuid()) // випадковий порядок
            );

            updateInitialCardUI();

            labelDefinition2.Font = new Font("Segoe UI Variable Text", labelDefinition2.Font.Size);
            labelTerm2.Font = new Font("Segoe UI Variable Text", labelTerm2.Font.Size);
            buttonToKnow.Click += (sender, e) => buttonCardTransition_Click(sender, e, LearningTypeConstants.Know);
            buttonToStillLearning.Click += (sender, e) => buttonCardTransition_Click(sender, e, LearningTypeConstants.StillLearning);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            saveSet();                                       
            FormShowSet newf = new FormShowSet(workingSet);
            FormForMain mainForm = AppContext.GetMainForm();
            mainForm.OpenChildForm(newf);
            mainForm.Show();
            this.Close();
         }

        private void saveSet()
        {
            foreach (Card card in workingSet.Cards)
            {
                Card correspondingCard = stillLearningCards.FirstOrDefault(c => c == card);

                if (correspondingCard != null)
                {
                    card.TypeLearning = correspondingCard.TypeLearning;
                }
            }
            StudySet foundSet = AppContext.Instance.CurrentUser.StudySets.FirstOrDefault(set => set == workingSet);

            if (foundSet != null)
            {
                foundSet.Cards = workingSet.Cards;
                //AccountManager accountManager = new AccountManager();
                //accountManager.UpdateUser(AppContext.Instance.CurrentUser);
            }
        }

        private void updateInitialCardUI()
        {
            updateCardDisplay();
            updateCardCount();
            updateButtons();
            resetHintLabel();
        }

        private void updateCardDisplay()
        {
            panelCard.Controls.Clear();
            panelCard.Controls.Add(tableLayoutPanelCard1);
            tableLayoutPanelCard1.Visible = true;
            tableLayoutPanelCard1.Dock = DockStyle.Fill;
        }

        private void updateCardCount()
        {
            labelTitleAndCount.Text = $"{countAll}/{stillLearningCards.Count}\n{workingSet.Title}";
            labelDefinition1.Text = stillLearningCards[countAll - 1].Definition;
        }

        private void updateButtons()
        {
            buttonStillLearning.Text = countStillLearning.ToString();
            buttonKnow.Text = countKnow.ToString();
        }

        private void resetHintLabel()
        {
            labelHint.Text = "Get a hint";
        }

        private void buttonCardTransition_Click(object sender, EventArgs e, string learningType)
        {
            Card currentCard = stillLearningCards[countAll - 1];
            currentCard.TypeLearning = learningType;
            countAll++;

            if (learningType == LearningTypeConstants.Know)
            {
                countKnow++;
            }
            else
            {
                countStillLearning++;
            }

            manageCardTransition();
        }

        //private void buttonToKnow_Click(object sender, EventArgs e)
        //{
        //    stillLearningCards[countAll - 1].TypeLearning = "Know";
        //    countAll++;
        //    countKnow++;
        //    manageCardTransition();
        //}

        //private void buttonToStillLearning_Click(object sender, EventArgs e)
        //{
        //    stillLearningCards[countAll - 1].TypeLearning = "Still learning";
        //    countAll++;
        //    countStillLearning++;
        //    manageCardTransition();
        //}

        private void manageCardTransition()
        {
            if (countAll > stillLearningCards.Count)
            {
                saveSet();
                ResultForm newf = new ResultForm(workingSet);
                this.Close();
                newf.Show();
            }
            else
            {
                updateInitialCardUI();
            }
        }

        private void buttonReturnToPreviousCard_Click(object sender, EventArgs e)
        {
            if (countAll != 1)
            {
                countAll--;
                if (stillLearningCards[countAll - 1].TypeLearning == LearningTypeConstants.StillLearning) { countStillLearning--; }
                else
                {
                    countKnow--;
                    stillLearningCards[countAll - 1].TypeLearning = LearningTypeConstants.StillLearning;
                }
                updateInitialCardUI() ;
            }
        }

        private void tableLayoutPanelCard_Click(object sender, EventArgs e)
        {
            updateAdvancedCardUI();
        }

        private void updateAdvancedCardUI()
        {
            panelCard.Controls.Clear();
            panelCard.Controls.Add(tableLayoutPanelCard2);
            tableLayoutPanelCard2.Visible = true;
            tableLayoutPanelCard2.Dock = DockStyle.Fill;

            labelDefinition2.Text = stillLearningCards[countAll - 1].Definition;
            labelTerm2.Text = stillLearningCards[countAll - 1].Term;
        }

        private void tableLayoutPanelCard2_Click(object sender, EventArgs e)
        {
            updateInitialCardUI();
        }

        private void tableLayoutPanelCard1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                using (SolidBrush brush = new SolidBrush(SystemColors.ScrollBar))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }
            }
        }

        private void tableLayoutPanelCard2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0 || e.Row == 2) 
            {
                using (SolidBrush brush = new SolidBrush(SystemColors.ScrollBar))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }
            }
        }

        private void labelHint_Click(object sender, EventArgs e)
        {

            if (labelHint.Text == "Get a hint")
            {
                string[] words = stillLearningCards[countAll - 1].Term.Split(' ');
                string maskedHint = "";

                for (int i = 0; i < words.Length; i++)
                {
                    if (i == 0 || i == 1)
                    {
                        maskedHint += words[i][0] + " ";
                        for (int j=1; j < words[i].Length; j++)
                            maskedHint += "_ ";
                    }
                    if (i > 1) { maskedHint += "    ..."; break; }
                }
                maskedHint = maskedHint.Trim();
                labelHint.Text = maskedHint;
            }
            else labelHint.Text = "Get a hint";
        }

        private void labelDefinition1_Click(object sender, EventArgs e)
        {
            //tableLayoutPanelCard_Click(sender, e);
            updateAdvancedCardUI();
        }

        private void labelDefinition2_Click(object sender, EventArgs e)
        {
            //tableLayoutPanelCard2_Click(sender, e);
            updateInitialCardUI();
        }

        private void labelTerm2_Click(object sender, EventArgs e)
        {
            //tableLayoutPanelCard2_Click(sender, e);
            updateInitialCardUI();
        }

        private void buttonToStillLearning_Click(object sender, EventArgs e)
        {

        }
    }
}
