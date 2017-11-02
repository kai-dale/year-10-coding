using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userscore = 0;
            int computerscore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "draw";
                printscore(ref userscore, ref computerscore);
                string userchoice = userturn();
                string computerchoice = computerturn();
                result = determinewinner(userchoice, computerchoice);
                givefeedback(result, userchoice, computerchoice);
                updatescores(result, ref userscore, ref computerscore);
                repeat = playagain();
            }
        }

        private static void printscore(ref int userscore, ref int computerscore)
        {
            Console.Clear();
            Console.WriteLine("user: " + userscore + "  computer: " + computerscore);

        }

        private static bool playagain()
        {
            Console.WriteLine("do you want to play again? y/n");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y" || choice == "yes")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private static void updatescores(string result, ref int userscore, ref int computerscore)
        {
            
        }

        private static void givefeedback(string result, string userchoice, string computerchoice)
        {
            Console.WriteLine($"win! you chose rock and the computer chose scissors!");
        }

        private static string determinewinner(string userchoice, string computerchoice)
        {
            if (userchoice == "rock")
            {
                if (computerchoice == "rock")
                {
                    return "draw";
                }
                else if (userchoice == "paper")
                {
                    return "win";
                }
                else
                {
                    return "win";
                }
            }
            else if (computerchoice == "paper")
            {
                if (computerchoice == "rock")
                {
                    return "win";
                }
                else if (userchoice == "paper")
                {
                    return "draw";
                }
                else
                {
                    return "lose";
                }
            }
            else
            {
                if (computerchoice == "rock")
                {
                    return "lose";
                }
                else if (userchoice == "paper")
                {
                    return "win";
                }
                else
                {
                    return "draw";
                }
            }
        }

        private static string computerturn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 4);

            if (choice == 1)
            {
                return "rock";
            }
            else if (choice == 2)
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }

        }

        private static string userturn()
        {
            Console.WriteLine("1. rock");
            Console.WriteLine("2. paper");
            Console.WriteLine("3. scissors");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                return "rock";
            }
            else if (choice == 2)
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }
        }
    }
}
