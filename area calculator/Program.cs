using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string CHOICE = "";
            while (CHOICE != "4")
            {
                Console.Clear();
                Console.WriteLine("choose an option:");
                Console.WriteLine("1. area of rectangle");
                Console.WriteLine("2. area of triangle");
                Console.WriteLine("3. area of circle");
                Console.WriteLine("4. exit");
                CHOICE = Console.ReadLine();

                if (CHOICE == "1")
                {
                    // area of rectangle
                    Console.WriteLine();
                    Console.WriteLine("width: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("length: ");
                    float length = float.Parse(Console.ReadLine());
                    Console.WriteLine("area: " + (width * length));
                }
                else if(CHOICE == "2")
                {
                    // area of triangle
                    Console.WriteLine();
                    Console.WriteLine("base: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("height: ");
                    float height = float.Parse(Console.ReadLine());
                    Console.WriteLine("area: " + (0.5 * width * height));
                }
                else if (CHOICE == "3")
                {
                    // area of circle
                    Console.WriteLine();
                    Console.Write("radius: ");
                    float radius = float.Parse(Console.ReadLine());
                    Console.WriteLine("area: " + (Math.PI * radius * radius));
                }

                //wait
                Console.WriteLine();
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();



            }


        }
        
    }
}
