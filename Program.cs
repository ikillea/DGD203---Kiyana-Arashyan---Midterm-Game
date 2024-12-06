// DGD203 - Kiyana Arashyan - Midterm Game
// This is a simple console-based interactive game implemented in C#.
// The player answers a series of questions, and the game provides a result based on their answers.

using System;

class GameController
{
    // Field to store the player's name
    private string playerName;

    // Method to start the game
    public void StartGame()
    {
        // Display a welcome message with a cyan color
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to the game! Let's get started.");
        Console.ResetColor();

        // Prompt the player to enter their name
        Console.Write("What is your name? ");
        playerName = Console.ReadLine();

        // If the player does not provide a name, assign a default name
        if (string.IsNullOrWhiteSpace(playerName))
        {
            playerName = "Unknown Adventurer";
        }

        // Greet the player with their name and proceed to the questions
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Hello, {playerName}! Let's play a game of choices.");
        Console.ResetColor();
        AskQuestions();
    }

    // Method to ask the player a series of questions
    private void AskQuestions()
    {
        // Question 1: Ask the player about their favorite type of environment
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nQuestion 1: What is your favorite type of environment?");
        Console.WriteLine("a) Forest\nb) Desert\nc) Ocean");
        Console.ResetColor();
        string q1 = GetValidatedInput(new[] { "a", "b", "c" });

        // Question 2: Varies based on the answer to Question 1
        if (q1 == "a")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nQuestion 2: What would you do in a forest?");
            Console.WriteLine("a) Build a treehouse\nb) Explore trails\nc) Photograph wildlife");
        }
        else if (q1 == "b")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nQuestion 2: How would you handle the heat of the desert?");
            Console.WriteLine("a) Stay hydrated\nb) Find shade\nc) Travel at night");
        }
        else if (q1 == "c")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nQuestion 2: What activity would you enjoy by the ocean?");
            Console.WriteLine("a) Surfing\nb) Relaxing on the beach\nc) Snorkeling");
        }
        Console.ResetColor();
        string q2 = GetValidatedInput(new[] { "a", "b", "c" });

        // Question 3: Ask about the player's preferred type of companion
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nQuestion 3: What's your preferred type of companion?");
        Console.WriteLine("a) Loyal dog\nb) Independent cat\nc) No companion, I prefer solitude");
        Console.ResetColor();
        string q3 = GetValidatedInput(new[] { "a", "b", "c" });

        // Question 4: Ask about how the player spends their free time
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nQuestion 4: How do you spend your free time?");
        Console.WriteLine("a) Reading\nb) Hiking\nc) Watching movies");
        Console.ResetColor();
        string q4 = GetValidatedInput(new[] { "a", "b", "c" });

        // Generate a result based on the answers provided
        GenerateResults(q1, q2, q3, q4);
    }

    // Method to generate and display results based on the player's answers
    private void GenerateResults(string q1, string q2, string q3, string q4)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n\n--- Results ---");
        if (q1 == "a" && q3 == "a")
        {
            Console.WriteLine($"{playerName}, you seem to be someone who loves adventure and values loyalty.");
        }
        else if (q1 == "b" && q2 == "c")
        {
            Console.WriteLine($"{playerName}, you thrive under challenging conditions and think strategically.");
        }
        else if (q1 == "c" && q4 == "b")
        {
            Console.WriteLine($"{playerName}, you enjoy the beauty of nature and active exploration.");
        }
        else
        {
            Console.WriteLine($"{playerName}, you have a unique mix of interests and qualities!");
        }
        Console.ResetColor();

        // Thank the player for playing
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nThank you for playing! Goodbye!");
        Console.ResetColor();
    }

    // Method to validate the player's input and ensure it matches one of the valid options
    private string GetValidatedInput(string[] validOptions)
    {
        string input = Console.ReadLine().ToLower();
        while (Array.IndexOf(validOptions, input) == -1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid choice. Please enter a valid option (a, b, or c):");
            Console.ResetColor();
            input = Console.ReadLine().ToLower();
        }
        return input;
    }

    // Main entry point of the program
    public static void Main(string[] args)
    {
        // Create a GameController object and start the game
        GameController game = new GameController();
        game.StartGame();
    }
}
