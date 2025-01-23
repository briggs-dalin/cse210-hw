using System;

public class Reference{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

//Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = verse;
        this._endVerse = verse;
    }

//Constructor for range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }
// Method to get the formatted display text of the reference
    public string GetDisplayText()
    {
        if (_startVerse != _endVerse)
        {
            // range for multiple verses
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            //range for single verse
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }

//My getters for encapsulation
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }
    
    }