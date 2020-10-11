using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.datastructures
{
    class Panier<T> where T: IEquatable<T>, IComparable<T>
    {
        private T[] tab;
        private int MAX_SIZE = 50;
        private int size;

        public Panier()
        {
            this.tab = new T[MAX_SIZE];
            this.size = 0;
        }

        public Panier(T[] tab)
        {
            if (tab.Length < MAX_SIZE)
            {
                this.tab = tab;
                this.size = tab.Length;
            }
            else
            {
                throw new IndexOutOfRangeException("Plus de place dans le panier !");
            }
        }

        public void Add(T obj) //tester les doublons.
        {
            if (this.size + 1 >= MAX_SIZE)
            {
                throw new IndexOutOfRangeException("Plus de place dans le panier !");
            }
            else
            {
                bool shouldAdd = true;
                foreach(T tmp in tab)
                {
                    if (tmp.Equals(obj))
                        shouldAdd = false;
                }

                if (shouldAdd)
                    tab[size] = obj;
                    size++;
            }
        }

        public void Sort()
        {
            //utilisation du tri par selection
            for (int i = 0; i < size - 1; i++)
            {
                int v = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (tab[j].CompareTo(tab[v]) > 0)
                    {
                       v = j;
                    }

                }
                var end = tab[i];
                tab[i] = tab[v];
                tab[v] = end;
            }
        }
        

        public void Remove(T obj)
        {
            for(int i = 0; i < size; i++)
            {
                if (tab[i].Equals(obj))
                {
                    tab[i] = default(T);
                    size--;
                    i = size;
                }
            }
        }
    }
}
