using System;




public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        this._text = text;
        this._isHidden = false;
    }

    public void Hide()
    {
       _isHidden = true;
    }
    public void Show()
    {
       _isHidden = false;
    }

    public bool IsHidden()
    {
       return _isHidden;
    }

    //Getter for text (No setter to maintain immutability of words)
    public string GetText()
    {
        return _text;
    }

    public string  GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }


}
