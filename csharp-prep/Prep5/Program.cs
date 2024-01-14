using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        double userNumber = PromptUserNumber();

        double squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static double PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        double number = double.Parse(Console.ReadLine());

        return number;
    }

    static double SquareNumber(double favoriteNumber)
    {
        double square = Math.Pow(favoriteNumber, 2);
        return square;
    }

    static void DisplayResult(string name, double squareOfNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareOfNumber}");
    }
}