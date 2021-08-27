// The program should be updated to...

// Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.

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
            
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine("Welcome to Guess the Secret Number! Do you want to play?");
                if (i > 1)
                {
                    Console.WriteLine($"You have {i} guesses left... Guess!");
                } else 
                {
                    Console.WriteLine($"Final Guess: Pick a number between 1 and 100...");
                }
                //variable "num" is identified as an integer class... therefore must parse int console.readline since readline always comes back as a string
                int num = int.Parse(Console.ReadLine()); 
            //comparing response to the secret number.... If the same answer then yay... if not the same.. wrong... 
                if (num == secretNum) 
                {
                    Console.WriteLine("Y A Y !!! You got it correct!");
                    break;
                } 
                else 
                {
                    Console.WriteLine("Wrong. Do better.");
                }
            }        
        }

    }
}

//dotnet run