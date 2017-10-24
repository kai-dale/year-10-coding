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
                    Console.WriteLine("too low!");
                }
                else if (guess > rand)
                {
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
