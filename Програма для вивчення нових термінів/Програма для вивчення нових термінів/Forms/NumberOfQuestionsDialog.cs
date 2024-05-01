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
    public partial class NumberOfQuestionsDialog : Form
    {
        public int SelectedNumberOfQuestions { get; private set; }
        public NumberOfQuestionsDialog(int minQuestions, int maxQuestions)
        {
            InitializeComponent();
            labelMinMax.Text = $"min: {minQuestions}, max: {maxQuestions}";
            numericUpDownCountQuestions.Minimum = minQuestions;
            numericUpDownCountQuestions.Maximum = maxQuestions;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SelectedNumberOfQuestions = (int)numericUpDownCountQuestions.Value;
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
