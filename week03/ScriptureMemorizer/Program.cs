using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating the scriptures for
    Scripture scripture1 = CreateScripture("1 Nephi", 3, 7
    "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

    Scripture scripture2 = CreateScripture("Moroni", 10, 4, 5
    "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.\n" +
    "And by the power of the Holy Ghost ye may know the truth of all things.");

    Scripture scripture3 = CreateScripture("Alma", 37, 6, 7
    "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.\n" +
    "And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls.");

    //Randomly choose a scripture
    Random random = new Random();
    Scripture chosenScripture = random.Next(3); //Select and index between 0 and 2

    Scripture chosenScripture

    List<Word> words = new List<Word> {_word1, _word2, _word3};
    Scripture scripture = new Scripture(reference, words);

    scripture.GetDisplayText();

    Console.WriteLine("This program should run without error.");
    }
}