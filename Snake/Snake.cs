using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{

    internal class Snake
    {
        
        public void drawmap(char[,] map)
        {
            int k = 0;



            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {


                    if (map[i, j] == '@')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (map[i, j] == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (map[i, j] == '.')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        k += 1;
                    }

                    



                    Console.Write(map[i, j]);

                   

                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();


            }

            
            for (int f = list.Count - 1; f > 0; f--)
            {
                map[list[0].x, list[0].y] = ' ';
                map[list[f].x, list[f].y] = '@';
            }




        }
        virtual public void key(ConsoleKeyInfo keyinfo)
        {


            switch (keyinfo.Key)
            {
                case ConsoleKey.DownArrow:

                    if (d != Direction.Up)
                        d = Direction.Down;

                    break;


                case ConsoleKey.UpArrow:
                    if (d != Direction.Down)
                        d = Direction.Up;

                    break;

                case ConsoleKey.RightArrow:
                    if (d != Direction.Left)
                        d = Direction.Right;

                    break;

                case ConsoleKey.LeftArrow:

                    if (d != Direction.Right)
                        d = Direction.Left;
                    

                    break;

            }

        }
        virtual public void move(List<Point> list, Dot dot)
        {
            if (d == Direction.Down ){ list.Add(new Point(HeadPos.x + 1, HeadPos.y)); }
            else if (d == Direction.Up) { list.Add(new Point(HeadPos.x - 1, HeadPos.y)); }
            else if (d == Direction.Right) { list.Add(new Point(HeadPos.x, HeadPos.y + 1));}
            else { list.Add(new Point(HeadPos.x, HeadPos.y - 1)); }
            if (HeadPos.x != dot.x || HeadPos.y != dot.y )
                list.Remove(list[0]);
            if (map[HeadPos.x, HeadPos.y] == '#')
            {
                Console.WriteLine("Lose");
                Console.ReadKey();
            }



        }

        public int x, y; public Direction d; public char[,] map; public List<Point> list;
        public Point HeadPos
        {
            get => list.Last();
        }
        public Snake(char [,] map, List<Point> list, Direction d) {
            this.d = d; this.map = map; this.list = list;

            var lines = File.ReadAllLines("map.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    map[i, j] = lines[i][j];
                }
            }

  
            


        }
    }
}
