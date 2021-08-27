// The program should be updated to...

// Inform the user if their guess was too high or too low, when they guess incorrectly.

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
            Console.WriteLine(secretNum);
            
            for (int i = 4; i > 0; i--)
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