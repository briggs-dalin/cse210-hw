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

    public string GetDisplayText()
    {
        return string.Empty;
    }
}