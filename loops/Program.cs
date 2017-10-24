using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            Console.ReadLine();

            int number = 1;

            while(number <= 10)
       
            {
                Console.WriteLine(number);
                number++;
            }

            Console.ReadKey();
        
        }
    }
}
