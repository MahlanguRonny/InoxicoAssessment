using Inoxico.TechnicalQuestions.Answers;
using Xunit;

namespace Inoxico.TechnicalQuestions.Tests
{
    public class QuestionOneTests
    {
        [Fact]
        public void BasicNominalTest()
        {
            var input = $"Forget CVs..Save time . x x";
            var outcome = QuestionOne.GetLongestSentance(input);

            Assert.Equal(2, outcome);
        }
    }
}