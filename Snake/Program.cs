using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map = new char[12, 47];
            int k = 0;
            ConsoleKeyInfo keyinfo;
            Direction d = Direction.Right;
            
            
            List<Point> list = new List<Point>() { new Point(4, 10), new Point(4 , 11), new Point(4, 12), new Point(4, 13)};
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Snake p = new Snake(map, list, d);
           

            Dot dot = new Dot(map);

            Task.Run(() =>
            {
                while (true)
                {
                    keyinfo = Console.ReadKey();
                }

            });



            keyinfo = Console.ReadKey();

            while (true)
            {

                Console.Clear();
                
                p.key(keyinfo);
                p.move(list, dot);
                p.drawmap(map);
                if (map[dot.x, dot.y] == '@')
                {
                    dot = new Dot(map);
                    k++;
                    
                }
                
                Console.WriteLine($"Score {k}");
                


                
                Thread.Sleep(300);

            }

        }
    }
}
    