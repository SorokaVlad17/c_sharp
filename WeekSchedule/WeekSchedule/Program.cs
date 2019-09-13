using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekSchedule
{
    class Program
    {
        static void DrawWeek(byte week)
        {
            Console.WriteLine("MON TUE THU WED FRI SUN STR");

            Console.WriteLine(" -   -   -   -   -   -   -  ");

            Console.WriteLine("Week = {0}", week);

            Console.WriteLine(Convert.ToString(week, 2));

            Console.SetCursorPosition(1, 1);
        }
        static void Main(string[] args)
        {
            byte[] masks = { 0x01, 0x02, 0x04, 0x08, 0x10,0x20, 0x40 };

            const byte MIN_POS = 1;

            const byte MAX_POS = 25;

            const byte STEP = 4;

            byte week = 0x00;

            byte nowPosition = 1;

            DrawWeek(week);

            while(true) 
            {
                switch( Console.ReadKey(false).Key)
                {

                    case ConsoleKey.LeftArrow:
                    {
                            if (nowPosition==MIN_POS)
                            {
                              break;
                            }
                            else
                            {
                              nowPosition -= STEP;
                            }

                            break;
                    }
                    case ConsoleKey.RightArrow:
                    {
                            if (nowPosition == MAX_POS)
                            {
                                break;
                            }
                            else
                            {
                                nowPosition += STEP;
                            }

                            break;
                    }
                    case ConsoleKey.Enter:
                    {
                            int posX = (nowPosition - 1) / STEP;

                            if((week & masks[posX])>0)
                            {
                                week=(byte)(week & (~masks[posX]));
                            }
                            else
                            {
                                week = (byte)(week  | masks[posX]);
                            }

                            break;

                    }


                }

                Console.Clear();

                DrawWeek(week);

                for(int i=0;i<masks.Length;i++)
                {
                    if((byte)(week & masks[i])>0)
                    {
                        int posX = (i * STEP) + 1;

                        Console.SetCursorPosition(posX, 1);
                        Console.Write("+");
                    }
                }

                Console.SetCursorPosition(nowPosition, 1);

            }
        }
    }
}
