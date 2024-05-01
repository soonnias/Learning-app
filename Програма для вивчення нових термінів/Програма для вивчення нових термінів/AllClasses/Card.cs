using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Програма_для_вивчення_нових_термінів
{
    [DataContract]
    public class Card : IEquatable<Card>
    {
        private string _term;
        private string _definition;
        private string _typeLearning;

        [DataMember]
        public string Term
        {
            get { return _term; }
            set { _term = value; }
        }

        [DataMember]
        public string Definition
        {
            get { return _definition; }
            set { _definition = value; }
        }

        [DataMember]
        public string TypeLearning
        {
            get { return _typeLearning; }
            set { _typeLearning = value; }
        }

        public Card()
        { }

        public Card(string term, string definition)
        {
            Term = term;
            Definition = definition;
            TypeLearning = LearningTypeConstants.StillLearning;
            //TypeLearning = "Know";
        }

        public Card(Card anotherCard)
        {
            Term = anotherCard.Term;
            Definition = anotherCard.Definition;
            TypeLearning = anotherCard.TypeLearning;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Card);
        }

        public bool Equals(Card otherCard)
        {
            if (otherCard == null)
                return false;

            return StringComparer.OrdinalIgnoreCase.Equals(Term, otherCard.Term) &&
                   StringComparer.OrdinalIgnoreCase.Equals(Definition, otherCard.Definition);
        }

        public override int GetHashCode()
        {
            return (Term.ToLowerInvariant() + Definition.ToLowerInvariant()).GetHashCode();
        }

        public static bool operator ==(Card card1, Card card2)
        {
            return Equals(card1, card2);
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }
        public void MarkAsKnown()
        {
            TypeLearning = LearningTypeConstants.Know;
        }

        public void MarkAsStillLearning()
        {
            TypeLearning = LearningTypeConstants.StillLearning;
        }

        public void UpdateDefinition(string newDefinition)
        {
            Definition = newDefinition;
        }

        public override string ToString()
        {
            return $"Term: {Term}, Definition: {Definition}, TypeLearning: {TypeLearning}";
        }
    }
}
//public static bool operator ==(Card card1, Card card2)
//{
//    // Перевірка на обидва об'єкти, якщо один з них null
//    if (ReferenceEquals(card1, card2))
//        return true;

//    // Перевірка на null окремо для кожного об'єкта
//    if (card1 is null || card2 is null)
//        return false;

//    if (card1.Term == card2.Term && card1.Definition == card2.Definition)
//        return true;
//    else return false;
//}'


// Реалізований метод інтерфейсу IEquatable<Card>
//public bool Equals(Card otherCard)
//{
//    return otherCard != null &&
//           Term.Equals(otherCard.Term, StringComparison.OrdinalIgnoreCase) &&
//           Definition.Equals(otherCard.Definition, StringComparison.OrdinalIgnoreCase);
//}
