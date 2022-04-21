
using System;
using System.Collections.Generic;

namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        public static int GetLongestSentance(string s)
        {
            string[] sentences = s.Split(new Char[] { '!', '.', '?' });
            List<string> finalWordList = new List<string>();

            foreach(var sentence in sentences)
            {
                //var words = sentence.Split(' ');
            }

            return 0;
        }
    }
}




