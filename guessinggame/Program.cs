// The program should be updated to...

// Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.

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
             Console.WriteLine("Welcome to Guess the Secret Number!");
            //identifying secretnum as a random number between 1-101 (100 exclusive)
            int secretNum = new Random().Next(1,101);
            //prompting question(writeline) and listening(readline) for the difficulty level which gets logged in difficulty level
            Console.WriteLine("How difficult would you like this to be? 1-Easy, 2-Medium, 3-Hard, 4-CHEATER!");
            int difficultyLevel = int.Parse(Console.ReadLine()); 
            //if user picks cheater level... provide unlimited guesses with no for loop. "while" loop given when parameter is true
            if (difficultyLevel == 4)
            {
                while (true) 
                {
                    Console.WriteLine("YOU GET UNLIMITED GUESSES!!!! Go for it!");
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
            else 
            {
                //created #ofguesses array to fit the narrative tasks... 
                int[] guesses = new int[] {8, 6, 4}; 
                //when difficulty level is chosen (1, 2, 3) the number logged in difficulty level then gets subtracted with 1...
                //which in return provides the index# for the guesses array to locate the #of guesses to provide
                for (int i = guesses[(difficultyLevel - 1)]; i > 0; i--)
                {
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
}

//dotnet run