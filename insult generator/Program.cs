using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insult_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // ask for your name
            string name = getname();

            // generate a random insult 
            Generateinsult(name, rnd);
        }
        private static string getname()        
        {
            Console.WriteLine("welcome to the insult generator. what is your name?");
            return Console.ReadLine();
        }
        private static void Generateinsult(string name, Random rnd)
        {
            Console.WriteLine(name + ", you are " + getadjective(rnd) + getcompoundadjective(rnd) + getobject(rnd));
            menu(name, rnd);
        }
        private static void menu(string name, Random rnd)
        {
            Console.WriteLine("would you like another insult? y/n ");
            if (Console.ReadLine() == "y")

                Generateinsult(name, rnd);
        }

        private static string getadjective(Random rnd)
        {
            string[] adjectives = { "a noisy", "a obnoxious", "a arrogant", "a troll", "a funky", "a loud", "a imbred", "a hairy" };
            return adjectives[rnd.Next(8)];
        }

        private static string getcompoundadjective(Random rnd)
        {
            string[] compoundadjectives = { "no-good", "self-loving", "pompus-f**k", "teachers-pet", "uneducated-idiot", "guinea-pig", "cold-hearted", "big-headed" };
            return compoundadjectives[rnd.Next(8)];
        }

        private static string getobject(Random rnd)
        {
            string[] adjectives = { "monkey", "crabbbbbbbbbb", "chilld", "tree", "cow", "computer", "table", "chair" };
            return adjectives[rnd.Next(11)];
        }
        
    }
}
