using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    static class Game
    {
        #region ======Fields======

        public static readonly int WINDOW_WIDTH = 100;
        public static readonly int  WINDOW_HEIGHT = 30;
        public static readonly char SYMBOL_SQUARE = '■';
        public static Dictionary<Race, Skin> Skins = new Dictionary<Race, Skin>()
        {
            {Race.Orc, new Skin(){ Color = ConsoleColor.DarkRed, Symbol = '*'}},
            {Race.Vilager, new Skin(){Color = ConsoleColor.Yellow, Symbol = '*'}}
        };
        public static Dictionary<KindOfBlock, Skin> Blocks = new Dictionary<KindOfBlock, Skin>()
        {
            {KindOfBlock.Grass, new Skin(ConsoleColor.DarkGreen, SYMBOL_SQUARE)},
            {KindOfBlock.Water, new Skin(ConsoleColor.Blue, SYMBOL_SQUARE, false)},
            {KindOfBlock.Wood, new Skin(ConsoleColor.DarkYellow, SYMBOL_SQUARE)}
        };

        #endregion

        #region ======Methods======

        public static void SetSettingsByDefault()
        {
            
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.Title = "Mykola";
            Console.CursorVisible = false;
        }

        #endregion
    }
}
