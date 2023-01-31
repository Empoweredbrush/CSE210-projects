using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction (6, 7);

        fraction1.SetTopNumber(3);
        fraction1.SetBottomNumber(4);
        Console.WriteLine(fraction1.GetTopNumber());
        Console.WriteLine(fraction1.GetBottomNumber());

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetFractionDouble());
    }
}