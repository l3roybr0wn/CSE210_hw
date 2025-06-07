// WritingAssignment.cs
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Call the base class constructor
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - {_title}";
    }

    // Optionally, you can add a method to get the student's name
    public string GetStudentName()
    {
        return _studentName; // This would require _studentName to be protected in the base class
    }
}
