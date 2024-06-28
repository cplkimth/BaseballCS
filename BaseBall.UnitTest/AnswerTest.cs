using Baseball;
using FluentAssertions;

namespace BaseBall.UnitTest;

[TestClass]
public class AnswerTest
{
    [TestMethod]
    public void ��_����_int��_�־��_��()
    {
        List<int> answers = Program.GenerateAnswers();

        answers.Count.Should().Be(3);
    }

    [TestMethod]
    public void �ߺ���_�����_��()
    {
        for (int i = 0; i < 100; i++)
        {
            List<int> answers = Program.GenerateAnswers();

            answers.Distinct().Count().Should().Be(3);
        }
    }
}