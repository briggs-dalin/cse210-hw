using System;
using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;

    private int _duration;

    public Activity()
    {
      _name = "";
      _description = "";
      _duration = 12;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void AskDuration()
    {
        Console.WriteLine();
        Console.Write("How long would you like the activity to be? (In seconds)");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuraction()
    {
        return _duration;
    }

    public void StartingMessage()
    {
        
    }

    public void EndingMessage()
    {

    }

    public void ShowAnimation()
    {
        
    }

    public void ShowCountdown()
    {

    }

}