using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        //Math Assignment Object
        MathAssignment a2 = new MathAssignment("\nRoberto Rodriguez", "Fractions", "7.3", "8-19\n");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        //Writing Assignment Object
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());



    }
}