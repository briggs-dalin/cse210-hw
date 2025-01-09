/* Program Description 
Code will pick a random number between 1 and 100.
Will then prompt the user to guess said number.
Code will stop when number is guessed, 
but will add hints of higher or lower if wrong number is guessed*/

using System;


class Program
{
    static void Main(string[] args)
    {
       

        Random random = new Random();


        int targetNumber = random.Next(1,101); //Number randomly chosen from 1 to 100
        int userGuesses = 0;

        Console.WriteLine("I have chosen a number randomly from 1 to 100. Try and find it!");

        while (userGuesses != targetNumber)
        {
                Console.Write("Enter a number: ");

                if (int.TryParse(Console.ReadLine(), out userGuesses))
                {
                    if (userGuesses > targetNumber)
                    {
                        Console.WriteLine("Too high!");
                    }
                    
                    else 
                    {
                    Console.WriteLine("Too low!");
                    }
            }
           
        }

         Console.WriteLine($"You guessed it! Way to be!");
    }
}