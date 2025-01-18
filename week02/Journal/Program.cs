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

            
         }
        } 
    }
}  
   