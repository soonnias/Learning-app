using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Програма_для_вивчення_нових_термінів
{

    public partial class MiniGame : Form
    {
        private HashSet<char> wrongSymbols = new HashSet<char>();
        private int correctGuesses = 0;

        StudySet workingSet;
        string randomWord;
        int countError;
        int lettersCount;

        public MiniGame(StudySet studySet)
        {
            InitializeComponent();
            workingSet = studySet;
            labelTitle.Text = workingSet.Title;
            string[] words = ChooseWords(workingSet.Cards);

            Random rnd = new Random();
            randomWord = words[rnd.Next(words.Length)];
            randomWord = randomWord.ToLowerInvariant();
            lettersCount = randomWord.Length - randomWord.Count(char.IsWhiteSpace);

            string displayWord = "";
            foreach (char letter in randomWord)
            {
                displayWord += letter == ' ' ? "  " : "_ ";
            }
            secretWord.Text = "Word: " + displayWord;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormShowSet newf = new FormShowSet(workingSet);
            FormForMain mainForm = AppContext.GetMainForm();
            mainForm.OpenChildForm(newf);
            mainForm.Show();
            this.Close();
        }

        public static string[] ChooseWords(HashSet<Card> cards)
        {
            List<string> suitableWords = new List<string>();
            // Створення регулярного виразу для вибору слів з одного або двох слів
            Regex regex = new Regex(@"^\b\w+\s?\w*\b$");

            // Перебір всіх карт і вибір слів для загадування
            foreach (var card in cards)
            {
                if (regex.IsMatch(card.Term))
                {
                    suitableWords.Add(card.Term);
                }
            }
            return suitableWords.ToArray();
        }

        private void buttonCheckSymbol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEnterSymbol.Text))
            {
                return; 
            }
            char inputChar = textBoxEnterSymbol.Text.ToLower().FirstOrDefault();

            textBoxEnterSymbol.Focus();

            if (!wrongSymbols.Add(inputChar)) 
            {
                //MessageBox.Show("This character has already been entered.", "Message");
                AppContext.ShowMessage("This character has already been entered.", "Error", MessageType.Error);
                return;
            }

            if (randomWord.Contains(inputChar))
            {
                StringBuilder displayWordBuilder = new StringBuilder(secretWord.Text.Substring(6)); // Починаємо з індексу 6, щоб пропустити "Word: "
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == inputChar)
                    {
                        displayWordBuilder[i * 2] = inputChar; // Індекси символів у відображуваному слові вдвічі більші, оскільки вони відділені пробілами
                        correctGuesses++;
                    }
                }
                secretWord.Text = "Word: " + displayWordBuilder.ToString();
            }
            else
            {
                richTextBoxWrongLetters.Text += inputChar.ToString().ToUpper() + " ";
                countError++;
                changePicture();
            }
            textBoxEnterSymbol.Clear();

            if (countError == 7)
            {

                RightWrongAnswer nf = new RightWrongAnswer('w', randomWord);
                nf.ShowDialog();
                buttonClose_Click(sender, e);
            }

            if (correctGuesses == lettersCount)
            {
                RightWrongAnswer nf = new RightWrongAnswer('r', randomWord);
                nf.ShowDialog();
                buttonClose_Click(sender, e);
            }           
        }

        private void changePicture()
        {
            switch (countError)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    break;
                default:
                    break;
            }
        }

        private void textBoxEnterSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            if (textBoxEnterSymbol.Text.Length > 0 || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
