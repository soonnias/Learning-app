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
    internal partial class SetsButton : UserControl
    {
        StudySet Set;
        public SetsButton()
        {
            InitializeComponent();
            Set  = new StudySet();
        }

        public SetsButton(StudySet studySet)
        {
            InitializeComponent();
            Set = studySet;
            button.Text = Set.Title;
            button.TextAlign = ContentAlignment.MiddleLeft;

            int rightPadding = 150; 
            button.Padding = new Padding(0, 0, rightPadding, 0);
            label1.Text = $"{Set.Cards.Count} terms";
            label2.Text = Set.CreationDate.ToString("dd.MM.yyyy HH:mm");
        }

        private void button_Click(object sender, EventArgs e)
        {
            FormShowSet newf = new FormShowSet(Set);
            FormForMain mainForm = Application.OpenForms.OfType<FormForMain>().Where(x => x.Name == "FormForMain").FirstOrDefault();
            mainForm.OpenChildForm(newf);
        }
    }
}
