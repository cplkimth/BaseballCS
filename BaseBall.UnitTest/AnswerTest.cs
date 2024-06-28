using Baseball;
using FluentAssertions;

namespace BaseBall.UnitTest;

[TestClass]
public class AnswerTest
{
    [TestMethod]
    public void 세_개의_int가_있어야_함()
    {
        List<int> answers = Program.GenerateAnswers();

        answers.Count.Should().Be(3);
    }

    [TestMethod]
    public void 중복이_없어야_함()
    {
        for (int i = 0; i < 100; i++)
        {
            List<int> answers = Program.GenerateAnswers();

            answers.Distinct().Count().Should().Be(3);
        }
    }
}