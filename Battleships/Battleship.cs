﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Battleship
    {
        string name;
        int[,] gridPositions;
        public int length {get; set;}
        int[] status;
        bool destroyed;

        public Battleship(string name, int length)
        {
            this.name = name;
            this.length = length;
            destroyed = false;
        }
    }
}
