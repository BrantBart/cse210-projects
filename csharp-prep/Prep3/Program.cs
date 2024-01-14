using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        // 1-10
        int randomNumber = random.Next(1, 111);
        int guess = 0;

        while (guess != randomNumber)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > randomNumber)
            {
                Console.WriteLine("Lower");

            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.Write($"You got it! The number was {randomNumber}!");
    }
}