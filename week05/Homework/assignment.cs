public class Assignment(string studentName, string topic)
{
    protected string _studentName = studentName;
    protected string _topic = topic;

    public string GetSummary()
    {
        return $"Student Name: {_studentName} - {_topic}";
    }
}
