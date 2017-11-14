using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babyblackjack
{
    class Program
    {
        private static object dealer;

        static void Main(string[] args)
        {
            float money = 10;
            playgame(ref money);
        }

        private static void playgame(ref float money)
        {
            Console.Clear();
            float betamount = makebet(ref money);
            Random rnd = new Random();
            int playertotal = Dealcards(rnd, "you");
            int dealertotal = Dealcards(rnd, "the dealer");
            bool playerwins = determinewinner(playertotal, dealertotal);
            payout(playerwins, betamount, ref money);
            menu(ref money);

        }

        private static void menu(ref float money)
        {
            Console.WriteLine("would you like to play again? y/n: ");
            if (Console.ReadLine() == "y")
            {
                playgame(ref money);
            }
        }

        private static float makebet(ref float money)
        {
            float betamount = 0;
            bool validbet = false;

            Console.WriteLine("enter your bet. you have $" + money);

           while (validbet != true)
            {
                validbet = float.TryParse(Console.ReadLine(), out betamount);

                if (betamount < 0)
                {
                    Console.WriteLine("sorry, you do not have enough. try again");
                    validbet = false;
                }
                else if (betamount < 0)
                {
                    Console.WriteLine("sorry, you cannot bet a negative amount. try again");
                    validbet = false;
                }
            }

            money = money - betamount;
            return betamount;

                
        }
        private static void payout(bool playerwins, float betamount, ref float money)
        {
            if (playerwins)
        }
        money = money + (betamount * 2);
        {


        private static bool determinewinner(int player, int dealer)
        {
            if (player > dealer)
            {
                Console.WriteLine("you win!");
                return true;
            }
            else if (player < dealer)
            {
                Console.WriteLine("you lose!");
                return false;
            }
            else 
            {
                Console.WriteLine("its a draw! dealer still wins!");
                return false;
            }

        }
         
         



        private static int Dealcards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card1;
            Console.WriteLine(player + "drew" + card1 + "and" + card2 + "for a total of" + total);
            return total;
        }
         
             
    }
}
