using System;
using System.Collections.Generic;

/* In my program for exceeding requirements, I did my best to 
have my program grab a random scripture from the 3 I made and
have it run accordingly to the projects requirements. */
class Program
{
    static void Main(string[] args)
    {
        //Creating the scriptures for
    var scripture1 = CreateScripture("1 Nephi", 3, 7,
    "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

    var scripture2 = CreateScripture("Moroni", 10, 4, 5,
    "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\n" +
    "And by the power of the Holy Ghost ye may know the truth of all things.");

    var scripture3 = CreateScripture("Alma", 37, 6, 7,
    "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.\n" +
    "And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls.");


    //Store scriptures in a list
    List<Scripture> scriptures = new List<Scripture> {scripture1, scripture2, scripture3};

    //Randomly choose a scripture
    Random random = new Random();
    Scripture selectedScripture = scriptures[random.Next(scriptures.Count)]; //Select and index between 0 and 2

    //Keep prompting the user until all words are hidden or 'quit' is typed
    while (!selectedScripture.IsCompletelyHidden())
    {
        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText()); //Display current scripture

        Console.WriteLine("\nPress Enter to continue hiding words or type 'quit' to exit.");
        string input = Console.ReadLine();
        

        if (input.ToLower() == "quit")
        {
            break; //End program if user types 'quit'
        }
        //Hide 3 random words
        selectedScripture.HideRandomWords(3);//always attempt to hide 3 words
    
        //Hide 3 random words
        if (selectedScripture.IsCompletelyHidden())
        {
            //If all words are hidden
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText()); //Show the final hidden scripture
            break; //End the program.
        }
    }

    
    Console.WriteLine("\nThank you for using this Scripture Memorizer program!");
    Console.WriteLine("This program has ended.");
    }

    //Helper method to create a scripture with reference and text
    static Scripture CreateScripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        var reference = new Reference(book, chapter, startVerse, endVerse);
        var words = Scripture.CreateWordsFromText(text);
        return new Scripture(reference, words);
    }

    //Helper method to create a scripture reference and single verse
    static Scripture CreateScripture(string book, int chapter, int verse, string text)
    {
        var reference = new Reference(book, chapter, verse);
        var words = Scripture.CreateWordsFromText(text);
        return new Scripture(reference, words);
    }
}