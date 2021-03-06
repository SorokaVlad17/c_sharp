﻿using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace MovingMouse
{
    class Program
    {
        static void Main(string[] args)
        {

            //MOVING MOUSE IN CONSOLE!

            int xConsole,yConsole;

            const int SPEED_MOUSE_X = 5;

            const int SPEED_MOUSE_Y = 25;
            
            const char CURSOR = '*';

            int xMonitorBefore = Cursor.Position.X;
            int yMonitorBefore = Cursor.Position.Y;

            for (; ; )
            {

                int xMonitorNow = Cursor.Position.X;
                int yMonitorNow = Cursor.Position.Y;

                xConsole = ((xMonitorNow - yMonitorBefore) / SPEED_MOUSE_X) + Console.CursorLeft ;
                yConsole =(yMonitorNow + yMonitorBefore) / SPEED_MOUSE_Y + Console.CursorTop - 2 ;

                try
                {
                   Console.SetCursorPosition(xConsole, yConsole);
                }
                catch
                {
                                
                }
                finally
                {
                    Console.Write(CURSOR);
                }

                xMonitorBefore = xMonitorNow;
                yMonitorBefore = yMonitorNow;

                Thread.Sleep(15);

                Console.Clear();
                
            }
        }
    }
}
