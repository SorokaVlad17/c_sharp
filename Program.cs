using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190921_EnumsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Direction d;

            d = Direction.Right;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("d = {0} ({1})", d, (int)d);

            Console.Write("Enter direction? ");

            string str = Console.ReadLine();

            if (Enum.TryParse(str, out d))
	        {
                Console.WriteLine("d = {0} ({1})", d, (int)d);
	        }
            else
            {
                Console.WriteLine("Wrong direction... :(");
            }

            switch (d)
            {
                case Direction.NoDirection:
                    Console.WriteLine("Направление не определено");
                    break;
                case Direction.Left:
                    Console.WriteLine("Лево");
                    break;
                case Direction.Right:
                    Console.WriteLine("Право");
                    break;
                case Direction.Top:
                    Console.WriteLine("Верх");
                    break;
                case Direction.Bottom:
                    Console.WriteLine("Низ");
                    break;
                default:

                    break;
            }

            #region ConsoleColor

            ConsoleColor clr = ConsoleColor.Red;

            switch (clr)
            {
                case ConsoleColor.Black:
                    break;
                case ConsoleColor.Blue:
                    break;
                case ConsoleColor.Cyan:
                    break;
                case ConsoleColor.DarkBlue:
                    break;
                case ConsoleColor.DarkCyan:
                    break;
                case ConsoleColor.DarkGray:
                    break;
                case ConsoleColor.DarkGreen:
                    break;
                case ConsoleColor.DarkMagenta:
                    break;
                case ConsoleColor.DarkRed:
                    break;
                case ConsoleColor.DarkYellow:
                    break;
                case ConsoleColor.Gray:
                    break;
                case ConsoleColor.Green:
                    break;
                case ConsoleColor.Magenta:
                    break;
                case ConsoleColor.Red:
                    break;
                case ConsoleColor.White:
                    break;
                case ConsoleColor.Yellow:
                    break;
                default:
                    break;
            }
            
            #endregion

            Border b1 = Border.LeftTop;

            Console.WriteLine("b1 = {0} ({1})", b1, (char)b1);

            b1 = (Border)0x2557;

            Console.WriteLine("b1 = {0} ({1})", b1, (char)b1);

            #region ---- ====   Flags enums   ==== ----

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;

            MultyDirection md1 = MultyDirection.Bottom;

            Console.WriteLine("md1 = {0} ({1})", md1, (int)md1);

            md1 = MultyDirection.Bottom | MultyDirection.Left;

            Console.WriteLine("md1 = {0} ({1})", md1, (int)md1);

            if ((md1 & MultyDirection.Left) > 0)
            {
                Console.WriteLine("bit Left is set");
            }
            else
            {
                Console.WriteLine("bit Left isn't set");
            }

            if ((md1 & MultyDirection.Right) > 0)
            {
                Console.WriteLine("bit Right is set");
            }
            else
            {
                Console.WriteLine("bit Right isn't set");
            }

            if (md1.HasFlag(MultyDirection.Left))
            {
                Console.WriteLine("bit Left is set");
            }
            else
            {
                Console.WriteLine("bit Left isn't set");
            }

            md1 |= MultyDirection.Right;

            if (md1.HasFlag(MultyDirection.Right))
            {
                Console.WriteLine("bit Right is set");
            }
            else
            {
                Console.WriteLine("bit Right isn't set");
            }

            md1 &= (MultyDirection)(~((byte)MultyDirection.Right));

            if (md1.HasFlag(MultyDirection.Right))
            {
                Console.WriteLine("bit Right is set");
            }
            else
            {
                Console.WriteLine("bit Right isn't set");
            }

            md1 ^= MultyDirection.Right;

            if (md1.HasFlag(MultyDirection.Right))
            {
                Console.WriteLine("bit Right is set");
            }
            else
            {
                Console.WriteLine("bit Right isn't set");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
