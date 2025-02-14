using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _accumulatedPoints = 0;

    public int GetAccumulatedPoints() {

        int points = _accumulatedPoints;
        return points;

    }
    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalAGP = GetAccumulatedPoints();
            outputFile.WriteLine(totalAGP.ToString());
            
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear(); 

        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _accumulatedPoints = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(eternalGoal);

            } else if (parts[0] == "ChecklistGoal") {
                
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goals.Add(checklistGoal);

            }
        }

    }

    public void ListGoal()
    {

    }

    public void AddGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void CalculateAGP()
    {
        
    }


    
}