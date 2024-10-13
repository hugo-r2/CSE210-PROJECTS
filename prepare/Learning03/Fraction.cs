using System;
public class Fraction
{
    private float _top;
    private float _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string stringFraction = $"{_top}/{_bottom}";
        return stringFraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}