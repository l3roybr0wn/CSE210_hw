using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percent grade? ");
        string answer = Console.ReadLine();
        int percentGrade = int.Parse(answer);

        string letterGrade = "";
        {

            if (percentGrade >= 90)
            {
                letterGrade = "A";
            }

            else if (percentGrade >= 80)
            {
                letterGrade = "B";
            }

            else if (percentGrade >= 70)
            {
                letterGrade = "c";
            }

            else if (percentGrade >= 60)
            {
                letterGrade = "D";
            }


            else
            {
                letterGrade = "F";
            }

            Console.Write($"Your grade is a {letterGrade} ");
        }
    }
}