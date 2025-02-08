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
      _duration = 15;
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
        Console.Write("How long would you like the activity to be? (In seconds): ");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString)); //A fancy line that converts user string to an int (Found on google)
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void RunActivity()
    {
        Console.Clear();
        ShowDetails();
        AskDuration();
        GetReady();
    }

    //Prepares user for the start of activity
    public void StartingMessage()
    {
        Console.Clear();
        Console.Write("Loading Activity");
        ShowAnimation(5); //Shows animation to start activity and that the program is still working
    }
    //Lets user know the activity is finishing up
    public void EndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done!");
        Console.WriteLine($"You have finished {_duration} seconds of the {_name}!");
        Console.Write("Closing Activity");
        ShowAnimation(3); //Shows animation to finish activity

        
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

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowAnimation(5);
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
        GenerateCountdownTimer(totalSeconds); //Calls to show countdown
    }

    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }
    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        return currentTime;
    }

}