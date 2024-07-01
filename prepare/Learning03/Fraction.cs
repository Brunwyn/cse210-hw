using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;


    // The constructor with no parameters
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }


    // The constructor with one parameter for the numerator
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }


    // The onstructor with two parameters
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }


    // Gett and sett for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Gett and sett for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Method to return fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}