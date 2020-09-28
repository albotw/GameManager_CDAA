using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.datastructures
{
    class Ensemble<T>
    {
        private T[] tab;
        private int capacity;
        private int size;

        public Ensemble(int size)
        {
            this.tab = new T[size];
            this.size = 0;
            this.capacity = size;
        }

        public void Add(T item)
        {
            if (size == capacity)
            {
                Array.Resize<T>(ref this.tab, capacity * 2);
                capacity *= 2;
            }

            tab[size] = item;
            size++;
        }

        public void Remove(T item, int index)
        {
            if (tab[index].Equals(item))
            {
                tab[index] = default(T);
                tab[index] = tab[index + 1];

            }
        }
    }
}
