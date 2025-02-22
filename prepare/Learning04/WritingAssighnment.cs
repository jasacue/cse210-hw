public class WritingAssighnment : Assighnment
{
    private string _title;


    public WritingAssighnment(string studentName, string topic, string title)
        : base (studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"title: {_title}, name {studentName}";
    }
}