using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess the Secret Number! Do you want to play?");
            Console.WriteLine("Pick a number between 1 and 100...");

            string num = Console.ReadLine();

            Console.WriteLine($"You answered {num}.... Let's see if you're correct.");
        }
    }
}