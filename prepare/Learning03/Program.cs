using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // test of the formatted print multiple seperation characters
        // not quite the same as the python but close, if could use newer C# it would be closer
            //will try using a class next time or for the final
            // hav an above sentance, below sentance, and a few presets
        int num_repeats = 25;
        string what_to_repeat = "-";
        string repeatedChar = new string(what_to_repeat[0], num_repeats);
        // insert the repeating character var
        Console.WriteLine($"\n{repeatedChar}\nHello Learning03 World!\n{repeatedChar}\n");

        // test constructors for step 4.2
        Fraction f1 = new Fraction();       // 1/1
        Fraction f2 = new Fraction(6);      // 6/1
        Fraction f3 = new Fraction(6, 7);   // 6/7

        // Test print
        Fraction[] fractions = { new Fraction(), new Fraction(5), new Fraction(3, 4), new Fraction(1, 3) };

        foreach (var fraction in fractions)
        {
            Console.WriteLine(fraction.GetFractionString());
            Console.WriteLine(fraction.GetDecimalValue());
        }

    }
}