using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            while (true)
            {
                int randNum = random.Next(1, 101);
                int guessedNum = 0;
                int numGuesses = 0;
                Console.WriteLine("Guess a number between 1-100");
                while (guessedNum != randNum)
                {
                    Console.Write("Type your guess: ");
                    if (int.TryParse(Console.ReadLine(), out guessedNum))
                    {
                        numGuesses += 1;
                        if (guessedNum > randNum)
                            Console.WriteLine("Your guess is too high");
                        else if (guessedNum < randNum)
                            Console.WriteLine("Your guess is too low");
                    }
                    else
                    {
                        Console.WriteLine("Not a number, try again");
                    }
                }

                Console.WriteLine($"{randNum} was the correct number. You guessed it correctly in {numGuesses} tries");
            }
        }
    }
}
