using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizz buzz");
                    Console.Beep(1000, 100);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                    Console.Beep(2000, 100);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    Console.Beep(3000, 100);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }      
        }

    }
}
