using System;

public class Scripture 
{

    private Reference _reference;
    private List<Word> _words;
    
    
    //Constructor
    public Scripture(Reference reference, List<Word> words)
    {
        this._reference = reference;
        this._words = words;

    }
    //Hide a randum number of words
    public bool HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        //List all the words that are still not hidden
        List<Word> availableWords = _words.FindAll(word => !word.IsHidden());

        //If there are no available words left to hide, then return
        if(availableWords.Count == 0)
            return false;

    //Hide random words until limit is reached
        while(hiddenCount < numberToHide && availableWords.Count > 0)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if(!word.IsHidden())
            {
                word.Hide();
                hiddenCount++; //increase hidden word count
            }

            //Refresh list of available words
            availableWords = _words.FindAll(w => !w.IsHidden());
        }
        return hiddenCount > 0;
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (var word in _words)
        {
            result += word.GetDisplayText() + " ";

        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true; // All words are hidden
    }

    //static helper method to create words from the text of the scripture
    public static List<Word> CreateWordsFromText(string text)
    {
        List<Word> words = new List<Word>();
        string[] wordArray = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?', '-', '(', ')', '\n', '\r' },
        StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in wordArray)
        {
            words.Add(new Word(word)); //Add each word as a Word object
        }

        return words;
    }

}