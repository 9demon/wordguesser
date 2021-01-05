using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using zero.Options;

/*
 * Made by demon (https://github.com/9demon)
 */

namespace zero
{
    class mainMenu
    {
        public static void size()
        {
            Console.SetWindowSize(150, 40);
        }
        public static void makeASCII()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("                                                                    ┌─┐┬┌┬┐┌─┐┬  ┌─┐");
            Console.WriteLine("                                                                    └─┐││││├─┘│  ├┤ ");
            Console.WriteLine("                                                                    └─┘┴┴ ┴┴  ┴─┘└─┘");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Options()
        {
            mainMenu.size();
            Console.Title = "Main menu";
            makeASCII();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                                                     Welcome " + Environment.UserName);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Choose one of the following options :");
            Console.WriteLine();
            Console.Write("   [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] Word Guesser");
            Console.WriteLine("");
            Console.Write("   [");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] Exit");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(" > ");
            int chooser = int.Parse(Console.ReadLine());
            switch(chooser)
            {
                case 1: 
                    Console.Clear(); WordGuesser.guesserGame();
                    break;

                case 2: Console.Clear(); Bye.quit();
                    break;

                default:
                break;
            }
        }
    }
}
