using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bresenham_s_Algorithm
{
    class UI
    {
        public static void EnterCords(ref int x1,ref int y1,ref int x2, ref int y2)
        {
            Console.Write("Enter the X 1st point : ");
            x1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Y 1st point : ");
            y1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the X 2nd point : ");
            x2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Y 2nd point : ");
            y2 = int.Parse(Console.ReadLine());
        }

        public static void DrawPoint(int x, int y , ConsoleColor color = ConsoleColor.White, char symbol = '*') //'■')
        {
            Console.SetCursorPosition(x,y);

            Console.ForegroundColor = color;
            Console.Write(symbol);
        }
        public static void DrawLine(Point p1, Point p2)
        {
            Console.Clear();
            //int deltaX = Math.Abs(p2.X - p1.X);
            //int deltaY = Math.Abs(p2.Y - p2.Y);
            //int error = 0;
            //int deltaError = deltaY;
            //int y = p1.Y;
            //int dirY = p2.Y - p1.Y;

            //if(dirY > 0)
            //{
            //    dirY = 1;
            //}
            //if(dirY < 0)
            //{
            //    dirY = -1;
            //}

            //for (int x = p1.X; x < p2.X; x++)
            //{
            //    DrawPoint(x,y);
            //    error += deltaError;
            //    if(2 * error >= deltaX)
            //    {
            //        y += dirY;
            //        error -= deltaX;
            //    }
            //}



            //    int incX, incY;
            //    int errorX, errorY;
            //    int currentX, currentY;

            //    int dx = p2.X - p1.X;
            //    int dy = p2.Y - p1.Y;

            //    if (dx > 0)
            //    {
            //        incX = 1;
            //    }
            //    else
            //    {
            //        if (dx == 0)
            //        {
            //            incX = 0;
            //        }
            //        else
            //        {
            //            incX = -1;
            //        }
            //    }

            //    if (dy > 0)
            //    {
            //        incY = 1;
            //    }
            //    else
            //    {
            //        if (dy == 0)
            //        {
            //            incY = 0;
            //        }
            //        else
            //        {
            //            incY = -1;
            //        }
            //    }

            //    dx = Math.Abs(dx);
            //    dy = Math.Abs(dy);

            //    int L = Math.Max(dx, dy);

            //    errorX = p1.X;
            //    errorY = p1.Y;

            //    currentX = p1.X;
            //    currentY = p2.Y;


            //    for(int x = 0; x < p2.X; x++)
            //    {
            //        errorX += dx;
            //        errorY += dy;

            //        DrawPoint(currentX, currentY);

            //        if (errorX > L)
            //        {
            //            errorX -= L;
            //            currentX += incX;
            //        }

            //        if (errorY > L)
            //        {
            //            errorY -= L;
            //            currentY += incY;
            //        }
            //    }
            //int dx = p2.X - p1.X;
            //int dy = p2.Y - p1.Y;
            //int D = 2 * dy - dx;
            //int y = p1.Y;
            //for (int x = p1.X;x < p2.X; x++)
            //{
            //    DrawPoint(x, y);
            //    if(D > 0)
            //    {
            //        y++;
            //        D -= 2 * dx;
            //    }
            //    D += 2 * dx;
            }
        }

    }
}
