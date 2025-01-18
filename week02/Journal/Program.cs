/* This program will prompt the user with 5 different options.
To write an entry. The user will then be able to save to a file
and load it for later use.*/
using System;

class Program
{
    static void Main(string[] args)
    {
     Journal journal = new Journal();
     PromptGenerator promptGenerator = new PromptGenerator();

     while(true)
     {
        //show menu
        Console.WriteLine("\nMenu");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Exit");
        Console.WriteLine("Choose an option (1-5): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
            //Write new entry
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");
            Console.WriteLine("Your response: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Entry newEntry = new Entry(date, prompt, response);
            journal.AddEntry(newEntry);
            Console.WriteLine("Entry added sucessfully!");
            break;

            case "2":
            //display all entries
            journal.DisplayAll();
            break;

            case "3":
            //Save journal to file
            Console.WriteLine("Enter File name here for saving: ");
            string saveFileName = Console.ReadLine();
            journal.SaveToFile(saveFileName);
            break;

            case "4":
            //Load journal from file
            Console.WriteLine("Enter filename to load from: ");
            string loadFileName = Console.ReadLine();
            journal.LoadFromFile(loadFileName);
            break;

            case "5":
            //Exit
            Console.WriteLine("Goodbye!");
            return;

            default:
            Console.WriteLine("Invalid choice, please try again");
            break;
         }
        } 
    }
}  
   