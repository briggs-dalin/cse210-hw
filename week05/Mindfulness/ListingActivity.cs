using System;
using System.Diagnostics;

public class ListingActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "How has someone helped you in the past month?",
        "What qualities do you admire in yourself?"
    };

    
    
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things you have in life. Set a timer and list \nas many as you can in that time limit.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);//Select random prompt
        Console.WriteLine("\nYour prompt is:");
        return _prompts[index];//Display prompt
    }

    public void PromptListing()
    {

        
        string prompt = GeneratePrompt();
        Console.WriteLine($"---{prompt}---");
        
        //Prompt user to press any key when ready to begin
        Console.WriteLine("\nWhen you are ready, press any key to start.");
        Console.ReadKey(true);//Waits for user to press a key

        Console.WriteLine("\nYou may begin in:");
        GenerateCountdownTimer(5);
        Console.WriteLine();//Adding space to look nicer

        
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();


        //Initalize counter to track number of responses
        int responseCount = 0;
        //loop through while the timer is still going
        while(currentTime <= futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            responseCount++;
            currentTime = DateTime.Now;
        }
        
        Console.WriteLine($"You Provided {responseCount} responses.");
        
    }
    

}
