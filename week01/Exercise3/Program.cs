using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

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