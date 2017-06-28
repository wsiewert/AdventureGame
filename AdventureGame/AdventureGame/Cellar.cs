using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Cellar
    {
        public string locationName = "cellar";
        public string choiceCastle = "castle";

        public Cellar()
        {

        }

        public string Choice(Player adventurer)
        {
            Console.WriteLine("Choices:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("'" + choiceCastle + "'");
            Console.ResetColor();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "cellar":
                    return "cellar";
                case "player commands":
                    adventurer.DisplayPlayerCommands();
                    return "cellar";
                case "quit":
                    break;
                default:
                    break;
            }
            return userInput;
        }
    }
}
