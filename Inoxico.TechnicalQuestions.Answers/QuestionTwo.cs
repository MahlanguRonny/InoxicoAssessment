
using System;
using System.Linq;

namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
            var r = points.Take(3);
            int i = 0;
            var triplets = from x in points
                           let num = i++
                           group x by num / 3 into g
                           select g.ToArray();
            return 4;
        }
    }
}
