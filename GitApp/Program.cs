// Brett Whitson
// 9/5/17
// a simple number guessing game

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter two numbers to guess between.");
            Console.Write("Starting number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ending number: ");
            y = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int randomNum = rnd.Next(x, y);
            int guessCount = 1;
            
            
            Console.WriteLine("I'm thinking of a number between {0} and {1}. Can you guess it?", x, y);
            Console.WriteLine();

            int userGuess = Convert.ToInt32(Console.ReadLine());

            while(userGuess != randomNum)
            {
                if (userGuess < randomNum)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                    guessCount++;
                }
                else if (userGuess > randomNum)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                    guessCount++;
                }
                
                userGuess = Convert.ToInt32(Console.ReadLine());
            }
            
                Console.WriteLine("That's correct! It only took " + guessCount + " times!");
    
        }
    }
}
