using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191019_StructsDemo
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            //PointstWithoutStructs();

            //PointstWithStructs();

            //PolyLine pl1;

            //pl1.Points = null;

            //PolyLine pl1 = new PolyLine() { Points = null };

            PolyLine pl1 = new PolyLine() { Points = new Point[0] };

            BL.Add(ref pl1, new Point() { X = 2, Y = 12, Color = ConsoleColor.Red });
            BL.Add(ref pl1, new Point() { X = 12, Y = 5, Color = ConsoleColor.Blue });
            BL.Add(ref pl1, new Point() { X = 42, Y = 22, Color = ConsoleColor.Yellow });

            Console.WriteLine("pl1 (1)");
            UI.Show(pl1);

            Console.ReadKey();

            //PolyLine pl1Copy = pl1;    // !!! копирование "по-полям"

            PolyLine pl1Copy = BL.GetCopy(pl1);    // !!! копирование полное

            pl1Copy.Points[1].Color = ConsoleColor.Green;

            Console.Clear();

            Console.WriteLine("pl1 (2)");
            UI.Show(pl1);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("pl1Copy");
            UI.Show(pl1Copy);

            Console.ReadKey();
        }

        private static void PointstWithStructs()
        {
            //Point p1;

            //p1.X = 5;
            //p1.Y = 3;
            //p1.C = ConsoleColor.Green;

            Point p1 = new Point() { X = 5, Y = 3, Color = ConsoleColor.Green };    // Инициализация полей структуры при объявлении

            //p1.X = 5;
            //p1.Y = 5;
            //p1.C = ConsoleColor.Green;


            UI.Show(p1);

            // !!! массив структур !!!
            Point[] points = new Point[100];

            for (int i = 0; i < 100; i++)
            {
                points[i] = new Point() { X = rnd.Next(0, Console.WindowWidth), Y = rnd.Next(0, Console.WindowHeight), Color = (ConsoleColor)(rnd.Next(0, (int)ConsoleColor.White) + 1)};
            }

            UI.Show(points);
        }

        private static void PointstWithoutStructs()
        {
            int x = 5;
            int y = 3;

            ConsoleColor clr = ConsoleColor.Red;

            UI.ShowPoint(x, y, clr);

            int[] xCoords = new int[100];
            int[] yCoords = new int[100];

            for (int i = 0; i < 100; i++)
            {
                xCoords[i] = rnd.Next(0, Console.WindowWidth);
                yCoords[i] = rnd.Next(0, Console.WindowHeight);
            }

            //for (int i = 0; i < 100; i++)
            //{
            //    UI.ShowPoint(xCoords[i], yCoords[i]);
            //}

            ConsoleColor[] pointsColors = new ConsoleColor[100];

            for (int i = 0; i < 100; i++)
            {
                pointsColors[i] = (ConsoleColor)(rnd.Next(0, (int)ConsoleColor.White) + 1);
            }

            UI.ShowPoints(xCoords, yCoords, pointsColors);
        }
    }
}
