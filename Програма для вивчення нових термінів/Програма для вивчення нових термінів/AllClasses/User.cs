using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Програма_для_вивчення_нових_термінів
{
    internal interface IUser
    {
        string UserName { get; }
        DateTime DateOfBirth { get; }
        string Email { get; }
        string Password { get; }
        SortedSet<StudySet> StudySets { get; }
        string GetUserProfileInfo(); 
        string GetStudySetsInfo();
    }

    [DataContract]
    internal class User: IUser
    {
        private string _userName;
        private DateTime _dateOfBirth;
        private string _email;
        private string _password;
        private SortedSet<StudySet> _studySets = new SortedSet<StudySet>();

        [DataMember]
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        [DataMember]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DataMember]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        [DataMember]
        public SortedSet<StudySet> StudySets
        {
            get { return _studySets; }
            set { _studySets = value; }
        }
        public User() { }
        public User(string username, DateTime dateofbirth, string email, string password, SortedSet<StudySet> studyset)
        {
            _userName = username;
            _dateOfBirth = dateofbirth;
            _email = email;
            _password = password;
            _studySets = studyset;
        }

        public User(string username, DateTime dateofbirth, string email, string password)
            : this(username, dateofbirth, email, password, new SortedSet<StudySet>()) { }

        public User(User anotherUser)
            : this(anotherUser.UserName, anotherUser.DateOfBirth, anotherUser.Email, anotherUser.Password, anotherUser.StudySets) { }

        public string GetUserProfileInfo()
        {
            StringBuilder profileInfo = new StringBuilder();
            profileInfo.AppendLine($"User Profile Information:");
            profileInfo.AppendLine($"Username: {UserName}");
            profileInfo.AppendLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
            profileInfo.AppendLine($"Email: {Email}");

            return profileInfo.ToString();
        }

        public string GetStudySetsInfo()
        {
            StringBuilder setsInfo = new StringBuilder();
            setsInfo.AppendLine($"Study Sets Information:");
            foreach (var studySet in StudySets)
            {
                string description = !string.IsNullOrEmpty(studySet.Description) ? $", Description: {studySet.Description}" : "";
                setsInfo.AppendLine($"{studySet.GetSummary()}{description}");
            }
            return setsInfo.ToString();
        }

    }
}
