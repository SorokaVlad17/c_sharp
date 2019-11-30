using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _20191130_Mad_Gear
{
    class Game
    {
        private static readonly int WIDTH_CONSOLE = 100;
        private static readonly int HEGHT_CONSOLE = 30;
        private static readonly string TITLE_OF_GAME = "Mad Gear";
        private static readonly int MAX_COUNT_BLOCKS_ON_THE_FIELD = 3;
        private static int SpeedInMiliseconds = 100;
        public static readonly int OFFSET_Y = 25;
        public static int HeightOfJump = 18;
        public static readonly int POSITION_X_OF_SCORE = 9;
        public static readonly int POSITION_Y_OF_SCORE = 0;
        public static readonly int POSITON_Y_OF_THE_FLOOR = 25;
        public static bool PlayerIsFlying = false;
        public static int Score = 0;
        public static ulong GameTime;
        public static Block Player = new Block { X = 0, Y = 25, Width = 7, Height = 5, Symbol = '0' };
        public static Block[] Blocks = new Block[MAX_COUNT_BLOCKS_ON_THE_FIELD];

        static Random rnd = new Random();

        public static void InitilizationGameByDefault()
        {
            Console.WriteLine("Score : ");
            Console.SetWindowSize(WIDTH_CONSOLE, HEGHT_CONSOLE);
            UI.DrawWalls();
            Console.Title = TITLE_OF_GAME;

            Blocks[0] = new Block { X = 30, Width = 5, Height = 3, Symbol = '*', Y = 25 };
            Blocks[1] = new Block { X = 70, Width = 5, Height = 3, Symbol = '*', Y = 25 };
            Blocks[2] = new Block { X = 90, Width = 5, Height = 3, Symbol = '*', Y = 25 };
            UI.PrintPlayer();

        }

        public static bool IsCoordinatesCorrect(Block block)
        {
            bool isCorrect = true;
            if (PlayerIsFlying)
            {
                if (Player.Y == block.Y - block.Height && Math.Abs(block.X - Player.X) - Player.Width <= 0)
                {
                    isCorrect = false;
                }
            }
            else
            {
                if (block.X == Player.X + Player.Width || block.X + block.Width == Player.X)
                {
                    isCorrect = false;
                }
            }
            return isCorrect;
        }

        public static bool IsAnyBlockTouchedBall()
        {
            bool isTouch = false;
            for (int i = 0; i < Blocks.Length; i++)
            {
                if (!IsCoordinatesCorrect(Blocks[i]))
                {
                    isTouch = true;
                    break;
                }
            }
            return isTouch;
        }

        static void MoveBlocks()
        {

            for (int i = 0; i < Blocks.Length; i++)
            {
                ++Score;
                UI.Hide(Blocks[i], 0);
            }

            for (int i = 0; i < Blocks.Length; i++)
            {
                ++Score;
                Blocks[i].X -= 1;
            }

            for (int i = 0; i < Blocks.Length; i++)
            {
                ++Score;
                UI.Show(Blocks[i]);
            }
        }

        public static void FallPlayer()
        {

            if (Game.Player.Y == POSITON_Y_OF_THE_FLOOR)
            {
                Game.PlayerIsFlying = false;
            }
            else
            {
                if (rnd.Next() % 3 == 0)
                {
                    ++Game.Player.Y;
                }
            }


        }

        public static void EnterKey()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (Game.Player.X != 1)
                        {
                            UI.HidePlayer(0);
                            --Game.Player.X;
                            UI.PrintPlayer();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Game.Player.X != Game.WIDTH_CONSOLE)
                        {
                            UI.HidePlayer(0);
                            ++Game.Player.X;
                            UI.PrintPlayer();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (!Game.PlayerIsFlying)
                        {
                            UI.HidePlayer(0);
                            Game.Player.Y -= Game.HeightOfJump;
                            Game.PlayerIsFlying = true;

                        }
                        break;

                }
            }
        }

       
        public static int GetRandomWidth()
        {
            return rnd.Next(1, 10);
        }

        public static int GetRandomPositionX()
        {
            return rnd.Next(50, 100);
        }

        public static int GetRandomHeight()
        {
            return rnd.Next(1, HeightOfJump - 1);
        }

        public static void ChangeBlokcks()
        {

            for (int i = 0; i < Blocks.Length; i++)
            {
                if (Blocks[i].X == 1)
                {
                    UI.Hide(Blocks[i], 0);
                    Blocks[i].X = GetRandomPositionX();
                    Blocks[i].Width = GetRandomWidth();
                    Blocks[i].Height = GetRandomHeight();
                }
            }
        }
        public static void GameIteration()
        {
            ++GameTime;
            if (GameTime % 2 == 0)
            {
                ChangeBlokcks();
                MoveBlocks();
            }
            if (PlayerIsFlying)
            {
                FallPlayer();
                UI.HidePlayer(1);
                UI.PrintPlayer();
                UI.ShowScore(Score, ConsoleColor.Yellow);
            }
            EnterKey();
            Thread.Sleep(SpeedInMiliseconds);

        }
    }
}
