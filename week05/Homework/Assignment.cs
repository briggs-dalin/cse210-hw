using System;

public class Assignment
{
    private string _studentName;
    private string _topic;


    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    /* Providing getters for our private variables so they can be accessed 
    later both outside the class and same as derived classes*/

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}