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
        SetDescription("This activity will help you reflect on the good things you have in life. Set a timer and list as many as you can in that time limit.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);//Select random prompt
        Console.WriteLine("Your prompt is:");
        return _prompts[index];//Display prompt
    }

    public void PromptListing()
    {
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{prompt}---");
        
        //Prompt user to press any key when ready to begin
        Console.WriteLine("When you are ready, press any key to start.");
        Console.ReadKey();//Waits for user to press a key

        Console.WriteLine("\nYou may begin in:");
        GenerateCountdownTimer(5);
        Console.WriteLine();//Adding space to look nicer


        
    }

}
