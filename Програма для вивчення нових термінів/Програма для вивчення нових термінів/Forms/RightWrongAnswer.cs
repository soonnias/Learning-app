using ComponentFactory.Krypton.Toolkit;
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
using System.Windows.Interop;
using static Програма_для_вивчення_нових_термінів.QuestionsClasses;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class RightWrongAnswer : Form
    {
        public RightWrongAnswer()
        {
            InitializeComponent();
        }

        ////для writing
        //public RightWrongAnswer(string rightAnswer, char rightorwrong)
        //{
        //    InitializeComponent();
        //    if (rightorwrong == 'r')
        //    {
        //        this.Text = "Success";
        //        label1.Text = $"You're correct!";
        //        label2.Text = $"Right answer: {rightAnswer}";
        //        label1.ForeColor = Color.DarkGreen;
        //    }

        //    if (rightorwrong == 'w')
        //    {
        //        label1.Text = $"Not quite. You're still learning!";
        //        label2.Text = $"Right answer: {rightAnswer}";
        //        label1.ForeColor = Color.DarkGoldenrod;
        //        this.Text = "Error";
        //    }
        //}

        //для writing
        internal RightWrongAnswer(QuestionForWriting question)
        {
            InitializeComponent();
            InitializeComponentFromWriting(question);
        }

        private void InitializeComponentFromWriting(QuestionForWriting question)
        {
            if (question.Correct)
            {
                this.Text = "Success";
                label1.Text = $"You're correct!";
                label2.Text = $"You wrote the correct answer: {question.UserAnswer}";
                if (question.RightAnswers.Length > 1)
                    label2.Text += $"\nBut there are also other answers to this question";
                label1.ForeColor = Color.DarkGreen;
            }

            else
            {
                label1.Text = $"Not quite. You're still learning!";
                label2.Text = $"The correct answers could be: ";
                foreach (string answer in question.RightAnswers)
                    label2.Text += $"{answer}; ";
                label1.ForeColor = Color.DarkGoldenrod;
                this.Text = "Error";
            }
        }

        public RightWrongAnswer(char rightOrWrong, string rightAnswer)
        {
            InitializeComponent();
            InitializeComponentFromMiniGame(rightOrWrong, rightAnswer);
        }

        private void InitializeComponentFromMiniGame(char rightOrWrong, string rightAnswer)
        {
            if (rightOrWrong == 'r')
            {
                this.Text = "Guessed!";
                label1.Text = $"Congratulations!\nYou guessed the word!";
                label2.Text = $"Right answer: {rightAnswer}";
                label1.ForeColor = Color.DarkGreen;
            }

            if (rightOrWrong == 'w')
            {
                label1.Text = $"Not guessed(";
                label1.ForeColor = Color.DarkGoldenrod;
                label2.Text = $"Right answer: {rightAnswer}";
                this.Text = "Not guessed(";
            }
        }

        public RightWrongAnswer(string time)
        {
            InitializeComponent();
            InitializeComponentFromMatch(time);
        }

        private void InitializeComponentFromMatch(string time) {

            string[] parts = time.Split('.');
            int speed = int.Parse(parts[0]);

            if (speed >= 10 && speed <= 20)
            {
                string[] phrases = { "Great job!", "You're doing amazing!" };
                int index = new Random().Next(phrases.Length);
                label1.Text = phrases[index] + "\nYou did it in";
            }
            else if (speed > 20 && speed <= 40)
            {
                string[] phrases = { "Good work!", "Not bad at all!" };
                int index = new Random().Next(phrases.Length);
                label1.Text = phrases[index] + "\nYou did it in";
            }
            else
            {
                string[] phrases = { "Don't worry, keep trying!", "It's okay, you'll get better!" };
                int index = new Random().Next(phrases.Length);
                label1.Text = phrases[index] + "\nYou did it in";
            }

            label2.Text = $"{time}";
            label2.ForeColor = Color.DarkGreen;
            this.Text = "You did it!";
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
