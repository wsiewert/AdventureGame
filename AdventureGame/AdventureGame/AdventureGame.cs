using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class AdventureGame
    {
        Player adventurer = new Player();

        public AdventureGame()
        {
            
        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hi there adventurer, lets give you a name first: ");
            adventurer.name = Console.ReadLine();
            Console.WriteLine("Welcome adventurer " + adventurer.name + " lets get started. Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("This is a 'choose your own adventure game.' You will be prompted to");
            Console.WriteLine("make a decision every turn. Choose wisley, have fun!");
            Console.WriteLine("Press any key to continue.");
            Console.ResetColor();
            Console.ReadKey();
        }

    }
}
