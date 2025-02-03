using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3,7);
        
        // Console.WriteLine(fraction1.GetFractionString());
        // Console.WriteLine(fraction2.GetFractionString());
        // Console.WriteLine(fraction3.GetFractionString());
        // fraction1.GetDenominator();
        // fraction1.GetNumerator();
        // fraction1.SetDenominator(5);
        // fraction1.SetNumerator(7);
        // fraction1.GetDenominator();
        // fraction1.GetNumerator();
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetStringValue());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetStringValue());
        fraction3.SetDenominator(4);
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetStringValue());
        fraction1.SetDenominator(3);
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetStringValue());







        
    }
}