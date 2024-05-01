using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class CreateOrEditStudySet : Form
    {
        private StudySet studySetWithoutEditing;
        private StudySet saveSetForImportInfo;
        private char returnToForm;

        public CreateOrEditStudySet()
        {
            InitializeComponent();
            dataGridViewCards.Rows.Add();
            dataGridViewCards.RowTemplate.Height = 40;
            returnToForm = 'c';
            UpdateFormText(returnToForm);
            ToggleLanguageCombosEnabled(false);
        }

        private void UpdateFormText(char mode)
        {
            switch (mode)
            {
                case 'c':
                    buttonCreateOrSaveSet.Text = "Create set";
                    TitleFormLabel.Text = "Create a new study set";
                    returnToForm = 'c';
                    break;
                case 'e':
                    TitleFormLabel.Text = "Edit your study set";
                    buttonCreateOrSaveSet.Text = "Save changes";
                    returnToForm = 'e';
                    break;
            }
        }

        public CreateOrEditStudySet(StudySet set, char mode) : this()
        {
            UpdateFormText(mode);

            titleTextBox.Text = set.Title;
            descriptionRichTextBox.Text = set.Description;

            if (set is LanguageStudySet languageSet)
            {
                checkBoxLanguageSet.Checked = true;
                comboBoxLanguag1.Text = languageSet.Language1;
                comboBoxLanguag2.Text = languageSet.Language2;
            }
            PopulateDataGridView(set.Cards);
            if (mode == 'e') studySetWithoutEditing = set;
        }

        public CreateOrEditStudySet(StudySet setWithoutEdit, StudySet set, char mode, HashSet<Card> newCards)
            : this(set, mode)
        {
            studySetWithoutEditing = setWithoutEdit;
            PopulateDataGridView(newCards);
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCards.Rows.Cast<DataGridViewRow>().Any(row => row.Cells.Cast<DataGridViewCell>().Any
            (cell => cell.Value == null || string.IsNullOrEmpty(cell.Value.ToString()))))
            {
                //MessageBox.Show("To add a new item, fill in the other items first");
                AppContext.ShowMessage("To add a new item, fill in the other items first", "Error", MessageType.Error);
                return;
            }
            dataGridViewCards.Rows.Add();
            dataGridViewCards.CurrentCell = dataGridViewCards.Rows[dataGridViewCards.Rows.Count - 1].Cells[0];
            dataGridViewCards.BeginEdit(true);
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCards.Rows.Count == 0)
            {
                //MessageBox.Show("All items have already been deleted");
                AppContext.ShowMessage("All items have already been deleted", "Error", MessageType.Error);
                return;
            }

            if (dataGridViewCards.SelectedCells.Count > 0)
            {
                dataGridViewCards.Rows.RemoveAt(dataGridViewCards.SelectedCells[0].RowIndex);
            }
            else
            {
                //MessageBox.Show("Nothing is selected in the DataGridView.");
                AppContext.ShowMessage("Nothing is selected in the DataGridView.", "Error", MessageType.Error);
            }
        }

        private void buttonFlipTD_Click(object sender, EventArgs e)
        {
            if (dataGridViewCards.Rows.Count == 0) return;

            foreach (DataGridViewRow row in dataGridViewCards.Rows)
            {
                var temp = row.Cells[0].Value;
                row.Cells[0].Value = row.Cells[1].Value;
                row.Cells[1].Value = temp;
            }
        }

        private FormForMain GetMainForm()
        {
            return Application.OpenForms.OfType<FormForMain>().FirstOrDefault(x => x.Name == "FormForMain");
        }

        private void OpenChildForm(Form childForm)
        {
            FormForMain mainForm = GetMainForm();
            if (mainForm != null)
            {
                mainForm.OpenChildForm(childForm);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form childForm;
            if (returnToForm == 'c') childForm = new MainForm();
            else childForm = new FormShowSet(studySetWithoutEditing);
            OpenChildForm(childForm);
        }

        private void buttonCreateOrSaveSet_Click(object sender, EventArgs e)
        {

            if (!AreInputFieldsValid())
            {
                AppContext.ShowMessage("To create a new set, you need to fill in all fields and items", "Error", MessageType.Error);
                return;
            }

            StudySet workingSet = CollectSetDataFromUI(true);
            AppContext.Instance.CurrentUser.StudySets.Add(workingSet);

            if (returnToForm == 'c')
            {
                OpenChildForm(new MainForm());
            }
            else if (returnToForm == 'e')
            {
                AppContext.Instance.CurrentUser.StudySets.Remove(studySetWithoutEditing);
                OpenChildForm(new FormShowSet(workingSet));
            }
        }
        
        private bool IsRowEmpty(DataGridViewRow row)
        {
            return row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value == null || 
            string.IsNullOrWhiteSpace(cell.Value.ToString()));
        }

        private bool AreInputFieldsValid()
        {
            bool hasRows = dataGridViewCards.Rows.Count > 0; 
            bool languageFieldsValid = true; 

            if (checkBoxLanguageSet.Checked) 
            {
                languageFieldsValid = !string.IsNullOrWhiteSpace(comboBoxLanguag1.Text) &&
                                      !string.IsNullOrWhiteSpace(comboBoxLanguag2.Text);
            }

            return !string.IsNullOrWhiteSpace(titleTextBox.Text) &&
                   hasRows &&
                   dataGridViewCards.Rows.Cast<DataGridViewRow>().All(row => !IsRowEmpty(row)) &&
                   languageFieldsValid;
        }

        private void PopulateDataGridView(IEnumerable<Card> cards)
        {
            dataGridViewCards.Rows.Clear();

            foreach (var card in cards)
            {
                dataGridViewCards.Rows.Add(card.Term, card.Definition);
            }

            if (cards.Count() == 0)
                dataGridViewCards.Rows.Add();
        }

        private void ToggleLanguageCombosEnabled(bool enabled)
        {
            comboBoxLanguag1.Enabled = enabled;
            comboBoxLanguag2.Enabled = enabled;
        }

        private void languageCB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLanguageSet.Checked)
            {
                comboBoxLanguag1.Enabled = comboBoxLanguag2.Enabled = true;
            }
            else
            {
                comboBoxLanguag1.Enabled = comboBoxLanguag2.Enabled = false;
                comboBoxLanguag1.Text = comboBoxLanguag2.Text = "";
            }
        }

        private void titleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (titleTextBox.Text.Length >= 50 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            saveSetForImportInfo = CollectSetDataFromUI(true);
            ImportForm importForm = new ImportForm(studySetWithoutEditing, saveSetForImportInfo, returnToForm);
            FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().FirstOrDefault(x => x.Name == "FormForMain");
            mainForm.OpenChildForm(importForm);
        }

        private StudySet CollectSetDataFromUI(bool includeExistingCards = false)
        {
            string title = titleTextBox.Text;
            string description = descriptionRichTextBox.Text;
            DateTime creationDate = DateTime.Now;
            HashSet<Card> cards = CollectCardsFromDataGridView(includeExistingCards);

            return checkBoxLanguageSet.Checked
                ? new LanguageStudySet(title, description, comboBoxLanguag1.Text, comboBoxLanguag2.Text, creationDate, cards)
                : new StudySet(title, description, creationDate, cards);
        }

        private HashSet<Card> CollectCardsFromDataGridView(bool includeExisting = false)
        {
            HashSet<Card> cards = new HashSet<Card>();
            foreach (DataGridViewRow row in dataGridViewCards.Rows)
            {
                string term = row.Cells[0].Value?.ToString().Trim();
                string definition = row.Cells[1].Value?.ToString().Trim();
                if (!string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(definition))
                {
                    Card card = new Card(term, definition);
                    if (includeExisting && returnToForm == 'e')
                    {
                        Card existingCard = studySetWithoutEditing.Cards.FirstOrDefault(c => c==card);
                        if (existingCard != null)
                        {
                            card.TypeLearning = existingCard.TypeLearning;
                        }
                    }
                    cards.Add(card);
                }
            }
            return cards;
        }
        //public StudySet saveInfoAboutSet()
        //{
        //    string title = TitleTextBox.Text;
        //    string description = DescriptionRichTextBox.Text;
        //    DateTime creationDate = DateTime.Now;
        //    HashSet<Card> cards = new HashSet<Card>();

        //    foreach (DataGridViewRow row in dataGridViewCards.Rows)
        //    {
        //        string term = row.Cells[0].Value?.ToString();
        //        string definition = row.Cells[1].Value?.ToString();

        //        if (!string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(definition))
        //        {
        //            Card card = new Card(term, definition);
        //            if (returnToForm == 'c')
        //            {
        //                cards.Add(card);
        //            }
        //            else if (returnToForm == 'e')
        //            {
        //                Card existingCard = studySetWithoutEditing.Cards.FirstOrDefault(c => c == card);
        //                if (existingCard != null)
        //                    cards.Add(existingCard);
        //                else
        //                    cards.Add(card);
        //            }
        //        }
        //    }

        //    StudySet workingSet;
        //    if (checkBox1.Checked)
        //    {
        //        string language1 = comboBoxLanguag1.Text;
        //        string language2 = comboBoxLanguag2.Text;
        //        workingSet = new LanguageStudySet(title, description, language1, language2, creationDate, cards);
        //    }
        //    else
        //    {
        //        workingSet = new StudySet(title, description, creationDate, cards);
        //    }
        //    return workingSet;
        //}

        //private StudySet CollectSetDataFromUI()
        //{
        //    string title = TitleTextBox.Text;
        //    string description = DescriptionRichTextBox.Text;
        //    DateTime creationDate = DateTime.Now;
        //    HashSet<Card> cards = CollectCardsFromDataGridView();

        //    if (checkBox1.Checked)
        //    {
        //        string language1 = comboBoxLanguag1.Text;
        //        string language2 = comboBoxLanguag2.Text;
        //        return new LanguageStudySet(title, description, language1, language2, creationDate, cards);
        //    }
        //    else
        //    {
        //        return new StudySet(title, description, creationDate, cards);
        //    }
        //}

        //private HashSet<Card> CollectCardsFromDataGridView()
        //{
        //    HashSet<Card> cards = new HashSet<Card>();
        //    foreach (DataGridViewRow row in dataGridViewCards.Rows)
        //    {
        //        if (!IsRowEmpty(row))
        //        {
        //            string term = row.Cells[0].Value.ToString();
        //            string definition = row.Cells[1].Value.ToString();
        //            cards.Add(new Card(term, definition));
        //        }
        //    }
        //    return cards;
        //}
    }
}

