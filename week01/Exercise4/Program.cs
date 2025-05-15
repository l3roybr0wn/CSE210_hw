using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenge
            int smallestPositive = numbers.Where(n => n > 0).OrderBy(n => n).FirstOrDefault();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            numbers.Sort();
            Console.WriteLine($"The sorted list is: {string.Join(", ", numbers)}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}