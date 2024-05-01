using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Програма_для_вивчення_нових_термінів
{
    internal class AppContext
    {
        private static AppContext _instance;

        public User CurrentUser { get; private set; }

        private AppContext()
        {
            //  не можна створювати об'єкти
        }

        public static AppContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppContext();
                }
                return _instance;
            }
        }

        public void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }

        static public FormForMain GetMainForm()
        {
            return Application.OpenForms.OfType<FormForMain>().Where(x => x.Name == "FormForMain").FirstOrDefault();
        }

        static public void ShowMessage(string message, string title, MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Error:
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MessageType.Warning:
                    MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
                case MessageType.Success:
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }    
    }
    public enum MessageType
    {
        Error,
        Warning,
        Success
    }

    public enum ProgramState
    {
        Running,
        Logout,
        DeleteAccount
    }

    public static class LearningTypeConstants
    {
        public const string StillLearning = "Still learning";
        public const string Know = "Know";
    }

    //public enum CardLearningModes 
    //{ 
    //    Flashcards,
    //    Learning,
    //    Writing,
    //    Match,
    //    Minigame
    //}
    public static class ListExtensions
    {
        public static void Shuffle<T>(this IList<T> list, Random random)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

}

