using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class FormShowSet : Form
    {
        StudySet workingSet;

        ContextMenuStrip contextMenuStripKnow;
        ContextMenuStrip contextMenuStripStillLearning;
        //ToolStripMenuItem moveToSLToolStripMenuItem;
        //ToolStripMenuItem moveToKnowToolStripMenuItem;

        public FormShowSet(StudySet setForShow)
        {
            workingSet = setForShow;
            InitializeComponent();
            
            contextMenuStripKnow = CreateContextMenu("Move to Know", MoveToToolStripMenuItem_Click);
            contextMenuStripStillLearning = CreateContextMenu("Move to Still learning", MoveToToolStripMenuItem_Click);
            
            ShowInfo(workingSet);               
        }

        private ContextMenuStrip CreateContextMenu(string menuItemText, EventHandler clickEventHandler)
        {
            var contextMenu = new ContextMenuStrip();
            var menuItem = new ToolStripMenuItem(menuItemText);
            menuItem.Click += clickEventHandler;
            contextMenu.Items.Add(menuItem);
            return contextMenu;
        }

        private void MoveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            int rowIndex;
            DataGridView dataGridView;

            if (menuItem.Owner is ContextMenuStrip contextMenuStrip)
            {
                dataGridView = contextMenuStrip.SourceControl as DataGridView;
                rowIndex = dataGridView.CurrentCell.RowIndex;
            }
            else
            {
                dataGridView = dataGridView1;
                rowIndex = dataGridView.CurrentRow.Index;     
            }
            //Card card = dataGridView.Rows[rowIndex].DataBoundItem as Card;
            Card fcard = new Card(dataGridView.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView.Rows[rowIndex].Cells[1].Value.ToString());
            ChangeTypeOfLearning(fcard, menuItem);
            ShowInfo(workingSet);

        }

        private void ChangeTypeOfLearning(Card fcard, ToolStripMenuItem menuItem)
        {
            string newLearningType = menuItem.Text == "Move to Know" ? LearningTypeConstants.Know : LearningTypeConstants.StillLearning ;
            foreach (Card card in workingSet.Cards)
            {
                if (card.Equals(fcard))
                {
                    card.TypeLearning = newLearningType;
                    break;
                }
            }
        }

        private void ShowInfo(StudySet setForShow)
        {
            ResetDisplay();
            UpdateTitles(setForShow);
            UpdateLanguageLabel();

            var knowCardsCount = setForShow.Cards.Count(card => card.TypeLearning == LearningTypeConstants.Know);
            var learningCardsCount = setForShow.Cards.Count(card => card.TypeLearning == "Still learning");

            UpdateLabelsAndGrids(knowCardsCount, learningCardsCount, setForShow);
            SetContextMenus(knowCardsCount, learningCardsCount);
        }

        private void ResetDisplay()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            labelLanguage.Visible = false;
            DescriptionRichTextBox.Visible = false;
        }

        private void UpdateTitles(StudySet setForShow)
        {
            TitleLable.Text = setForShow.Title;
            if (!String.IsNullOrWhiteSpace(setForShow.Description))
            {
                DescriptionRichTextBox.Text = "Description: " + setForShow.Description;
                DescriptionRichTextBox.Visible = true;
            }
            CountTermsLabel.Text = $"Terms in the set ({setForShow.Cards.Count})";
            DateCreationLabel.Text = setForShow.CreationDate.ToString("dd.MM.yyyy");
        }

        private void UpdateLanguageLabel()
        {
            if (workingSet is LanguageStudySet languageSet)
            {
                labelLanguage.Visible = true;
                labelLanguage.Text = $"Language: {languageSet.Language1} -> {languageSet.Language2}";
            }
        }

        private void UpdateLabelsAndGrids(int knowCardsCount, int learningCardsCount, StudySet setForShow)
        {
            if (knowCardsCount > 0)
            {
                PopulateDataGrid(dataGridView1, setForShow.Cards.Where(card => card.TypeLearning == LearningTypeConstants.Know), LearningTypeConstants.Know, Color.DarkGreen);
            }
            if (knowCardsCount == 0 && learningCardsCount > 0)
            {
                PopulateDataGrid(dataGridView1, setForShow.Cards.Where(card => card.TypeLearning == LearningTypeConstants.StillLearning), LearningTypeConstants.StillLearning, Color.DarkGoldenrod);
            }
            else if (learningCardsCount > 0 && knowCardsCount != 0)
            {
                PopulateDataGrid(dataGridView2, setForShow.Cards.Where(card => card.TypeLearning == LearningTypeConstants.StillLearning), LearningTypeConstants.StillLearning, Color.DarkGoldenrod);
            }

            AdjustVisibility(knowCardsCount, learningCardsCount);
        }

        private void PopulateDataGrid(DataGridView grid, IEnumerable<Card> cards, string labelText, Color labelColor)
        {
            foreach (Card card in cards)
            {
                grid.Rows.Add(card.Term, card.Definition);
            }
            grid.Visible = true;

            var label = grid == dataGridView1 ? KnowLabel : StillLearningLabel;
            label.Text = $"{labelText} ({cards.Count()})";
            label.ForeColor = labelColor;
            label.Visible = true;
        }

        private void AdjustVisibility(int knowCardsCount, int learningCardsCount)
        {
            //if (knowCardsCount == 0)
            //{
            //    dataGridView1.Visible = false;
            //    KnowLabel.Visible = false;
            //}

            if (learningCardsCount == 0 || (learningCardsCount!=0 && knowCardsCount==0))
            {
                dataGridView2.Visible = false;
                StillLearningLabel.Visible = false;
            }
        }

        private void SetContextMenus(int knowCardsCount, int learningCardsCount)
        {
            dataGridView1.ContextMenuStrip = knowCardsCount > 0 ? contextMenuStripStillLearning : contextMenuStripKnow;
            dataGridView2.ContextMenuStrip = learningCardsCount > 0 ? contextMenuStripKnow : null;
        }

        //private void move(Card fcard, ToolStripMenuItem menuItem)
        //{
        //    if (menuItem == moveToKnowToolStripMenuItem)
        //    {
        //        foreach (Card c in workingSet.Cards)
        //        {
        //            if (c.Equals(fcard))
        //            {
        //                c.TypeLearning = "Know";
        //                break;
        //            }
        //        }

        //    }
        //    else if (menuItem == moveToSLToolStripMenuItem)
        //    {
        //        foreach (Card c in workingSet.Cards)
        //        {
        //            if (c.Equals(fcard))
        //            {
        //                c.TypeLearning = "Still learning";
        //                break;
        //            }
        //        }

        //    }
        //}

        //private void ShowInfo(StudySet setForShow)
        //{
        //    dataGridView1.Rows.Clear();
        //    dataGridView2.Rows.Clear();

        //    labelLanguage.Visible = false;
        //    TitleLable.Text = setForShow.Title;
        //    if (String.IsNullOrWhiteSpace(setForShow.Description)) DescriptionRichTextBox.Visible = false;
        //    else { DescriptionRichTextBox.Text = "Description: " + setForShow.Description; DescriptionRichTextBox.Visible = true; }
        //    CountTermsLabel.Text = $"Terms in the set ({setForShow.Cards.Count})";
        //    DateCreationLabel.Text = setForShow.CreationDate.ToString("dd.MM.yyyy");
        //    int knowCardsCount = setForShow.Cards.Count(card => card.TypeLearning == "Know");
        //    int learningCardsCount = setForShow.Cards.Count(card => card.TypeLearning == "Still learning");

        //    if (workingSet is LanguageStudySet)
        //    {
        //        labelLanguage.Visible = true;
        //        labelLanguage.Text = $"Language: {((LanguageStudySet)workingSet).Language1} -> {((LanguageStudySet)workingSet).Language2}";
        //    }

        //    if (knowCardsCount != 0)
        //    {
        //        KnowLabel.Text = $"Know ({knowCardsCount})";
        //        KnowLabel.ForeColor = Color.DarkGreen;
        //        foreach (Card card in setForShow.Cards.Where(card => card.TypeLearning == "Know"))
        //        {
        //            dataGridView1.Rows.Add(card.Term, card.Definition);
        //        }

        //        if (learningCardsCount != 0)
        //        {
        //            StillLearningLabel.Visible = true; dataGridView2.Visible = true;
        //            StillLearningLabel.Text = $"Still learning ({learningCardsCount})";
        //            StillLearningLabel.ForeColor = Color.DarkGoldenrod;
        //            foreach (Card card in setForShow.Cards.Where(card => card.TypeLearning == "Still learning"))
        //            {
        //                dataGridView2.Rows.Add(card.Term, card.Definition);
        //            }
        //        }

        //        else { StillLearningLabel.Visible = false; dataGridView2.Visible = false; }
        //    }
        //    else if (knowCardsCount == 0 && learningCardsCount != 0)
        //    {
        //        KnowLabel.Text = $"Still learning ({learningCardsCount})";
        //        KnowLabel.ForeColor = Color.DarkGoldenrod;
        //        foreach (Card card in setForShow.Cards.Where(card => card.TypeLearning == "Still learning"))
        //        {
        //            dataGridView1.Rows.Add(card.Term, card.Definition);
        //        }
        //        StillLearningLabel.Visible = false; dataGridView2.Visible = false;
        //    }

        //    if (learningCardsCount==0)
        //    { 
        //        dataGridView1.ContextMenuStrip = contextMenuStripStillLearning;

        //    }

        //    else if (knowCardsCount==0 && learningCardsCount!=0)
        //    {
        //        dataGridView1.ContextMenuStrip = contextMenuStripKnow;
        //    }

        //    else
        //    {
        //        dataGridView2.ContextMenuStrip = contextMenuStripKnow;
        //        dataGridView1.ContextMenuStrip = contextMenuStripStillLearning;
        //    }
        //}

        private FormForMain GetMainForm()
        {
            return Application.OpenForms.OfType<FormForMain>().FirstOrDefault();
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            GetMainForm()?.OpenChildForm(newForm);
        }

        private void EditSetButton_Click(object sender, EventArgs e)
        {
            CreateOrEditStudySet newForm = new CreateOrEditStudySet(workingSet, 'e');
            GetMainForm()?.OpenChildForm(newForm);
        }

        private void ExportSetButton_Click(object sender, EventArgs e)
        {
            ExportForm newExportForm = new ExportForm(workingSet);
            newExportForm.ShowDialog();
        }

        private void DeleteSetButton_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Are you sure you want to delete this set?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this set?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                AppContext.Instance.CurrentUser.StudySets.Remove(workingSet);
                ReturnButton_Click(sender, e);
            }
        }

        //private void RestartSetButton_Click(object sender, EventArgs e)
        //{
        //    foreach (Card card in workingSet.Cards)
        //    {
        //        card.TypeLearning = "Still learning";
        //    }
        //    StudySet foundSet = AppContext.Instance.CurrentUser.StudySets.FirstOrDefault(set => set == workingSet);
        //    if (foundSet != null)
        //    {
        //        foundSet.Cards = workingSet.Cards;
        //        ShowInfo(workingSet);
        //    }

        //}

        private void RestartSetButton_Click(object sender, EventArgs e)
        {
            foreach (Card card in workingSet.Cards)
                card.TypeLearning = LearningTypeConstants.StillLearning;
            ShowInfo(workingSet);
        }


        private void OpenFormAndCloseCurrent(Form newForm)
        {
            this.Close();
            var mainForm = GetMainForm();
            mainForm?.Hide();
            newForm.ShowDialog();
        }

        private bool ValidateCardCount(int minimumCount, string errorMessage)
        {
            if (workingSet.Cards.Count < minimumCount)
            {
                //MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppContext.ShowMessage(errorMessage, "Error", MessageType.Error);
                return false;
            }
            return true;
        }

        private int countQuestion()
        {
            using (NumberOfQuestionsDialog n = new NumberOfQuestionsDialog(4, workingSet.Cards.Count))
            {
                if (n.ShowDialog() == DialogResult.OK)
                    return n.SelectedNumberOfQuestions;
                return 0;
            }
        }

        private void buttonFlashcards_Click(object sender, EventArgs e)
        {
            if (workingSet.Cards.Count(card => card.TypeLearning == LearningTypeConstants.StillLearning) == 0)
            {
                //MessageBox.Show("You already KNOW all item from set");
                AppContext.ShowMessage("You already KNOW all item from set", "Error", MessageType.Error);
                return;
            }

            FlashcardForm newForm = new FlashcardForm(workingSet);
            OpenFormAndCloseCurrent(newForm);
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            if (!ValidateCardCount(4, "There is not enough cards to use this mode. There must be at least 4"))
                return;

            int c = countQuestion();
            if (c == 0) return;
            LearnForm newForm = new LearnForm(workingSet, c);
            OpenFormAndCloseCurrent(newForm);
        }

        private void buttonWriting_Click(object sender, EventArgs e)
        {
            if (!ValidateCardCount(4, "There is not enough cards to use this mode. There must be at least 4"))
                return;

            int c = countQuestion();
            if (c == 0) return;
            WritingForm newForm = new WritingForm(workingSet, c);
            OpenFormAndCloseCurrent(newForm);
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            int knowCount = workingSet.Cards.Count(card => card.TypeLearning == LearningTypeConstants.Know);
            double knowPercentage = (double)knowCount / workingSet.Cards.Count * 100;

            if (knowPercentage >= 70)
            {
                MiniGame newForm = new MiniGame(workingSet);
                OpenFormAndCloseCurrent(newForm);
            }
            else
            {
                //MessageBox.Show("You need to know at least 70% of the cards to play the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppContext.ShowMessage("You need to know at least 70% of the cards to play the game.", "Error", MessageType.Error);
            }

        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            if (!ValidateCardCount(6, "There is not enough cards to use this mode. There must be at least 6"))
                return;

            MatchForm newForm = new MatchForm(workingSet);
            OpenFormAndCloseCurrent(newForm);
        }
    }
}
