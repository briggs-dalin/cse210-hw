using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;


    //Constructor with no parameters
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    //Constructor with one parameter
    public Fraction(int _numerator)
    {
        this._numerator = _numerator;
        _denominator = 1;
    }

    //Constructor with two parameters
    public Fraction(int _numerator, int _denominator)
    {
        this._numerator = _numerator;
        this._denominator = _denominator;
    }

    //Getter for Numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    //Setter for Numerator
    public void SetNumerator(int value)
    {
        _numerator = value;
    }

    //Getter for Denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    //Setter for Denominator
    public void SetDenominator(int value)
    {
        _denominator = value;
    }
    //Method to get Fraction as a string
    public string GetFractionString()
    {
        string fraction =  $"{_numerator}/{_denominator}";
        return fraction;
    }
    //Method to get Decimal as a string
    public double GetDecimalValue()
    {
        return ((double)_numerator / (double)_denominator);
    }
}