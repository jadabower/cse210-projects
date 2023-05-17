using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Fraction frac2 = new Fraction(5);

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Fraction frac3 = new Fraction(6, 7);
        
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        frac3.SetNumerator(3);
        frac3.SetDenominator(4);

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
    }
}