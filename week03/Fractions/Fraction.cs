using System;

public class Fraction
{
    private int numerator;
    private int denominator;


    //Constructor with no parameters
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    //Constructor with one parameter
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    //Constructor with two parameters
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    //Getter for Numerator
    public int GetNumerator()
    {
        return numerator;
    }

    //Setter for Numerator
    public void SetNumerator(int value)
    {
        numerator = value;
    }

    //Getter for Denominator
    public int GetDenominator()
    {
        return denominator;
    }

    //Setter for Denominator
    public void SetDenominator(int value)
    {
        denominator = value;
    }
}