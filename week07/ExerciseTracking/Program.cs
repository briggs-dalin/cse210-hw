using System;

/* This program will iterate through all the inputs I have for the various exercises 
showing all the lessons we learned this Term with Inheritance and Polymorphism with the
various classes that are being used from the Parent (Exercise) class.*/
class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();

        Running running  = new Running("February 18, 2025", 20, 3.2);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("January 21 2025", 20, 10);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("January 28 2025", 15, 10);
        exerciseList.Add(swimming);

        foreach (Exercise exercise in exerciseList)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}