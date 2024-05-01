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

namespace Програма_для_вивчення_нових_термінів
{
    public partial class ResultForm : Form
    {

        private const double AwesomeResultThreshold = 80;
        private const double MediumResultThreshold = 50;

        public ResultForm()
        {
            InitializeComponent();
        }
        StudySet workingSet;

        public ResultForm(StudySet workingSetFromFlashcard)
        {
            InitializeComponent();
            workingSet = workingSetFromFlashcard;
            labelTitle.Text = workingSetFromFlashcard.Title;
            buttonNameRegime.Text = "Flashcards";

            var knowCardsCount = workingSetFromFlashcard.Cards.Where(card => card.TypeLearning == LearningTypeConstants.Know);
            var learningCardsCount = workingSetFromFlashcard.Cards.Where(card => card.TypeLearning == LearningTypeConstants.StillLearning);

            SetupAnswerSections(knowCardsCount, learningCardsCount);

            UpdateChart(knowCardsCount.Count(), learningCardsCount.Count(), workingSetFromFlashcard.Cards.Count);
            UpdateResultsMessage(knowCardsCount.Count(), workingSetFromFlashcard.Cards.Count);
        }
        private void UpdateResultsMessage(int rightAnswer, int allQuestions)
        {
            double percent = ((double)rightAnswer / allQuestions) * 100;
            if (percent >= AwesomeResultThreshold)
            {
                labelComment.Text = ResultsMessage.GetAwesomeResult();
            }
            else if (percent >= MediumResultThreshold)
            {
                labelComment.Text = ResultsMessage.GetMediumResult();
            }
            else
            {
                labelComment.Text = ResultsMessage.GetBadResult();
            }
        }

        internal ResultForm(List<QuestionForWriting> questions, StudySet workingSetFromLearn)
        {
            InitializeComponent();
            workingSet = workingSetFromLearn;
            labelTitle.Text = workingSetFromLearn.Title;
            buttonNameRegime.Text = "Writing";

            var rightAnswers = questions.Where(question => question.Correct);
            var wrongAnswers = questions.Where(question => !question.Correct);
            SetupAnswerSections(rightAnswers, wrongAnswers);

            UpdateChart(rightAnswers.Count(), wrongAnswers.Count(), questions.Count);
            UpdateResultsMessage(rightAnswers.Count(), questions.Count);
        }
        internal ResultForm(List<QuestionForLearn> questions, StudySet workingSetFromLearn, char from)
        {
            InitializeComponent();
            workingSet = workingSetFromLearn;
            labelTitle.Text = workingSetFromLearn.Title;
            buttonNameRegime.Text = "Learn";

            var rightAnswers = questions.Where(question => question.IsCorrectAnswer);
            var wrongAnswers = questions.Where(question => !question.IsCorrectAnswer);
            SetupAnswerSections(rightAnswers, wrongAnswers);

            UpdateChart(rightAnswers.Count(), wrongAnswers.Count(), questions.Count);
            UpdateResultsMessage(rightAnswers.Count(), questions.Count);
        }

        private void UpdateChart(int rightAnswer, int wrongAnswer, int totalQuestions)
        {
            if (rightAnswer != 0)
            {
                double rightPercentage = ((double)rightAnswer / totalQuestions) * 100;
                chart1.Series["Series1"].Points.AddXY($"{rightPercentage:F2}%", rightAnswer);
                chart1.Series["Series1"].Points[0].Color = Color.DarkGreen;
            }

            if (wrongAnswer != 0)
            {
                double learningPercentage = ((double)wrongAnswer / totalQuestions) * 100;
                chart1.Series["Series1"].Points.AddXY($"{learningPercentage:F2}%", wrongAnswer);
                if (rightAnswer == 0)
                    chart1.Series["Series1"].Points[0].Color = Color.Orange;
                else
                    chart1.Series["Series1"].Points[1].Color = Color.Orange;
            }
        }

