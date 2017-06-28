using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Castle
    {
        public string locationName = "castle";
        public string choiceField = "field";
        public string choiceCellar = "cellar";

        public Castle()
        {

        }

        public string Choice(Player adventurer)
        {
            Console.WriteLine("Choices:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("'" + choiceField + "', " + "'" + choiceCellar + "'");
            Console.ResetColor();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "field":
                    return "field";
                case "cellar":
                    return "cellar";
                case "player commands":
                    adventurer.DisplayPlayerCommands();
                    return "castle";
                case "quit":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(userInput + "  --NOT A COMMAND--");
                    Console.ResetColor();
                    return Choice(adventurer);
            }
            return userInput;
        }
    }
}
