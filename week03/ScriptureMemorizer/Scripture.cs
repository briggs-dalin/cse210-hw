using System;


class Scripture 
{

    private Reference _reference;
    private List<Word> _words;
    
    
    //Constructor
    public Scripture(Reference reference, List<Word> words)
    {
        this._reference = reference;
        this._words = words;

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while(hiddenCount < numberToHide && hiddenCount < _words.Count)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if(!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText()+ " ";

        foreach (var word in _words)
        {
            result += word.IsHidden() ? "___" : word.GetText() + " ";

        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            return false; //if any words not hidden, return false
        }
        return true; //All words are hidden 
    }

}
    


    
    