
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            //split the sentences using the given delimeters
            string[] sentences = s.Split(new Char[] { '!', '.', '?' });

            var largestSentence = sentences.OrderByDescending(x => x.Length).FirstOrDefault();
            if (largestSentence != null)
                return largestSentence.Split(' ').Length;

            return 0;
        }
    }
}




