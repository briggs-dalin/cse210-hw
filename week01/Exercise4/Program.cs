using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int userNumber = -1;

        while(userNumber != 0){
             Console.Write("Enter your numbers. (enter 0 to stop):  ");
        while(true)
        {
            userNumber = int.Parse(Console.ReadLine());

            if(userNumber == 0)
            {
                break;
            }
            numbers.Add(userNumber);
        }

        if(numbers.Count == 0) // in case 0 is written at the very start.
        {
        Console.WriteLine("No numbers were entered.");
        return;
        }
        }


       
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
    }
}