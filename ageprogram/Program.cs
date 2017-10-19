using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("you are a child");
            }
            else if (age < 20)
            {
                Console.WriteLine("you are a teenager!");
            }

            else if (age < 50)

            {
                Console.WriteLine("you are an adult");
            }
            else if (age > 49)
            {
                Console.WriteLine("you are elderly");
            }
                Console.ReadKey(); 
            
        

                


             


        


        
            
                
            
            





        }
    }
}