        private void PopulateDataGridView<T>(DataGridView dataGridView, IEnumerable<T> items)
        {
            dataGridView.Rows.Clear();
            foreach (T item in items)
            {
                if (typeof(T) == typeof(QuestionForLearn))
                {
                    var question = item as QuestionForLearn;
                    var correctAnswers = question.Answers.Where(a => a.IsCorrect).Select(a => a.TextToShow).Distinct();
                    dataGridView.Rows.Add(question.TextToShow, string.Join(", ", correctAnswers));
                }
                else if (typeof(T) == typeof(Card))
                {
                    var card = item as Card;
                    dataGridView.Rows.Add(card.Term, card.Definition);
                }
                else if (item is QuestionForWriting questionWriting)
                {
                    string answersText = questionWriting.Correct ? char.ToUpper(questionWriting.UserAnswer[0]) + questionWriting.UserAnswer.Substring(1) : string.Join(", ", questionWriting.RightAnswers);
                    dataGridView.Rows.Add(questionWriting.Question, answersText);
                }
            }
        }

        private void SetupAnswerSections<T>(IEnumerable<T> correctItems, IEnumerable<T> incorrectItems)
        {
            string positiveText, negativeText;
            string firstColumnHeader, positiveHeader, negativeHeader;

            // визначення надписів
            //if (typeof(T) == typeof(StudySet))
            //{
            //    positiveText = LearningTypeConstants.Know;
            //    negativeText = LearningTypeConstants.StillLearning;
            //    firstColumnHeader = "Term";
            //    positiveHeader = "Definition";
            //    negativeHeader = "Definition";
            //}
            if (typeof(T) == typeof(QuestionForWriting) || typeof(T) == typeof(QuestionForLearn))
            {
                positiveText = "Right answers";
                negativeText = "Wrong answers";
                firstColumnHeader = "Question";
                positiveHeader = "Correct answers";
                negativeHeader = "Possible correct answers";
            }
            else
            {
                positiveText = LearningTypeConstants.Know;
                negativeText = LearningTypeConstants.StillLearning;
                firstColumnHeader = "Term";
                positiveHeader = "Definition";
                negativeHeader = "Definition";
            }

            // знаходження правильних відповідей
            if (correctItems.Any())
            {
                PositiveLabel.Text = positiveText;
                PositiveLabel.ForeColor = Color.DarkGreen;
                PositiveCount.Text = correctItems.Count().ToString();
                dataGridView1.Columns[0].HeaderText = firstColumnHeader;
                dataGridView1.Columns[1].HeaderText = positiveHeader;
                PopulateDataGridView(dataGridView1, correctItems);

                groupBox2.Visible = incorrectItems.Any();
                dataGridView2.Visible = incorrectItems.Any();
                
                // знаходження неправильних відповідей
                if (incorrectItems.Any())
                {
                    NegativeLabel.Text = negativeText;
                    NegativeLabel.ForeColor = Color.DarkGoldenrod;
                    NegativeCount.Text = incorrectItems.Count().ToString();
                    dataGridView2.Columns[0].HeaderText = firstColumnHeader;
                    dataGridView2.Columns[1].HeaderText = negativeHeader;
                    PopulateDataGridView(dataGridView2, incorrectItems);
                }
                else
                {
                    NegativeLabel.Visible = false;
                    dataGridView2.Visible = false;
                }
            }
            else
            {
                PositiveLabel.Text = negativeText;
                PositiveLabel.ForeColor = Color.DarkGoldenrod;
                PositiveCount.Text = incorrectItems.Count().ToString();
                dataGridView1.Columns[0].HeaderText = firstColumnHeader;
                dataGridView1.Columns[1].HeaderText = negativeHeader;
                PopulateDataGridView(dataGridView1, incorrectItems);
                groupBox2.Visible = false;
                dataGridView2.Visible = false;
            }
        }

       
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            FormShowSet newf = new FormShowSet(workingSet);
            FormForMain mainForm = AppContext.GetMainForm();
            mainForm.OpenChildForm(newf);
            mainForm.Show();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            buttonReturn_Click(sender, e);
        }
    }
}
