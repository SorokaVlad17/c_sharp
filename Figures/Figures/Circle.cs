using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle:Figure
    {
        protected int _r;
        protected int _x0;
        protected int _y0;

        public Circle(int x0,int y0,int r)
        {
            _x0 = x0;
            _y0 = y0;
            _r = r;
        }
       
    }
}
