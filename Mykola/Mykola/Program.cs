using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            Game.SetSettingsByDefault();

            int width;
            int height;
            UI.EnterData(out width, out height);
            Map map = new Map(width, height);
            UI.DrawMap(map);
            do
            {
                map.Update();
                UI.DrawUpadateMap(map);
            } while (true);
        }
    }
}
