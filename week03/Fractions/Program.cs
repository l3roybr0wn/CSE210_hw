using System;

internal class Program
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        // Constructors
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
            _denominator = denominator != 0 ? denominator : throw new ArgumentException("Denominator cannot be zero.");
        }

        // Getters
        public int GetNumerator()
        {
            return _numerator;
        }

        public int GetDenominator()
        {
            return _denominator;
        }

        // Setters
        public void SetNumerator(int value)
        {
            _numerator = value;
        }

        public void SetDenominator(int value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _denominator = value;
        }

        // Representations
        public string GetFractionString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public double GetDecimalValue()
        {
            return (double)_numerator / _denominator;
        }
        private class Program
        {
            private static void Main(string[] args)
            {
                // Test all constructors
                Fraction f1 = new Fraction();           // 1/1
                Fraction f2 = new Fraction(6);          // 6/1
                Fraction f3 = new Fraction(6, 7);       // 6/7

                Console.WriteLine("Constructor Tests:");
                Console.WriteLine($"f1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");
                Console.WriteLine($"f2: {f2.GetFractionString()} = {f2.GetDecimalValue()}");
                Console.WriteLine($"f3: {f3.GetFractionString()} = {f3.GetDecimalValue()}");

                // Test setters and getters
                f1.SetNumerator(3);
                f1.SetDenominator(4);
                Console.WriteLine("\nAfter setting f1 to 3/4:");
                Console.WriteLine($"f1: {f1.GetFractionString()} = {f1.GetDecimalValue()}");

                int numerator = f1.GetNumerator();
                int denominator = f1.GetDenominator();
                Console.WriteLine($"Numerator: {numerator}, Denominator: {denominator}");
            }
        }
    }
}
