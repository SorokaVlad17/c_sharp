using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Water : Block
    {
        public Water(int x, int y) : base(Game.Blocks[KindOfBlock.Water],x,y,KindOfBlock.Water)
        {

        }
    }
}
