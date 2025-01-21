using System;

public class Fraction
{
    // Attributes (variables)
    private int _numerator;
    private int _denomenator;
    // Constructors
    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denomenator = 1;
    }
    public Fraction(int numerator, int denomenator)
    {
        _numerator = numerator;
        _denomenator = denomenator;
    }
    // Getters & Setters
    public string GetFraction()
    {
        string fractionString = $"{_numerator}/{_denomenator}";
        return fractionString;
    }
    public double GetFractionValue()
    {
        return (double)_numerator / (double)_denomenator;
    }
}