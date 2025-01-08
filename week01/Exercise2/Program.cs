using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer); 

        string letter = "";
        string sign = "";

        if(grade >= 90)
        {
            letter = "A";
        }
        else if(grade >= 80)
        {
            letter = "B";
        }
        else if(grade >= 70)
        {
            letter = "C";
        }
        else if(grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

         int last_digit = grade % 10;

         if(grade < 97 && letter != "F")
         {
            if(last_digit >= 7)
            {
                sign = "+";
            }
            else if(last_digit < 3)
            {
                sign = "-";
            }
         }


        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if(grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}