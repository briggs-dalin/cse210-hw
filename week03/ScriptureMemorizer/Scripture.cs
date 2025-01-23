using System;
using System.Collections.Generic;

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
    public bool HideRandomWord()
    {
        Random random = new Random();
        int hiddenCount = 0;

    //Hide random words until limit is reached
        while(hiddenCount < 1 && hiddenCount < _words.Count)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if(!word.IsHidden())
            {
                word.Hide();
                hiddenCount++; //increase hidden word count
                return true;
            }
        }
        return false; //All words are hidden (No more words to hide)
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

}


    


    
    