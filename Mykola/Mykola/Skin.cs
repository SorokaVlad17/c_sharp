using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    struct Skin
    {
        #region ======Fields======

        public ConsoleColor Color;
        public char Symbol;
        public bool CanWalk;

        #endregion

        #region ======Constructors======

        public Skin(ConsoleColor color, char symbol, bool canWalk = true)
        {
            Color = color;
            Symbol = symbol;
            CanWalk = canWalk;
        }

        public Skin(Skin mad)
        {
            this = (Skin)mad.MemberwiseClone();
        }

        #endregion

    }
}
