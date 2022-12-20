namespace Refactoring;

public class Grading
{
    private static Dictionary<int, string> grades = new Dictionary<int, string>
    {
        [1] = "A",
        [2] = "B",
        [3] = "C",
        [4] = "D",
        [5] = "E",
        [6] = "F",
    };

    public static char GetLetterGrade(int grade)
    {
        return char.Parse(grades[grade]);
    }
}