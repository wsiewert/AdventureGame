using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Field
    {

        public string locationName = "field";
        public string choiceCastle = "castle";
        public string choiceBeach = "beach";
        public string choiceForest = "forest";
        public string choiceMountain = "mountain";

        public Field()
        {

        }

        public string Choice(Player adventurer)
        {
            Console.WriteLine("Choices:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("'" + choiceCastle + "'" + ", " + choiceBeach + ", " + "'" + choiceForest + ", " + "'" + choiceMountain + ", " + "'");
            Console.ResetColor();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "castle":
                    return "castle";
                case "beach":
                    return "beach";
                case "forest":
                    return "forest";
                case "mountain":
                    return "mountain";
                case "player commands":
                    adventurer.DisplayPlayerCommands();
                    return "field";
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
