﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        public string name;
        public string location;

        public Player()
        {
            name = "";
            location = "castle";
        }

        public void DisplayPlayerCommands()
        {
            Console.WriteLine("No Commands here yet...");
        }

    }
}
