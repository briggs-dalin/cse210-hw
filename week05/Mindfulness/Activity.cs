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
        SetDuration(Convert.ToInt32(durationString)); //A fancy line that converts any primitive type to an int (Found on google)
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuraction()
    {
        return _duration;
    }

    //Prepares user for the start of activity
    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Get ready for the activity...");
        ShowAnimation(5); //Shows animation to start activity and that the program is still working
    }
    //Lets user know the activity is finishing up
    public void EndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done! You have completed the {_name} activity.");
        ShowAnimation(4); //Shows animation to finish activity
    }

    //Doing Period animation (I liked it for the simplicity and looking nice.)
    public void ShowAnimation(int totalSeconds) 
    {
        for (int i = 0; i < totalSeconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void GenerateCountdownTimer(int totalSeconds)
    {
        int timerPosition = 25; //Position for Countdown timer on console
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        for (int i = 0; i <= totalSeconds; i++)
        {
            Console.CursorLeft = timerPosition;
            Console.Write(totalSeconds - i);
            Thread.Sleep(timerWait);
        }
        Console.CursorLeft = timerPosition;
        Console.WriteLine(" ");
    }
    public void ShowCountDown(int totalSeconds)
    {
        Console.WriteLine("Starting Countdown...");
        GenerateCountdownTimer(totalSeconds); //Calls to show countdown
    }

}