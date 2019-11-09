using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mad_Gear
{
    class Game
    {
        static public readonly int WIDTH_CONSOLE = 100;
        static public readonly int HEGHT_CONSOLE = 30;
        static public readonly string TITLE_OF_GAME = "Mad Gear";
        static public readonly int MIN_X_OF_BALL = 0;
        static public readonly int MAX_X_OF_BALL = 8;
        static public int MinYOfBall = 22;
        static public int MaxYOfBall = 29;
        static public int HeightOfJump = 7;
        static public int SpeedInMiliseconds = 1000;
        static public bool ballIsFlight = false;
      //  static public int Min_Y = 25;


        public static void InitilizationConsoleByDefault()
        {
            Console.SetWindowSize(WIDTH_CONSOLE, HEGHT_CONSOLE);
            Console.Title = TITLE_OF_GAME;
        }

        public static bool IsSizeOfWindowCorect()
        {
            bool isCorrect = true;

            if (Console.WindowWidth != WIDTH_CONSOLE
               && Console.WindowHeight != HEGHT_CONSOLE)
            {
                isCorrect = false;
            }

            return isCorrect;
        }

        public static void GameLoop()
        {
            EventOfMap.MoveBlocks();
            
            Thread.Sleep(SpeedInMiliseconds);
            Console.Clear();
            EventOfMap.PrintMap();
            
        }

        public static async void JumpAndFall()
        {
            var t1 = Jump();
            var t2 = Fall();
            await Task.WhenAll(t1, t2);
        }
        public static async Task Jump()
        {
            await Task.Run(
            () =>
            {
                do
                {

                    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                    {
                        EventOfMap.JumpPlayer();
                        ballIsFlight = true;
                    }
                } while (true);
            }
            );
        }
        public static async Task Fall()
        {
            await Task.Run(
                ()=>
                {
                    do
                    {
                        if(ballIsFlight)
                        {
                            EventOfMap.FallBall();
                        }
                    } while (true);
                }
                );
        }


    }
}
