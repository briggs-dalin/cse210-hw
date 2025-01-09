using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int userNumber = -1;

        while(userNumber != 0)
        {
             Console.Write("Enter your numbers. (enter 0 to stop):  ");
        
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        

        if(numbers.Count == 0) // in case 0 is written at the very start.
        {
            Console.WriteLine("No numbers were entered. Have a nice day!");
            return;
        }
    


       //Adding the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is {sum}.");

        //Computing average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is {average}");

        //Getting max
        int max = numbers[0];

        foreach(int number in numbers)
        {
            if(number > max)
            {
                // going through list and finding a higher number will then make that the max
                max = number; 
            }
        }
        Console.WriteLine($"The highest number is {max}.");
    }
}