using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class AdventureGame
    {
        public Player adventurer = new Player();
        public Castle castle = new Castle();
        public Cellar cellar = new Cellar();

        public AdventureGame()
        {
            
        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hi there adventurer, lets give you a name first: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            adventurer.name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome adventurer " + adventurer.name + ", lets get started.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("This is a 'choose your own adventure game.' You will be prompted to");
            Console.WriteLine("make a decision every turn. Choose wisley, have fun!");
            Console.WriteLine("Press any key to continue.");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("You start off in a castle with nothing in your inventory...");

            DisplayMenu();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("_____________________________________");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(adventurer.name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("     @     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(adventurer.location);
            Console.ResetColor();

            switch (adventurer.location)
            {
                case "cellar":
                    adventurer.location = cellar.Choice(adventurer);
                    DisplayMenu();
                    break;
                case "castle":
                    adventurer.location = castle.Choice(adventurer);
                    DisplayMenu();
                    break;
                case "quit":
                    break;
                default:
                    break;
            }
        }
    }
}
