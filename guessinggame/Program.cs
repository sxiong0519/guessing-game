// The program should be updated to...

// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2

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
                Console.WriteLine("Pick a number between 1 and 100...");
                //variable "num" is identified as an integer class... therefore must parse int console.readline since readline always comes back as a string
                int num = int.Parse(Console.ReadLine()); 
            //comparing response to the secret number.... If the same answer then yay... if not the same.. wrong... 
                if (num == secretNum) 
                {
                    Console.WriteLine("Y A Y !!! You got it correct!");
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