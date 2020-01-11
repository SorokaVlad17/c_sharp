using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Pixel
    {
        #region ======Private fields======

        protected Coordinate _position;
        protected Skin _skin;

        #endregion

        #region ======Properties======

        public int X
        {
            get
            {
                return _position.X;
            }
        }

        public int Y
        {
            get
            {
                return _position.Y;
            }
        }

        public Skin Clothing
        {
            get
            {
                return new Skin(_skin);
            }
        }

        #endregion

        #region ======Constructors======

        public Pixel(Skin skin, int x, int y)
        {
            _skin = new Skin(skin);
            _position = new Coordinate(x, y);
        }

        public Pixel(Pixel px)
        {
            _skin = new Skin(px.Clothing);
            _position = new Coordinate(px.X, px.Y);
        }

        #endregion

        #region ======Methods======

        public Pixel GetCopy()
        {
            return (Pixel)MemberwiseClone();
        }

        #endregion

        #region ======Overload operators======
        
        public static bool operator ==(Pixel p1, Pixel p2)
        {
            return (p1.Clothing.Color == p2.Clothing.Color && p1.Clothing.Symbol == p2.Clothing.Symbol);
        }

        public static bool operator !=(Pixel p1, Pixel p2)
        {
            return !(p1 == p2);
        }

        #endregion
    }
}
