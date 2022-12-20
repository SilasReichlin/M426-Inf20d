using Xunit;

namespace Refactoring.Tests;

public class GradingTest 
{
    [Fact]
    public void GetLetterGrade_CorrectGrade_ReturnsCorrectGradeLetter()
    {
        var expected = 'A';

        var actual = Grading.GetLetterGrade(1);

        Assert.Equal(expected, actual);
    }
}