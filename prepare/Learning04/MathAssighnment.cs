using Microsoft.Win32.SafeHandles;

public class MathAssighnment : Assighnment
{
    private string _textbookSection;
    private string _problems;

    public MathAssighnment(string studentName, string topic, string textbook, string problems)
        :base(studentName, topic)
    {
        _textbookSection = textbook;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $" List: {_textbookSection},  problems {_problems}";
    }
}