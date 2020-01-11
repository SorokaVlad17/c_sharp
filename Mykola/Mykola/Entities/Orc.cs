using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Orc : Entity
    {
        public Orc(int x, int y) : base(Game.Skins[Race.Orc], x, y, Race.Orc)
        {
            _hp = 30;
            _damage = 7;
        }
    }
}
