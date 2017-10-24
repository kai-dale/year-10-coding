using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessmynumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 101);
            Console.WriteLine("Welcome to my Guessing Game.");
            Console.WriteLine("Please guess a number between 1 and 100.\n");

            int guess = -1;
            int count = 0;
            while(guess != rand)

            while(guess != rand)
            {
                count++;
                Console.Write("guess: ");
                guess = int.Parse(Console.ReadLine());
                if (guess < rand)
                {
                        if(guess < 1)
                        {
                            Console.WriteLine("Out of range!");
                        }
                        else
                        {
                            Console.WriteLine("too low!");
                        }
                    
                }
                else if (guess > rand)
                {
                        if(guess > 100)
                        {
                            Console.WriteLine("out of range!");
                        }
                    Console.WriteLine("too high!");
                }
                else
                {
                    Console.WriteLine($"you got it, it took {count} tries!");
                    Console.ReadKey();
                }
         
            }
        }
    }
}
