using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        {
            bool playAgain = true;

            while (playAgain)
            {
                // 1. Generate a random number
                Random random = new Random();
                int magicNumber = random.Next(1, 101); // Generates a number between 1 and 100
                int guess;
                int guessCount = 0;

                // 2. Start the game loop
                Console.WriteLine("Welcome to Guess My Number!");

                do
                {
                    // 3. Ask for a guess
                    Console.Write("What is your guess? ");
                    string? input = Console.ReadLine();

                    // Validate input
                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue; // Skip the rest of the loop and ask for input again
                    }

                    guessCount++;

                    // 4. Determine if the user needs to guess higher or lower
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! The magic number was {magicNumber}");
                        Console.WriteLine($"It took you {guessCount} guesses.");
                        break; // Exit the loop when the guess is correct
                    }

                } while (guess != magicNumber);

                // 5. Ask to play again
                Console.Write("Do you want to play again? (yes/no): ");
                string? playAgainInput = Console.ReadLine()?.ToLower();
                playAgain = playAgainInput == "yes";
            }

            Console.WriteLine("Thanks for playing!");
        }
    }

}