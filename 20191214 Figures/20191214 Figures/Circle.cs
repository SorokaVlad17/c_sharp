using System;
using System.Collections.Generic;
using System.Text;

namespace _20191214_Figures
{
    class Circle : VolumeFigure
    {
        private int _r;
        private int _x0;
        private int _y0;

        public Circle(int x0, int y0, int r)
        {
            _x0 = x0;
            _y0 = y0;
            _r = r;
        }

        // ToDo: ---> UI
        public override void Draw(ConsoleColor color, char symbol)
        {
            int disp_x = _x0;
            int disp_y = _y0;
            int x = 0;
            int y = _r;
            int delta = (1 - 2 * _r);
            int error = 0;

            while (y >= 0)
            {
                DrawPixel(disp_x + x, disp_y + y, color, symbol);
                DrawPixel(disp_x + x, disp_y - y,color, symbol);
                DrawPixel(disp_x - x, disp_y + y, color, symbol);
                DrawPixel(disp_x - x, disp_y - y, color, symbol);

                error = 2 * (delta + y) - 1;
                if ((delta < 0) && (error <= 0))
                {
                    ++x;
                    delta = delta + (2 * x + 1);
                    continue;
                }
                error = 2 * (delta - x) - 1;
                if ((delta > 0) && (error > 0))
                {
                    --y;
                    delta = delta + (1 - 2 * y);
                    continue;
                }
                ++x;
                delta = delta + (2 * (x - y));
                --y;
            }
        }
    }
}
