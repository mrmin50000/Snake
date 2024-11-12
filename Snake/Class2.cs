using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Dot
    {
        public char[,] map; public int x, y;
        public Dot(char[,] map) {
            this.map = map;
            Random rand = new Random();
            x = rand.Next(1, map.GetLength(0) - 1);
            y = rand.Next(1, map.GetLength(1) - 1);
            if (map[x, y] != '@')
            {
                map[x, y] = '.';
            }


        }
    }
}
