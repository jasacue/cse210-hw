public class Assighnment
{
    private string _studentName;
    private string _topic;
    public Assighnment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;

    }    
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetTopic()
    {
        return _topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
}