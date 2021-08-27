// The program should be updated to...

// Prompt the user for a difficulty level before they are prompted to guess the number.
// The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
// Easy - this gives the user eight guesses.
// Medium - this gives the user six guesses.
// Hard - this gives the user four guesses.

using System;

//name of the "space" where data is being created... "dotnet new console -o projname"
//will most likely use this during times when needing to pull class/methods
namespace guessinggame
{
    //normally the same as the .cs file.
    class Program
    {
        static void Main(string[] args)
        {   
            int secretNum = new Random().Next(1,101);
            Console.WriteLine("How difficult would you like this to be? 1-Easy, 2-Medium, 3-Hard");
            int difficultyLevel = int.Parse(Console.ReadLine()); 

            int[] guesses = new int[] {10, 5, 3}; 

            for (int i = guesses[(difficultyLevel - 1)]; i > 0; i--)
            {
                Console.WriteLine("Welcome to Guess the Secret Number!");
                if (i > 1)
                {
                    Console.WriteLine($"You have {i} guesses... Guess!");
                } else 
                {
                    Console.WriteLine($"Final Guess...");
                }
                //variable "num" is identified as an integer class... therefore must parse int console.readline since readline always comes back as a string
                int num = int.Parse(Console.ReadLine()); 
            //comparing response to the secret number.... If the same answer then yay... if not the same.. wrong... 
                if (num == secretNum) 
                {
                    Console.WriteLine("Y A Y !!! You got it correct!");
                    break;
                } 
                else if (num > secretNum)
                {
                    Console.WriteLine("Too High!!");
                }
                else 
                {
                    Console.WriteLine("Too Low!!");
                }
            }        
        }

    }
}

//dotnet run