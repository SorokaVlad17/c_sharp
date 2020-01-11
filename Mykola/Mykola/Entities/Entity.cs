using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Entity : Pixel
    {
        #region ======Private fields======

        protected Race _race;
        protected int _hp;
        protected int _damage;
        protected Way _way;

        #endregion

        #region ======Constructors======

        public Entity(Entity entity) : base(entity)
        {
            _race = entity.TypeRace;
            _hp = entity.Healthpoints;
            _damage = entity.Damage;
            _way = new Way(entity._way);
        }

        #endregion

        #region ======Properties======

        public Race TypeRace
        {
            get
            {
                return _race;
            }
        }

        public int Healthpoints
        {
            get
            {
                return _hp;
            }
            set
            {
                Healthpoints = value;
            }
        }
        public Way Direction
        {
            get
            {
                if (_way == null)
                {
                    return null;
                }
                else
                {
                    return new Way(_way.Start, _way.End);
                }
            }
            set
            {
                _way = value;
            }
        }

        public int Damage
        {
            get
            {
                return _damage;
            }
        }

        #endregion

        #region ======Constructors======

        public Entity(Skin skin, int x, int y, Race race) : base(skin, x, y)
        {
            _race = race;
        }

        #endregion

        #region ======Methods======

        public int GetDistance(Pixel px)
        {
            int deltaX = px.X - X;
            int deltaY = px.Y - Y;
            int distance = 0;

            if (Math.Abs(deltaX) >= Math.Abs(deltaY))
            {
                double koef = (double)deltaY / (double)deltaX;

                if (deltaX > 0)
                {
                    for (int i = 0; i <= deltaX; i++)
                    {
                        ++distance;
                    }
                }
                else
                {
                    for (int i = 0; i >= deltaX; i--)
                    {
                        ++distance;
                    }
                }
            }
            else
            {
                double koef = (double)deltaX / (double)deltaY;

                if (deltaY > 0)
                {
                    for (int i = 0; i <= deltaY; i++)
                    {
                        ++distance;
                    }
                }
                else
                {
                    for (int i = 0; i >= deltaY; i--)
                    {
                        ++distance;
                    }
                }
            }

            return distance;
        }

        public void MoveEntity()
        {
            if (_way.Position + 1 == _way.Distance)
            {
                _way = new Way(new Coordinate(X,Y), new Coordinate(X,Y));
            }
            else
            {
                _position.X = _way.GetCoordinate(_way.Position).X;
                _position.Y = _way.GetCoordinate(_way.Position).Y;
                ++_way.Position;


            }

        }

        #endregion


    }
}
