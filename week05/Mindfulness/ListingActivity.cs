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
        "Who are some of your personal heroes?"
    };
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things you have in life. Set a timer and list as many as you can in that time limit.");
    }

    public void GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);//Select random prompt
        Console.WriteLine("Your prompt is:");
        Console.WriteLine(_prompts[index]);//Display prompt
    }

    public void PromptListing()
    {

    }

}
