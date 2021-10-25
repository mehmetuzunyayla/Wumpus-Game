using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Program
    {
        static int playAgain()
        {
            Console.WriteLine("Do you want play again ? If yes press 1");
            int choose = Convert.ToInt32(Console.ReadLine());

            return choose;
        }
        static void clean()
        {
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {

            int wumpus=0, human=0, pit=0, pit1=0, treasure=0;
            Random rnd = new Random();
            a:

            while (human==wumpus || human == pit || human == pit1 || human == treasure || wumpus ==pit || wumpus ==pit1 || wumpus ==treasure || treasure ==pit || treasure ==pit1 || pit == pit1 )
            {
                wumpus = rnd.Next(1, 17);
                human = rnd.Next(1, 17);
                pit = rnd.Next(1, 17);
                pit1 = rnd.Next(1, 17);
                treasure = rnd.Next(1, 17);
            }
            //Console.WriteLine(human+"h "+wumpus+"w "+pit+"p "+pit1+"p "+treasure+"t");
            Console.WriteLine("WELCOME");
            Console.ReadKey();
            b:
            Console.WriteLine("Which cave do you wanna go ?");
            human = Convert.ToInt32(Console.ReadLine());

                if (human == treasure)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You have found treasure until now you are RICH bitch");
                    Console.ReadKey();
                    Console.WriteLine(human+"h "+wumpus+"w "+pit+"p "+pit1+"p "+treasure+"t\n");
                    if (playAgain() == 1)
                    {
                        clean();
                        goto a;
                    }
                }
                else if (human == wumpus)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("wumpus has eaten you ");
                    Console.ReadKey();
                    Console.WriteLine(human + "h " + wumpus + "w " + pit + "p " + pit1 + "p " + treasure + "t\n");
                    if (playAgain() == 1)
                    {
                        clean();
                        goto a;
                    }
                }
                else if (human == pit || human == pit1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("you fell into the pit,your leg has broken,you'll die in the pit");
                    Console.WriteLine(human+"h"+wumpus+"w"+pit+"p"+pit1+"p1"+treasure+"\n");
                    if (playAgain() == 1)
                    {
                        clean();
                        goto a;
                    }
                }
                else if (human == wumpus - 1 || human == wumpus + 1)
                {
                    Console.WriteLine("wumpus is around here");
                    goto b;
                }
                else if (human == pit - 1 || human == pit + 1 || human == pit1 - 1 || human == pit1 + 1)
                {
                    Console.WriteLine("Be careful you can fall to the pit");
                    goto b;
                }
                else if (human>16 || human<0)
                {
                    Console.WriteLine("There is no cave in this number");
                    goto b;
                }
                else
                {
                    goto b;
                }


            Console.ReadKey();
        }
    }
}
