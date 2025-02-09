using System;

//My program has a menu for the different activities you can do!
//I added a log to show how many times you have done a certain activity. 
//The responses don't save. But they are fun to do!
//I exceeded by having 2 of the activities prompt to user to press any key before moving on

class Program
{
    static void Main(string[] args)
    {
       string input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current Session");
            Console.WriteLine($"Breathing Activity: {breathingLog}");
            Console.WriteLine($"Reflecting Activity: {reflectingLog}");
            Console.WriteLine($"Listing Activity: {listingLog}");
            Console.WriteLine();
        }

        //Loop for the whole menu.
        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunActivity();
                breathingActivity.PreformBreathingActivity();
                breathingActivity.EndingMessage();

                breathingLog++;
                break;

                case "2":
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.RunActivity();
                reflectingActivity.PromptReflecting();
                reflectingActivity.EndingMessage();

                reflectingLog++;
                break;

                case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunActivity();
                listingActivity.PromptListing();
                listingActivity.EndingMessage();

                listingLog++;
                break;

                case "4":
                Environment.Exit(0);
                break;

                default:
                Console.WriteLine("Please enter the number of the menu option. ");
                break;
            }
        }
        Environment.Exit(0);


       
    }
}