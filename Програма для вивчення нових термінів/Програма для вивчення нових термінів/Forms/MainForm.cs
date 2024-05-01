using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private List<StudySet> filteredList = new List<StudySet>();

        public MainForm()
        {
            InitializeComponent();
            pictureBoxAddNewSet.Size = new Size(80, 80);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentUser = AppContext.Instance.CurrentUser;
            filteredList = currentUser.StudySets.ToList();
            InitializeComboBoxes();
            DisplayFilteredSets();
            InitializeToolTips();
        }

        private void InitializeToolTips()
        {
            toolTip1.SetToolTip(this.pictureBoxCombine, "Combine your sets");
            toolTip1.SetToolTip(this.pictureBoxAddNewSet, "Create new study set");
        }
        private void InitializeComboBoxes()
        {
            comboBoxSort.SelectedIndex = 0;
            comboBoxFilter.SelectedIndex = 0;
            comboBoxFilter.SelectedIndexChanged += comboBoxFiltr_SelectedIndexChanged;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
        }

        private void DisplayFilteredSets()
        {
            panelForSets.Controls.Clear();
            if (filteredList.Any())
            {
                AddStudySetButtons();
            }
            else
            {
                AddNoSetsLabel("There are no study sets available.");
            }
        }

        private void AddStudySetButtons()
        {
            int topOffset = 0;
            foreach (StudySet studySet in filteredList)
            {
                SetsButton newButton = new SetsButton(studySet)
                {
                    Top = topOffset,
                    Left = 30
                };
                panelForSets.Controls.Add(newButton);
                topOffset += 90;
            }
        }

        private void AddNoSetsLabel(string text)
        {
            Label noSetsLabel = new Label
            {
                Text = text,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold),
                Anchor = AnchorStyles.None
                //Location = new Point((panelForSets.Width - 200) / 2, (panelForSets.Height - 100) / 2)
            };

            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Controls.Add(noSetsLabel);
            panelForSets.Controls.Add(tableLayout);
           // panelForSets.Controls.Add(noSetsLabel);
        }

        private void comboBoxFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterStudySets();
            SortStudySets();
            DisplayFilteredSets();
        }

        private void FilterStudySets()
        {
            string filter = comboBoxFilter.SelectedItem.ToString();
            filteredList = currentUser.StudySets.Where(set =>
                filter == "All sets" ||
                (filter == "Language sets" && set is LanguageStudySet) ||
                (filter == "Simple sets" && !(set is LanguageStudySet))
            ).ToList();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortStudySets();
            DisplayFilteredSets();
        }

        private void SortStudySets()
        {
            string selectedSort = comboBoxSort.SelectedItem.ToString();
            switch (selectedSort)
            {
                case "Date (newest -> latest)":
                    filteredList.Sort((x, y) => y.CreationDate.CompareTo(x.CreationDate));
                    break;
                case "Date (latest -> newest)":
                    filteredList.Sort((x, y) => x.CreationDate.CompareTo(y.CreationDate));
                    break;
                case "Title (A -> Z)":
                    filteredList.Sort((x, y) => string.Compare(x.Title, y.Title, StringComparison.CurrentCulture));
                    break;
                case "Title (Z -> A)":
                    filteredList.Sort((x, y) => string.Compare(y.Title, x.Title, StringComparison.CurrentCulture));
                    break;
                case "Count terms (max -> min)":
                    filteredList.Sort((x, y) => y.Cards.Count.CompareTo(x.Cards.Count));
                    break;
                case "Count terms (min -> max)":
                    filteredList.Sort((x, y) => x.Cards.Count.CompareTo(y.Cards.Count));
                    break;
            }

            //DisplayFilteredSets(); 
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = richTextBoxSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                //MessageBox.Show("Enter title to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppContext.ShowMessage("Enter title to search", "Error", MessageType.Error);
                return;
            }

            SearchSets(searchText);
        }

        private void SearchSets(string searchText)
        {
            searchText = searchText.ToLowerInvariant();
            filteredList = filteredList.Where(set => set.Title.ToLowerInvariant().Contains(searchText)).ToList();
            DisplayFilteredSets();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxSearch.Clear();
            FilterStudySets();
            SortStudySets();
            DisplayFilteredSets();
        }

        private void combineSets_Click(object sender, EventArgs e)
        {
            if (currentUser.StudySets.Count < 2)
            {
                //MessageBox.Show("At least 2 sets are required to combine sets", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppContext.ShowMessage("At least 2 sets are required to combine sets", "Error", MessageType.Error);
                return;
            }    
            CombineForm createNewStudySet = new CombineForm();
            FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().Where(x => x.Name == "FormForMain").FirstOrDefault();
            mainForm.OpenChildForm(createNewStudySet);
        }

        private void AddNewSet_Click(object sender, EventArgs e)
        {
            CreateOrEditStudySet createNewStudySet = new CreateOrEditStudySet();
            FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().Where(x => x.Name == "FormForMain").FirstOrDefault();
            mainForm.OpenChildForm(createNewStudySet);
        }

    }

}

