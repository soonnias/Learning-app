using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Програма_для_вивчення_нових_термінів
{
    internal class ResultsMessage
    {
        private static string[] awesomeResults = { "You're smashing it! Keep up the fantastic work!", "Wow! Your progress is truly impressive. Keep pushing yourself to reach even greater heights!", "Incredible job! You're on fire. Keep the momentum going!" };
        private static string[] mediumResults = { "You're doing well, but there's always room for improvement. Keep striving for excellence!", "You're making progress, but let's kick it up a notch! You've got this!", "Keep going! You're on the right track. With a little more effort, you'll reach your goals." };
        private static string[] badResults = { "It's okay to stumble. Use this setback as motivation to come back even stronger!", "Don't be discouraged by the results. Every challenge is an opportunity to learn and grow.", "Remember, success is not linear. Keep your head up and keep pushing forward. You'll get there!" };

        public static string GetAwesomeResult()
        {
            Random rand = new Random();
            return awesomeResults[rand.Next(awesomeResults.Length)];
        }

        public static string GetMediumResult()
        {
            Random rand = new Random();
            return mediumResults[rand.Next(mediumResults.Length)];
        }

        public static string GetBadResult()
        {
            Random rand = new Random();
            return badResults[rand.Next(badResults.Length)];
        }
    }
}
