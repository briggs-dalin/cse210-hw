using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        Console.WriteLine("This is a test of my Animation.");
        activity.ShowAnimation(5);
        Console.WriteLine("\nAnimation complete!");
    }
}