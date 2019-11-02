using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Mad_Gear
{
    class EventOfMap
    {
        public static string[] Map = new string[Game.HEGHT_CONSOLE];

        public static void LoadMap()
        {
            StreamReader reader = new StreamReader("Map.txt");

            for (int i = 0; i < Map.Length; i++)
            {
                Map[i] = reader.ReadLine();
                Console.WriteLine(Map[i]);
            }

            
        }

    }
}
