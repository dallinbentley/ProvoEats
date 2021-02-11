using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoEats.Models
{
    public static class TempStorage
    {
        private static List<UserSubmission> submissions = new List<UserSubmission>();

        public static IEnumerable<UserSubmission> Submissions => submissions;

        public static void AddSubmission(UserSubmission submission)
        {
            submissions.Add(submission);
        }
    }
}
