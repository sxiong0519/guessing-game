using System;


namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to Guess the Secret Number!");
            Console.WriteLine("How difficult would you like this to be? 1-Easy, 2-Medium, 3-Hard, 4-CHEATER!");
            int secretNum = new Random().Next(1,101);
            int difficultyLevel = int.Parse(Console.ReadLine()); 
        
            if (difficultyLevel == 4)
            {
                while (true) 
                {
                    Console.WriteLine("YOU GET UNLIMITED GUESSES!!!! Go for it!");
                   
                    int num = int.Parse(Console.ReadLine()); 

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
                int[] guesses = new int[] {8, 6, 4}; 
 
                for (int i = guesses[(difficultyLevel - 1)]; i > 0; i--)
                {
                    if (i > 1)
                    {
                        Console.WriteLine($"You have {i} guesses... Guess!");
                    } 
                    else 
                    {
                        Console.WriteLine($"Final Guess...");
                    }
                   
                    int num = int.Parse(Console.ReadLine()); 
                
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
                Console.WriteLine($"You're out of guesses! :( The answer is {secretNum}!");     
            }
        }
    }
}

