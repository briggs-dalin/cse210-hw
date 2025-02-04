

public class WritingAssignment : Assignment
{
    private string _title;


    //Writing Assignemnt has 3 parameters and then passes 2 of them to the base 
    //constructor, which is "Assignment" class
    public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}

