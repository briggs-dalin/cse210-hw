using System;

/* This program will prompt the user for creating goals and adding them to a file that the user chooses
The user will determine the complexity of the goal and how many points will be assigned to said goal.
The program will then keep that saved and the user can come back and finish any goals they do. They will get the associated points
I made sure the program works as explained above. Enjoy!*/
class Program
{
    static void Main(string[] args)
    {
        string menuSelected = "";

        GoalManager goals = new GoalManager();

    while(menuSelected != "6")
        {
            int points = goals.GetAccumulatedPoints();

            Console.WriteLine($"You have {points} points!");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Exit");
            Console.WriteLine("Select a choice from the menu: ");

            menuSelected = Console.ReadLine();

            switch (menuSelected)
            {
                case "1":

                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Which Goal would you like to make?");

                string goalType = Console.ReadLine();

                switch (goalType)
                {
                    case "1":
                    SimpleGoal newSimpleGoal = new SimpleGoal();
                    newSimpleGoal.CreateChildGoal();
                    goals.AddGoals(newSimpleGoal);
                    break;

                    case "2":
                    EternalGoal newEternalGoal = new EternalGoal();
                    newEternalGoal.CreateChildGoal();
                    goals.AddGoals(newEternalGoal);
                    break;

                    case "3":
                    ChecklistGoal newChecklistGoal = new ChecklistGoal();
                    newChecklistGoal.CreateChildGoal();
                    goals.AddGoals(newChecklistGoal);
                    break;

                    default:
                    Console.WriteLine("Invalid goal type. Please try again.");
                    break;
                }
                break;
            case "2":
                goals.ListGoals();
                break;

            case "3":
                goals.SaveGoals();
                break;
            case "4":
                goals.LoadGoals();
                break;
            case "5":
                goals.RecordEvent();
                break;
            case "6":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Please select a valid number from the menu.");
                break;

            }
        }

    }
}