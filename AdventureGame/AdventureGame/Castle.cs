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

        public string Choice()
        {
            Console.WriteLine("Choices:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(choiceField + " " + choiceCellar);
            Console.ResetColor();
            string userInput = Console.ReadLine();
            if (userInput == choiceCellar || userInput == choiceField)
            {
                return userInput;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NOT A COMMAND!");
                Console.ResetColor();
                return Choice();
            }
        }
    }
}
