using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

using static Програма_для_вивчення_нових_термінів.QuestionsClasses;

namespace Програма_для_вивчення_нових_термінів
{
    public partial class LearnForm : Form
    {
        StudySet workingSet;
        int countQuestion;
        List<QuestionForLearn> questions;
        int countAll = 1;
        List<Card> shuffleCards;


        public LearnForm(StudySet studySet, int countQ)
        {
            InitializeComponent();
            workingSet = studySet;
            countQuestion = countQ; 
            GenerateQuestion();
            UpdateElementsOnTheForm();
        }
        
        private void UpdateElementsOnTheForm()
        {
            labelTitleCount.Text = $"{countAll}/{questions.Count}\n{workingSet.Title}";
            labelTop.Text = questions[countAll - 1].Type == 'd' ? "Definition" : "Term";
            labelQuestion.Text = questions[countAll - 1].TextToShow;
            labelSelect.Text = questions[countAll - 1].Type == 'd' ? "Select the correct term" : "Select the correct definiton";

            button1.Text = questions[countAll - 1].Answers[0].TextToShow.Length > 40 ? questions[countAll - 1].Answers[0].TextToShow.Substring(0, 40) + "..." : questions[countAll - 1].Answers[0].TextToShow;
            button2.Text = questions[countAll - 1].Answers[1].TextToShow.Length > 40 ? questions[countAll - 1].Answers[1].TextToShow.Substring(0, 40) + "..." : questions[countAll - 1].Answers[1].TextToShow;
            button3.Text = questions[countAll - 1].Answers[2].TextToShow.Length > 40 ? questions[countAll - 1].Answers[2].TextToShow.Substring(0, 40) + "..." : questions[countAll - 1].Answers[2].TextToShow;
            button4.Text = questions[countAll - 1].Answers[3].TextToShow.Length > 40 ? questions[countAll - 1].Answers[3].TextToShow.Substring(0, 40) + "..." : questions[countAll - 1].Answers[3].TextToShow;

            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;

            button1.Click += AnswerButtonClick;
            button2.Click += AnswerButtonClick;
            button3.Click += AnswerButtonClick;
            button4.Click += AnswerButtonClick;

            button1.Focus();
        }

        private void GenerateQuestion()
        {
            Random random = new Random();
            List<Card> allCards = new List<Card>(workingSet.Cards);
            shuffleCards = new List<Card>();
            questions = new List<QuestionForLearn>();
 

            for (int i = 0; i < workingSet.Cards.Count; i++)
            {
                int k = random.Next(allCards.Count);
                shuffleCards.Add(allCards[k]);
                allCards.RemoveAt(k);
            }


            // формування питань
            for (int i = 0; i < countQuestion; i++)
            {
                Card card = shuffleCards[i];
                bool isDefinitionQuestion = random.Next(2) == 0;

                QuestionForLearn question = new QuestionForLearn();
                question.TextToShow = isDefinitionQuestion ? card.Definition : card.Term;
                question.RightAnswer= isDefinitionQuestion ? card.Term : card.Definition;
                question.Type = isDefinitionQuestion ? 'd' : 't';

                List<AnswerForLearn> answers = new List<AnswerForLearn>();
                AnswerForLearn answer1 = new AnswerForLearn();

                //правильна відповідь
                answer1.TextToShow = isDefinitionQuestion ? card.Term : card.Definition;
                answer1.TextToCheck = isDefinitionQuestion ? card.Definition : card.Term;
                answer1.IsCorrect = true;
                answers.Add(answer1);


                //формування інших 3 відповідей
                //List<Card> answerCards = shuffleCards.Except(new List<Card> { card }).ToList();
                List<Card> answerCards = workingSet.Cards.Except(new List<Card> { card }).ToList();
                answerCards.Shuffle(random);

                for (int j = 0; j < 3; j++)
                {
                    Card answerCard = answerCards[j];
                    AnswerForLearn answer = new AnswerForLearn();

                    answer.TextToShow = isDefinitionQuestion ? answerCard.Term : answerCard.Definition;
                    answer.TextToCheck = isDefinitionQuestion ? answerCard.Definition : answerCard.Term;

                    if(answer.TextToCheck == question.TextToShow) answer.IsCorrect = true;
                    else if(answer.TextToShow == question.RightAnswer) answer.IsCorrect = true;
                    else answer.IsCorrect = false;
                    answers.Add(answer);
                }
                answers.Shuffle(random);
                question.Answers = answers;
                questions.Add(question);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormShowSet newf = new FormShowSet(workingSet);
            FormForMain mainForm = AppContext.GetMainForm();
            mainForm.OpenChildForm(newf);
            mainForm.Show();
            this.Close();
        }

        private void AnswerButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int answerIndex = int.Parse(clickedButton.Name.Replace("button", "")) - 1;

            if (questions[countAll - 1].Answers[answerIndex].TextToCheck == questions[countAll - 1].TextToShow || questions[countAll - 1].Answers[answerIndex].TextToShow == questions[countAll - 1].RightAnswer)
            {
                clickedButton.BackColor = System.Drawing.Color.DarkGreen;
                questions[countAll - 1].IsCorrectAnswer = true;
            }
            else
            {
                clickedButton.BackColor = System.Drawing.Color.DarkGoldenrod;
                questions[countAll - 1].IsCorrectAnswer = false;
                FindCorrectButton();
            }
            countAll++;
            buttonContinue.Visible = true;

            button1.Click -= AnswerButtonClick;
            button2.Click -= AnswerButtonClick;
            button3.Click -= AnswerButtonClick;
            button4.Click -= AnswerButtonClick;

            buttonContinue.Focus();
        }

        private void FindCorrectButton()
        {
            for (int i = 0; i < questions[countAll - 1].Answers.Count; i++)
            {
                //if (questions[countAll - 1].Answers[i].TextToCheck == questions[countAll - 1].TextToShow || questions[countAll - 1].Answers[i].TextToShow == questions[countAll - 1].RightAnswer)
                if(questions[countAll - 1].Answers[i].IsCorrect)
                {
                    Button correctButton = Controls.Find($"button{i + 1}", true).FirstOrDefault() as Button;
                    correctButton.BackColor = System.Drawing.Color.DarkGreen;
                }
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if(countAll>questions.Count)
            {
                ResultForm newf = new ResultForm(questions, workingSet, 'l');
                this.Close();
                newf.Show();
                return;
            }

            buttonContinue.Visible = false;
            UpdateElementsOnTheForm();       
        }
    }
}
