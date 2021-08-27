// The program should be updated to...

// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.

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
            int secretNum = 42;
            //logging line 13 and 14 
            
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Welcome to Guess the Secret Number! Do you want to play?");
                if (i < 4)
                {
                    Console.WriteLine($"Guess #{i}: Pick a number between 1 and 100...");
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