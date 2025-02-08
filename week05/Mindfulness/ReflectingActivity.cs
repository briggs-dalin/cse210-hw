using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
        //List of prompts
    private List<string> _prompts = new List<string> 
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of a moment when you confronted and addressed an injustice or unfairness.",
    "Think of an experience where you demonstrated exceptional empathy towards someone in distress.",
    "Think of a memory when you generously shared your knowledge or expertise to benefit others.",

    };
        //List of questions
    private List<string> _questions = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel upon completing the task?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What self-discoveries did you make through this encounter?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    "What were the initial steps you took to initiate this process?",
    };
    
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you think back on a time that you have shown strength and perseverence. This will help show you how amazing of a person you are!");
            
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);//Select random Prompt
        return _prompts[index]; //Display prompt
    }

    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);//Select random question
        return _questions[index];//Display question
    }

    public void PromptReflecting()
    {
            string prompt = GeneratePrompt();
            Console.WriteLine();
            Console.WriteLine("Consider this prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine();
            Console.WriteLine("When you are ready, press any key to continue.");
            Console.ReadKey(true);
            Console.Clear();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        //loop through while the timer is still going
        while(currentTime <= futureTime)
        {
            string question = GenerateQuestion();
            Console.Write(question + " ");
            ShowAnimation(10);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}
