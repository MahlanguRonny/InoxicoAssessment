
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
            List<string> finalWordList = new List<string>();

            var largestSentence = sentences.OrderByDescending(x => x.Length).FirstOrDefault();
            var numberOfWords = largestSentence.Split(' ').Count();

            return numberOfWords;
        }
    }
}




