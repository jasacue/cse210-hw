using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Random randomGenerator = new Random();
        int numbre = randomGenerator.Next(1, 101);
        while (guess != numbre)
        {
            Console.WriteLine("Guess: ");
            guess = int.Parse(Console.ReadLine());

            if (numbre > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (numbre < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Good Job");
            }
        }
    }
}