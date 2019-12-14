using System;
using System.Collections.Generic;
using System.Text;

namespace _20191214_Figures
{
    class VolumeFigure
    {
        protected Line[] _lines;   // ???

        //public Figure(params Point[] points)
        //{
        //    Console.WriteLine(points.Length);
        //    _lines = new Line[points.Length];
        //    for (int i = 0; i < points.Length - 1; i++)
        //    {
        //        _lines[i] = new Line(points[i], points[i + 1]);
        //    }
        //    _lines[points.Length - 1] = new Line(points[points.Length - 1], points[0]);
        //}

        public void DrawPixel(int x, int y, ConsoleColor color, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        } 

        public virtual void Draw(ConsoleColor color,char symbol)
        {
            for (int i = 0; i < _lines.Length; i++)
            {
                _lines[i].DrawLine(color,symbol);
            }
        }
    }
}
