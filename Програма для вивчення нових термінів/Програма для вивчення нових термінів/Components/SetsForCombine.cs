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
    public partial class SetsForCombine : UserControl
    {
        StudySet Set;
        bool checkedForAdd = false;
        public SetsForCombine()
        {
            InitializeComponent();
            Set = new StudySet();
        }

        public SetsForCombine(StudySet studySet)
        {
            InitializeComponent();
            Set = studySet;
            button.Text = Set.Title;
            button.TextAlign = ContentAlignment.MiddleLeft;

            int rightPadding = 150;
            button.Padding = new Padding(0, 0, rightPadding, 0);
            label1.Text = $"{Set.Cards.Count} terms";
        }

        public event EventHandler<StudySetEventArgs> StudySetCombined;

        private void OnStudySetCombined(bool isChecked)
        {
            StudySetCombined?.Invoke(this, new StudySetEventArgs(Set, isChecked));
        }

        private void pictureCombine_Click(object sender, EventArgs e)
        {
            ChangeCheckSetForCombine();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeCheckSetForCombine();
        }

        private void ChangeCheckSetForCombine()
        {
            if (!checkedForAdd)
            {
                pictureCombine.Image = Properties.Resources.minus;
                checkedForAdd = true;
                OnStudySetCombined(true);
            }
            else
            {
                pictureCombine.Image = Properties.Resources.free_icon_add_button_2740600;
                checkedForAdd = false;
                OnStudySetCombined(false);
            }
        }
    }

    public class StudySetEventArgs : EventArgs
    {
        public StudySet StudySet { get; }
        public bool IsChecked { get; }

        public StudySetEventArgs(StudySet studySet, bool isChecked)
        {
            StudySet = studySet;
            IsChecked = isChecked;
        }
    }
}
