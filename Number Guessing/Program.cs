// See https://aka.ms/new-console-template for more information
using System;
namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int win = random.Next(1, 101);
            bool isCorrectGuess = false;

            Console.WriteLine("Welcome to Number Guess Game");
            Console.WriteLine("Enter any number between 1 to 100");
            int numberofattempts =0;



            while (!isCorrectGuess)
            {
                Console.WriteLine("enter your guess");
                string input = Console.ReadLine();
                int guessedNumber;
                if (int.TryParse(input, out guessedNumber))
                {
                    numberofattempts++;
                    if (numberofattempts >2)
                    {
                        Console.WriteLine("You lost the game");
                        Console.WriteLine($"correct number is {win}");
                        break;
                    }
                    if (guessedNumber < win)
                    {
                        Console.WriteLine("you have entered lesser value");
                    }
                    else if (guessedNumber > win)
                    {
                        Console.WriteLine("You have entered greater value");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations!! you have entered correct number");
                        isCorrectGuess = true;
                    }

                }
                else
                {
                    Console.WriteLine("Enter valid  number");
                }
            }
                
                
            
            



        }
    }
}
