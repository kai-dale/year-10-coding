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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
                else if (userchoice == "scissors")
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
                else if (userchoice == "scissors")
                {
                    return "lose";
                }
            }
            else if (computerchoice == "scissors")
        }
        if (computerchoice == "rock")
                {
                    return "lose";
                }
                else if (userchoice == "paper")
                {
                    return "win";
                }
                else if (userchoice == "scissors")
                {
                    return "draw";
                }

        private static string computerturn()
        {
            throw new NotImplementedException();
        }

        private static string userturn()
        {
            throw new NotImplementedException();
        }
    }
}
