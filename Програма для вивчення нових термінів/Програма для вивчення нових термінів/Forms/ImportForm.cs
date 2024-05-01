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
    public partial class ImportForm : Form
    {
        StudySet setWithoutEditing;
        StudySet setForImport;
        HashSet<Card> newCardsToSet = new HashSet<Card>();
        char createOrEdit;

        public ImportForm(StudySet setWithoutEditing, StudySet studySet, char createOrEdit)
        {
            this.setWithoutEditing = setWithoutEditing;
            this.setForImport = studySet;
            this.createOrEdit = createOrEdit;
            newCardsToSet = setForImport.Cards;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var newForm = CreateStudySetForm();
            OpenChildForm(newForm);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            AddCardsFromText(importedData.Text);
            var newForm = CreateStudySetForm();
            OpenChildForm(newForm);
        }

        private void separatorCustom_CheckedChanged(object sender, EventArgs e)
        {
            symbolForSeparate.ReadOnly = !separatorCustom.Checked;
            symbolForSeparate.Text = "";
        }

        private void symbolForSeparate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
               e.Handled = symbolForSeparate.Text.Length > 0 || char.IsWhiteSpace(e.KeyChar);
            }
        }


        private void AddCardsFromText(string data)
        {
            char separator = GetSeparator();
            string[] lines = (data + "\n").Split('\n');

            foreach (string line in lines.Where(l => !string.IsNullOrWhiteSpace(l)))
            {
                string[] parts = line.Split(new[] { separator }, 2);
                if (parts.Length == 2)
                {
                    newCardsToSet.Add(new Card(parts[0].Trim(), parts[1].Trim()));
                }
            }
        }

        private char GetSeparator()
        {
            if (separatorTab.Checked) return '\t';
            if (separatorComma.Checked) return ',';
            if (separatorCustom.Checked && symbolForSeparate.Text.Length > 0)
                return symbolForSeparate.Text[0];
            return '\t'; 
        }

        private CreateOrEditStudySet CreateStudySetForm()
        {
            if (createOrEdit == 'c')
                return new CreateOrEditStudySet(setWithoutEditing, setForImport, 'c', newCardsToSet);
            else if (createOrEdit == 'e')
                return new CreateOrEditStudySet(setWithoutEditing, setForImport, 'e', newCardsToSet);
            return new CreateOrEditStudySet();
        }

        private void OpenChildForm(Form childForm)
        {
            var mainForm = Application.OpenForms.OfType<FormForMain>().FirstOrDefault(f => f.Name == "FormForMain");
            mainForm?.OpenChildForm(childForm);
        }

        //private void symbolForSeparate_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Back)
        //    {
        //        return;
        //    }

        //    if (symbolForSeparate.Text.Length > 0 || char.IsWhiteSpace(e.KeyChar))
        //    {
        //        e.Handled = true; 
        //    }
        //}
    }
}
