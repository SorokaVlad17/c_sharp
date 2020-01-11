using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola 
{
    class Wood : Block
    {
        public Wood(int x, int y) : base(Game.Blocks[KindOfBlock.Wood], x, y, KindOfBlock.Wood)
        {

        }
    }
}
