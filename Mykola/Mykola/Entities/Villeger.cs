using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Villeger : Entity
    {
        
        public Villeger(int x, int y) : base(Game.Skins[Race.Vilager],x,y,Race.Vilager)
        {
            _hp = 20;
            _damage = 5;
        }
    }
}
