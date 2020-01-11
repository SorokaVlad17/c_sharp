using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Block : Pixel
    {
        private KindOfBlock _kindOfBlock;

        public KindOfBlock TypeBlock
        {
            get
            {
                return _kindOfBlock;
            }
        }
        public Block(Skin skin, int x, int y , KindOfBlock block):base(skin,x,y)
        {
            _kindOfBlock = block;
        }
    }
}
