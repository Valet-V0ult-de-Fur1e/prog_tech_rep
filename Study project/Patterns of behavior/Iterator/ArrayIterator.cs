using OOP.Patterns_of_behavior.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Patterns_of_behavior.Iterator
{
    internal class ArrayIterator<T> : Iterator<T>
    {
        private T[] items;
        private int index;

        public ArrayIterator(T[] items) {
            this.items = items;
            this.index = 0;
        }
        public bool hasNext()
        {
            return index < items.Length;
        }

        public T next()
        {
            if (hasNext())
            {
                return items[index++];
            }
            throw new Exception();
        }
    }
}
