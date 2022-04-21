
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

            foreach (var sentence in sentences)
            {
                // split words on each sentence using a space
                var words = sentence.Split(' ');
                foreach (var word in words)
                {
                    finalWordList.Add(word);
                }
            }

            return finalWordList.OrderByDescending(x => x.Length).First().Length;
        }
    }
}




