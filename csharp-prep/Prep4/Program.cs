using System;

class Program
{
    static void Main(string[] args)
    {
        //   The sum is: 131
        //   The average is: 18.714285714285715
        //   The largest number is: 48
        List<int> numbers = new List<int>();
        int numberEntered = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numberEntered != 0)
        {
            Console.Write("Enter number: ");
            numberEntered = int.Parse(Console.ReadLine());
            if (numberEntered != 0)
            {
                numbers.Add(numberEntered);
            }
        }
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}