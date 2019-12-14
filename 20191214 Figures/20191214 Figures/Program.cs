using System;

namespace _20191214_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(new Point(1, 1), new Point(1, 10), new Point(10, 1));
            triangle.Draw(ConsoleColor.Green,'*');
            Circle circle = new Circle(10, 10, 3);
            circle.Draw(ConsoleColor.Red,'*');
            Rectangle rectangle = new Rectangle(new Point(15, 16), new Point(13, 15), new Point(20, 18), new Point(22, 20));
            rectangle.Draw(ConsoleColor.Yellow,'*');
            //Figure figure = new Figure(new Point(1, 1), new Point(2, 2), new Point(3, 6), new Point(8, 9), new Point(10, 15), new Point(18, 19));
            //figure.Draw(ConsoleColor.DarkCyan, '*');
            string
            Console.ReadKey();
        }
    }
}
