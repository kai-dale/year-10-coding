using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pick_a_door
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a door");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("behind door 1 is hhkh");
            
            }
            else if (choice == "2")
            {

                Console.WriteLine("behind door 2 is jfjf");
            }
            else if (choice == "3")
            {
                Console.WriteLine("behind door 3 is rhfrhf");

            }
            else
            {
                Console.WriteLine("ujhhuehguh");
            }

            Console.ReadKey();


        }
    }
}
