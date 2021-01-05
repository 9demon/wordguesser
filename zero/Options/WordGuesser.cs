using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zero.Options
{
    class WordGuesser
    {

        public static void guesserGame()
        {
            mainMenu.size();
            Console.Title = "Word Guesser";
            string secretWord = "Github";
            string enteredWord = "";
            int life = 3;
            int lifecount = 0;
            bool hintTime = false;
            bool outOfGuess = false;

            while (enteredWord != secretWord && !outOfGuess && life != 1)
            {
                if (lifecount < life)
                {
                    Console.Write("Enter the secret word to win the game : ");
                    enteredWord = Console.ReadLine();
                    lifecount++;
                    Console.Clear();
                }
                else
                {
                    outOfGuess = true;
                }
            }
            if (outOfGuess)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("Replay or exit ? ");
                Console.WriteLine("");
                Console.Write("   [");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Play again");
                Console.WriteLine("");
                Console.Write("   [");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Exit to menu");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write(" > ");
                WordGuesser.choose();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win !");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("Replay or exit ? ");
                Console.WriteLine("");
                Console.Write("   [");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Play again");
                Console.WriteLine("");
                Console.Write("   [");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] Exit to menu");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write(" > ");
                WordGuesser.choose();
            }
        }

        public static void choose()
        {
            int chooser2 = int.Parse(Console.ReadLine());
            switch(chooser2)
            {
                case 1: 
                    Console.Clear(); WordGuesser.guesserGame();
                break;

                case 2:
                    Console.Clear();  mainMenu.Options();
                break;

                default:
                break;
            }
        }
    }
}
