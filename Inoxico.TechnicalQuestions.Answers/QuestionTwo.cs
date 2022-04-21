
using System.Collections.Generic;
using System.Linq;

namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
            List<int> sums = new List<int>();
            int i = 0;
            var triplets = from x in points
                           let num = i++
                           group x by num / 3 into g
                           select g.ToArray();
            foreach (var item in triplets)
            {
                sums.Add(item.Sum());
            }

            return sums.Max();
        }
    }
}
