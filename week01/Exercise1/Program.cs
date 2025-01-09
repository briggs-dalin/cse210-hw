/* Program description
Prompts the user for their first name. 
Then, prompts for their last name. 
Displays the text back to user on one line.*/

using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}");
        
    }
}