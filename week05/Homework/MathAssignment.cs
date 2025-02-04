

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

//Math Assignment constructor has 4 parameters, with 2 of them being passed into the 
//base "Assignment" constructor.  
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems; 
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}