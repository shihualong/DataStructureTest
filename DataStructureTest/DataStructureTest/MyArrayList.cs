using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureTest
{
    class MyArrayList
    {
        private const int _defaultCapacity = 4;
        private object[] _items;
        private int _size;

        private static readonly object[] emptyArray = new object[0];
       
        public MyArrayList()
        {
            this._items = emptyArray;
        }

        public MyArrayList(int capacity)
        {
            if (capacity < 0)
            {
                ThrowNAOORE("capacity");
            }
            this._items = new object[capacity];
        }

        public virtual object this[int index]
        {
            get
            {
                if (index < 0 || index >= this._size)
                {
                    ThrowNAOORE("index");
                }
                return this._items[index];

            }
            set
            {
                if (index < 0 || index >= this._size)
                {
                    ThrowNAOORE("index");
                }
                this._items[index] = value;
            }
        }

        public virtual int Count
        {
            get
            {
                return this._size;
            }
        }

        public virtual int Capacity
        {
            get
            {
                return this._items.Length;
            }
            set
            {
                if (value != this._items.Length)
                {
                    if (value < this._size)
                    {
                        ThrowNAOORE("value");
                    }
                    if (value > 0)
                    {
                        object[] destination = new object[value];
                        if (this._size > 0)
                        {
                            Array.Copy(this._items, 0, destination, 0, this._size);
                        }
                        this._items = destination;
                    }
                    else
                    {
                        this._items = new object[_defaultCapacity];
                    }
                }
            }
        }

        public virtual int Add(object value)
        {
            if (this._size == this._items.Length)
            {
                this.EnsureCapacity(this._size + 1);
            }
            this._items[this._size] = value;
            return this._size++;
        }

        private void EnsureCapacity(int count)
        {
            if (this._items.Length < count)
            {
                int num = (this._items.Length == 0) ? _defaultCapacity : (this._items.Length * 2);
                if (num < count)
                {
                    num = count;
                }
                this.Capacity = num;
            }
            
        }
        public virtual void Insert(int index,object value)
        {
            if (index < 0 || index > this._size)
            {
                ThrowNAOORE("index");
            }
            if (this._size == this._items.Length)
            {
                this.EnsureCapacity(this._size + 1);
            }
            if (index < this._size)
            {
                Array.Copy(this._items, index, this._items, index + 1, this._size - index);
            }
            this._items[index] = value;
            this._size++;
        }
        public virtual void Deleted(int index)
        {
            if (index < 0 || index > this._size)
            {
                ThrowNAOORE("index");
            }
            this._size--;
            if (index < this._size)
            {
                Array.Copy(this._items, index + 1, this._items, index, this._size - index);
            }
            this._items[this._size] = null;
        }
        public virtual void TrimToSize()
        {
            this.Capacity = this._size;
        }
        public void ThrowNAOORE(string name)
        {
            string message = "";
            StringBuilder sb = new StringBuilder("the" + name + message, 40);
            switch (name)
            {
                case "index":
                    message = "Out of range";
                    throw new ArgumentOutOfRangeException(name, sb.ToString());
                    break;
                case "value":
                    message = "Capacity is too small";
                    throw new ArgumentOutOfRangeException(name, sb.ToString());
                    break;
                case "capacity":
                    message = "can not Null";
                    throw new ArgumentOutOfRangeException(name, sb.ToString());
                    break;
                default:
                    break;
            }
        }
    }
}
