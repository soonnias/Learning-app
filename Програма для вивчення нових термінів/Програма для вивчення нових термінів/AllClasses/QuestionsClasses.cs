using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Програма_для_вивчення_нових_термінів
{
    internal class QuestionsClasses
    {
        internal class AnswerForLearn
        {
            private string _textToShow;
            private string _textToCheck;
            private bool _isCorrect;

            public string TextToShow { get => _textToShow; set => _textToShow = value; }
            public string TextToCheck { get => _textToCheck; set => _textToCheck = value; }
            public bool IsCorrect { get => _isCorrect; set => _isCorrect = value; }

            public AnswerForLearn(string text, bool correct, string textToCheck)
            {
                _textToShow = text;
                _isCorrect = correct;
                _textToCheck = textToCheck;
            }
            public AnswerForLearn() { }
        }

        internal class QuestionForLearn
        {
            private string _textToShow;
            private string _rightAnswer;
            private List<AnswerForLearn> _answers;
            private char _type;
            private bool _isCorrectAnswer;

            public string TextToShow { get => _textToShow; set => _textToShow = value; }
            public string RightAnswer { get => _rightAnswer; set => _rightAnswer = value; }
            public List<AnswerForLearn> Answers { get => _answers; set => _answers = value; }
            public char Type { get => _type; set => _type = value; }
            public bool IsCorrectAnswer { get => _isCorrectAnswer; set => _isCorrectAnswer = value; }

            public QuestionForLearn(string text, List<AnswerForLearn> answers, char type, string ra)
            {
                _textToShow = text;
                _answers = answers;
                _type = type;
                _rightAnswer = ra;
            }
            public QuestionForLearn() { }
        }

        public class QuestionForWriting
        {
            private string _question;
            private string[] _rightAnswers;
            private string _userAnswer;
            private bool _correct;

            public string Question { get => _question; set => _question = value; }
            public string[] RightAnswers { get => _rightAnswers; set => _rightAnswers = value; }
            public string UserAnswer { get => _userAnswer; set => _userAnswer = value; }
            public bool Correct { get => _correct; set => _correct = value; }

            public QuestionForWriting(string question, string[] rightAnswers, bool correct, string userAnswer)
            {
                _question = question;
                _rightAnswers = rightAnswers;
                _correct = correct;
                _userAnswer = userAnswer;
            }
            public QuestionForWriting() { }
        }

        //public class QuestionForWriting
        //{
        //    public Card card { get; set; }
        //    public bool correct { get; set; }

        //    public QuestionForWriting(Card card, bool correct)
        //    {
        //        this.card = card;
        //        this.correct = correct;
        //    }
        //}
    }
}
