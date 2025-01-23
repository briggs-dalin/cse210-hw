using System;

class Program
{
    static void Main(string[] args)
    {
        
    Word _word1 = new Word("And");
    Word _word2 = new Word("It");
    Word _word3 = new Word("Came");

    Reference reference = new Reference("Nephi 1:1");

    List<Word> words = new List<Word> {_word1, _word2, _word3};
    Scripture scripture = new Scripture(reference, words);

    scripture.GetDisplayText();

    Console.WriteLine("This program should run without error.");
    }
}