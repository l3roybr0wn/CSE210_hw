using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        // Testing Assignment
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        // Testing MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Testing WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Alice Johnson", "Essay", "The Great Gatsby");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
