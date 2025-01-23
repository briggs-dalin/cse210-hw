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
        
    }

    public string GetDisplayText()
    {
        return string.Empty;
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}
    


    
    