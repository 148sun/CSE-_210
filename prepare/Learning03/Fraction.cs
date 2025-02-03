using System.Runtime.CompilerServices;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }
    
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void GetNumerator()
    {
        Console.WriteLine(_numerator);
    }
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }
    public void GetDenominator()
    {
        Console.WriteLine(_denominator);
    }
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetStringValue()
    {
        string numerator = _numerator.ToString();
        string denominator = _denominator.ToString();
        return $"{numerator}/{denominator}";

    }
    public double GetDecimalValue()
    {
        return (double)_numerator/ (double)_denominator;
    }




}