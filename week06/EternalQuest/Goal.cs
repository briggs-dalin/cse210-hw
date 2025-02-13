

public class Goal
{
    private string _name;
    private string _description;

    private string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    protected void CreateBaseGoal()
    {
        
    }

    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

    public virtual void CreateChildGoal()
    {

    }

    public virtual void RecordEvent()
    {

    }


    public virtual Boolean IsComplete()
    {
        return false;
    }

    public virtual void ListGoal()
    {

    }

    public virtual int CalculateAGP()
    {
        return 0;
    }
}