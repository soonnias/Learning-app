using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Програма_для_вивчення_нових_термінів
{

    [KnownType(typeof(StudySet))]  //ці атрибути допомагають вам правильно налаштувати процес серіалізації 
    [KnownType(typeof(LanguageStudySet))] //та десеріалізації для класів, які мають ієрархію успадкуванн

    [DataContract]
    public class StudySet : IComparable<StudySet>
    {
        protected string _title;
        protected string _description;
        protected DateTime _creationDate;
        protected HashSet<Card> _cards = new HashSet<Card>();

        [DataMember]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DataMember]
        public DateTime CreationDate
        {
            get { return _creationDate; }
            private set { _creationDate = value; }
        }

        [DataMember]
        public HashSet<Card> Cards
        {
            get { return _cards; }
            set { _cards = value; }
        }

        public StudySet() { }

        public StudySet(string title, string description, DateTime creationDate, HashSet<Card> cards)
        {
            Title = title;
            Description = description;
            CreationDate = creationDate;
            Cards = cards;
        }

        public int CompareTo(StudySet other)
        {
            // зворотнє порівняння
            return other.CreationDate.CompareTo(CreationDate);
        }

        public static bool operator ==(StudySet set1, StudySet set2)
        {
            // Перевірка на обидва об'єкти, якщо один з них null
            if (ReferenceEquals(set1, set2))
                return true;

            // Перевірка на null окремо для кожного об'єкта
            if (set1 is null || set2 is null)
                return false;

            if ((set1 is LanguageStudySet) && set2 is LanguageStudySet)
            {
                if (((LanguageStudySet)set1).Language1 != ((LanguageStudySet)set2).Language1 ||
                     ((LanguageStudySet)set1).Language2 != ((LanguageStudySet)set2).Language2)
                    return false;
            }

            if (set1.Title != set2.Title || set1.Description != set2.Description || set1.CreationDate != set2.CreationDate)
            {
                return false;
            }
            else return true;
        }

        public static bool operator !=(StudySet set1, StudySet set2)
        {
            return !(set1 == set2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            StudySet other = (StudySet)obj;

            // Порівняння за власними критеріями
            return Title == other.Title &&
                   Description == other.Description &&
                   CreationDate == other.CreationDate;
        }

        public override int GetHashCode()
        {
            return (Title.ToLowerInvariant() + Description.ToLowerInvariant() + CreationDate.ToLongDateString()).GetHashCode();
        }

        public virtual void WriteToExcel(ExcelWorksheet worksheet)
        {
            worksheet.Cells["A1"].Value = "Title:";
            worksheet.Cells["B1"].Value = Title;

            worksheet.Cells["A2"].Value = "Description:";
            worksheet.Cells["B2"].Value = Description;

            worksheet.Cells["A3"].Value = "Creation Date:";
            worksheet.Cells["B3"].Value = CreationDate.ToString("yyyy-MM-dd HH:mm:ss");

            int row = 6;
            worksheet.Cells[row, 1].Value = "Term";
            worksheet.Cells[row, 2].Value = "Definition";
            row++;

            foreach (Card card in Cards)
            {
                worksheet.Cells[row, 1].Value = card.Term;
                worksheet.Cells[row, 2].Value = card.Definition;
                row++;
            }
        }

        public virtual void WriteToText(StreamWriter writer)
        {
            writer.WriteLine($"Title: {Title}");
            writer.WriteLine($"Description: {Description}");
            writer.WriteLine($"Creation Date: {CreationDate.ToString("yyyy-MM-dd HH:mm:ss")}");

            int maxTermWidth = Cards.Max(card => card.Term.Length);
            int maxDefinitionWidth = Cards.Max(card => card.Definition.Length);

            writer.WriteLine("Term".PadRight(maxTermWidth) + "  " + "Definition".PadRight(maxDefinitionWidth));
            writer.WriteLine(new string('-', maxTermWidth + maxDefinitionWidth));

            foreach (Card card in Cards)
            {
                writer.WriteLine(card.Term.PadRight(maxTermWidth) + "  " + card.Definition.PadRight(maxDefinitionWidth));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Title: {Title}");
            sb.AppendLine($"Description: {Description}");
            sb.AppendLine($"Creation Date: {CreationDate.ToString("yyyy-MM-dd HH:mm:ss")}");

            foreach (var card in Cards)
            {
                sb.AppendLine($"Term: {card.Term}, Definition: {card.Definition}");
            }

            return sb.ToString();
        }

        public virtual string GetSummary()
        {
            return $"Study Set: {Title}, Cards Count: {Cards.Count}";
        }
    }
    [DataContract]
    public class LanguageStudySet : StudySet     
    {
        private string _language1;
        private string _language2;

        [DataMember]
        public string Language1
        {
            get { return _language1; }
            set { _language1 = value; }
        }

        [DataMember]
        public string Language2
        {
            get { return _language2; }
            set { _language2 = value; }
        }
        public LanguageStudySet():base() { }
        public LanguageStudySet(string title, string description, string language1, string language2, DateTime creationDate, HashSet<Card> cards) : base(title,description,creationDate,cards) 
        {
            Language1 = language1;
            Language2 = language2;
        }

        public override void WriteToExcel(ExcelWorksheet worksheet)
        {
            base.WriteToExcel(worksheet);

            worksheet.Cells["A4"].Value = "Language:";
            worksheet.Cells["B4"].Value = $"{Language1} -> {Language2}";
        }

        public override void WriteToText(StreamWriter writer)
        {
            base.WriteToText(writer);
            writer.WriteLine($"Language: {Language1} -> {Language2}");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString()); 

            sb.AppendLine($"Language: {Language1} -> {Language2}");

            return sb.ToString();
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()}, Languages: {Language1} -> {Language2}";
        }
    }

}
