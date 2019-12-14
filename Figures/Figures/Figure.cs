using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Figure
    {
        protected Line[] _lines;
        public virtual void Draw()
        {
            for (int i = 0; i < _lines.Length; i++)
            {
                _lines[i].DrawLine();
            }
        }
    }
}
