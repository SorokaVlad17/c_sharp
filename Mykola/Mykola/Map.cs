using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mykola
{
    class Map
    {
        #region ======Private fields======

        private int _width;
        private int _height;
        private Pixel[,] _pixels;
        private Pixel[,] _pixelsBoof;
        private List<Block> _recourses = new List<Block>();
        private List<Entity> _entities = new List<Entity>();


        #endregion

        public static Random rnd = new Random();

        #region ======Properties======

        public int Width
        {
            get
            {
                return _width;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
        }

        #endregion

        #region ======Indexator======

        public Pixel this[int i, int j]
        {
            get
            {
                return _pixels[i, j].GetCopy();
            }
        }

        #endregion

        #region ======Constructors======

        public Map(int width, int height)
        {
            _width = width < Game.WINDOW_WIDTH ? width : Game.WINDOW_WIDTH;
            _height = height < Game.WINDOW_HEIGHT ? height : Game.WINDOW_HEIGHT;
            _pixels = new Pixel[Height, Width];
            _pixelsBoof = new Pixel[Height, Width];
            InitilizationOfMap();
        }

        #endregion

        #region ======Methods======

        private void InitilizationOfMap()
        {

            int y1OfWater = Height / 3;
            int y2OfWater = y1OfWater + Height / 5;
            GenerateLakeAndGrass(y1OfWater,y2OfWater);
            GenerateEntitiesByDefault();
            GenereteResourses(y1OfWater, y2OfWater);
        }

        private void GenerateLakeAndGrass(int y1, int y2)
        {
            for (int i = 0; i < Height; i++)
            {
                if (i >= y1 && i <= y2)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        _pixels[i, j] = new Water(j, i);
                        SetBoofElement(_pixels[i, j]);
                    }
                }
                else
                {
                    for (int j = 0; j < Width; j++)
                    {
                        _pixels[i, j] = new Grass(j, i);
                        SetBoofElement(_pixels[i, j]);
                    }
                }
            }
        }

        private void GenerateEntitiesByDefault()
        {
            int x1 = Width / 2;
            int y1 = Height / 4;
            _pixels[y1 - 1, x1] = new Villeger(x1, y1 - 1);
            _entities.Add((Entity)_pixels[y1 - 1, x1]);
            _pixels[y1 - 1, x1 + 1] = new Villeger(x1 + 1, y1 - 1);
            _entities.Add((Entity)_pixels[y1 - 1, x1 + 1]);
            SetBoofElement(_pixels[y1 - 1, x1]);
            SetBoofElement(_pixels[y1 - 1, x1 + 1]);
            int x2 = x1;
            int y2 = Height - y1;
            _pixels[y2, x2] = new Orc(x2, y2);
            _entities.Add((Entity)_pixels[y2, x2]);
            _pixels[y2, x2 + 1] = new Orc(x2 + 1, y2);
            _entities.Add((Entity)_pixels[y2, x2 + 1]);
            SetBoofElement(_pixels[y2, x2]);
            SetBoofElement(_pixels[y2, x2 + 1]);

        }

        private void GenereteResourses(int y1, int y2)
        {
            for (int i = 0; i < rnd.Next(2,10); i++)
            {
                int x = rnd.Next(1, Width - 1);
                int y = rnd.Next(1, y1 );
                if (!(_pixels[y, x] is Entity))
                {
                    _pixels[y, x] = new Wood(x, y);
                    _recourses.Add((Block)_pixels[y, x]);
                    SetBoofElement(_pixels[y, x]);
                }
            }
            for (int i = 0; i < rnd.Next(2, 10); i++)
            {
                int x = rnd.Next(1, Width - 1);
                int y = rnd.Next(y2 + 1, Height - 1);
                if (!(_pixels[y, x] is Entity))
                {
                    _pixels[y, x] = new Wood(x, y);
                    _recourses.Add((Block)_pixels[y, x]);
                    SetBoofElement(_pixels[y, x]);

                }
            }
        }

        public void Update()
        {
            PointTheGoal();
            MoveAllEntities();
        }

        private void MoveAllEntities()
        {
            for (int i = 0; i < _entities.Count; i++)
            {
                if (_entities[i].Direction != null)
                {
                    int x = _entities[i].X;
                    int y = _entities[i].Y;
                    _entities[i].MoveEntity();
                    _pixels[_entities[i].Y, _entities[i].X] = new Entity(_entities[i]);
                    _pixels[y, x] = new Grass(x, y);
                }
            }
        }

        private void PointTheGoal()
        {
            for (int i = 0; i < _entities.Count; i++)
            {
                if(_entities[i].Direction == null)
                {
                    GetGoal(_entities[i]);
                }
            }
        }

        private void GetGoal(Entity entity)
        {
            int minDistance = int.MaxValue;
            int x = entity.X;
            int y = entity.Y;
            for (int i = 0; i < _recourses.Count; i++)
            {
                int distance = entity.GetDistance(_recourses[i]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    x = _recourses[i].X;
                    y = _recourses[i].Y;
                }
            }
            entity.Direction = new Way(new Coordinate(entity.X, entity.Y), new Coordinate(x, y));
        }
        
        

        public Pixel GetBoofElement(int y, int x)
        {
            return new Pixel(_pixelsBoof[y, x]);

        }

        public void SetBoofElement(Pixel px)
        {
            _pixelsBoof[px.Y, px.X] = new Pixel(px);
        }

        #endregion

    }
}
