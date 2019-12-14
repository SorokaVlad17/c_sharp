using System;
using System.Collections.Generic;
using System.Text;

namespace _20191214_Quare
{
    class Queue
    {
        #region Private fields

        private object[] _items;
        private int _sizeQuare;
        private int _positionWrite;
        private int _positionRead;

        #endregion

        public Queue(int count)
        {
            _sizeQuare = count;
            _positionWrite = 0;
            _positionRead = 0;
            _items = new object[count];
        }

        #region Methods

        public bool IsFull()
        {
            bool isFull = false;
            if (_positionWrite == _sizeQuare)
            {
                isFull = true;
            }

            return isFull;
        }

        public bool Empty
        {
            //bool isEmpty = false;

            //if (_items.Length == 0)
            //{
            //    isEmpty = true;
            //}

            //return isEmpty;

            get 
            {
                return (_positionRead == _positionWrite);
            }            
        }

        public void Enqueue(object item)
        {
            if (IsFull())
            {
                return;
            }

            _items[_positionWrite++] = item;            
        }

        public object Dequeue()
        {
            if (Empty)
            {
                return null;
            }

            return _items[_positionRead++];
        }
    }

    #endregion
}

