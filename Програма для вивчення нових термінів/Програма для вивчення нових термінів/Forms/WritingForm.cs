using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Програма_для_вивчення_нових_термінів.QuestionsClasses;
using static Програма_для_вивчення_нових_термінів.WritingForm;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class WritingForm : Form
    {
        StudySet workingSet;
        int countQuestion;
        int countAll = 1;
        List<QuestionForWriting> cardsQuestion;

        public WritingForm(StudySet studySet, int countQ)
        {
            InitializeComponent();
            workingSet = studySet;
            countQuestion = countQ;
            GenerateQuestion();
            UpdateElementsOnTheForm();
        }

        private void UpdateElementsOnTheForm()
        {
            labelTitleCount.Text = $"{countAll}/{countQuestion}\n{workingSet.Title}";
            labelQuestion.Text = cardsQuestion[countAll - 1].Question;
            textBoxAnswer.Text = "";
            textBoxAnswer.Focus();
        }

        //private void UpdateElementsOnTheForm()
        //{
        //    labelTitleCount.Text = $"{countAll}/{countQuestion}\n{workingSet.Title}";
        //    labelQuestion.Text = cardsQuestion[countAll - 1].card.Definition;
        //    textBox1.Text = "";
        //}

        //private void GenerateQuestion() 
        //{
        //    Random random = new Random();
        //    List<Card> allCards = new List<Card>(workingSet.Cards);
        //    allCards.Shuffle(random);
        //    cardsQuestion = new List<QuestionForWriting>();

        //    for (int i = 0; i < countQuestion; i++)
        //    {
        //        QuestionForWriting newQ = new QuestionForWriting(allCards[i], false);
        //        cardsQuestion.Add(newQ);
        //    }
        //}

        private void GenerateQuestion()
        {
            Random random = new Random();
            List<Card> shuffledCards = workingSet.Cards.OrderBy(x => random.Next()).ToList();

            cardsQuestion = new List<QuestionForWriting>();

            foreach (Card card in shuffledCards.Take(countQuestion))
            {
                QuestionForWriting newQ = new QuestionForWriting();
                newQ.Question = card.Definition;

                // Знаходимо всі терміни, які мають таке ж значення, як і definition в питанні
                newQ.RightAnswers = workingSet.Cards
                    .Where(c => c.Definition == card.Definition)
                    .Select(c => c.Term)
                    .ToArray();

                cardsQuestion.Add(newQ);
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            string answer = textBoxAnswer.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(answer))
            {
                //MessageBox.Show("Error: enter the answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppContext.ShowMessage("Error: enter the answer", "Error", MessageType.Error);
                return;
            }

            // Перевіряємо на унікальність відповіді
            if (cardsQuestion.Any(q => q.Question == cardsQuestion[countAll - 1].Question &&
                                       q.UserAnswer?.ToLower() == answer))
            {
                //MessageBox.Show("You have already used such an answer for such a question.\nThink again");
                AppContext.ShowMessage("You have already used such an answer for such a question.\nThink again", "Think again!", MessageType.Warning);
                return;
            }

            // Перевіряємо чи відповідь правильна
            bool isCorrect = cardsQuestion[countAll - 1].RightAnswers.Any(rightAnswer => rightAnswer.ToLower() == answer);
            cardsQuestion[countAll - 1].UserAnswer = answer;
            cardsQuestion[countAll - 1].Correct = isCorrect;

            RightWrongAnswer resultminiform = new RightWrongAnswer(cardsQuestion[countAll - 1]);
            resultminiform.ShowDialog();

            countAll++;
            if (countAll > countQuestion)
            {
                ResultForm newf = new ResultForm(cardsQuestion, workingSet);
                this.Close();
                newf.Show();
                return;
            }

            UpdateElementsOnTheForm();

        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormShowSet newf = new FormShowSet(workingSet);
            FormForMain mainForm = AppContext.GetMainForm();
            mainForm.OpenChildForm(newf);
            mainForm.Show();
            this.Close();
        }

        //private void buttonContinue_Click(object sender, EventArgs e)
        //{
        //    string answer = textBox1.Text.ToLower();
        //    RightWrongAnswer resultminiform;
        //    if (answer == null || answer == "")
        //    {
        //        MessageBox.Show("Error: enter the answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    if (answer == cardsQuestion[countAll - 1].card.Term.ToLower())
        //    {
        //        resultminiform = new RightWrongAnswer(cardsQuestion[countAll - 1].card.Term, 'r');
        //        cardsQuestion[countAll - 1].correct = true;
        //    }
        //    else
        //    {
        //        resultminiform = new RightWrongAnswer(cardsQuestion[countAll - 1].card.Term, 'w');
        //    }
        //    resultminiform.ShowDialog();
        //    countAll++;
        //    if (countAll > countQuestion)
        //    {
        //        ResultForm newf = new ResultForm(cardsQuestion, workingSet);
        //        this.Close();
        //        newf.Show();
        //        return;
        //    }

        //    UpdateElementsOnTheForm();
        //}

        //private void buttonContinue_Click(object sender, EventArgs e)
        //{
        //    //знаходження всіх правильних відповідей для цього питання
        //    string answer = textBoxAnswer.Text.Trim().ToLower();        
        //    if (answer == null || answer == "")
        //    {
        //        MessageBox.Show("Error: enter the answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
            
        //    RightWrongAnswer resultminiform;
        //    bool isUnique = true;

        //    for (int i = 0; i < cardsQuestion.Count; i++)
        //    {
        //        if (i != countAll - 1 && cardsQuestion[i].Question == cardsQuestion[countAll - 1].Question)
        //        {
        //            if (cardsQuestion[i].UserAnswer == answer && cardsQuestion[i].Correct)
        //            {
        //                isUnique = false;
        //                break;
        //            }
        //        }
        //    }

        //    if (!isUnique)
        //    {
        //        MessageBox.Show("You have already used such an answer for such a question.\nThink again");
        //        return;
        //    }

        //    if (cardsQuestion[countAll - 1].RightAnswers.Any(rightAnswer => rightAnswer.ToLower() == answer))
        //    {         
        //        cardsQuestion[countAll - 1].UserAnswer = answer;
        //        cardsQuestion[countAll - 1].Correct = true;
        //        resultminiform = new RightWrongAnswer(cardsQuestion[countAll-1]);
        //    }
        //    else
        //    {
        //        cardsQuestion[countAll - 1].Correct = false;
        //        resultminiform = new RightWrongAnswer(cardsQuestion[countAll - 1]);
        //    }
        //    resultminiform.ShowDialog();
        //    countAll++;
        //    if (countAll > countQuestion)
        //    {
        //        ResultForm newf = new ResultForm(cardsQuestion, workingSet);
        //        this.Close();
        //        newf.Show();
        //        return;
        //    }

        //    UpdateElementsOnTheForm();
        //}

    }

}
