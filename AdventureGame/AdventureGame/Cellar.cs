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

        public string Choice()
        {
            Console.WriteLine("Choices:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(choiceCastle);
            Console.ResetColor();
            string userInput = Console.ReadLine();
            if (userInput == choiceCastle)
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
