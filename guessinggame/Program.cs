using System;

//name of the "space" where data is being created... "dotnet new console -o projname"
//will most likely use this during times when needing to pull class/methods
namespace guessinggame
{
    //normally the same as the .cs file.
    class Program
    {
        public static void Main(string[] args)
        {   
            //logging line 13 and 14 
            Console.WriteLine("Welcome to Guess the Secret Number! Do you want to play?");
            Console.WriteLine("Pick a number between 1 and 100...");
            //string is the class... num is the variable... console.readline is code for waiting for response of the user.. once user provides a response it will then be logged into "num" the variable
            string num = Console.ReadLine();
            //pulling the response number for use in {}...
            Console.WriteLine($"You answered {num}.... Let's see if you're correct.");
            //string secret instead of "int" because you can't compare a string to an integer in the if statement...
            string secret = "42";
            //comparing response to the secret number.... If the same answer then yay... if not the same.. wrong... 
            if (num == secret) 
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

//dotnet run