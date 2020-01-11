using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Grass : Block
    {
        public Grass(int x, int y) : base(Game.Blocks[KindOfBlock.Grass],x,y,KindOfBlock.Grass)
        {
                
        }
    }
}
