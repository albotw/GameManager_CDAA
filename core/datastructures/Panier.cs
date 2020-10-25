using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.jeux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.datastructures
{
    public class Panier<T> where T: IEquatable<T>, IComparable<T>
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
                    if (tmp != null && tmp.Equals(obj))
                        shouldAdd = false;
                }

                if (shouldAdd)
                    tab[size] = obj;
                    size++;
            }
        }

        public void Sort()
        {
            //tri a bulle naif

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j < size - i-1; j++)
                {
                    if (tab[j].CompareTo(tab[j + 1]) > 0)
                    {
                        T tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                    }
                }
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

            Defrag();
        }

        private void Defrag()
        {
            for (int i = 0; i <= size; i++)
            {
                if (tab[i] == null)
                {
                    tab[i] = tab[i + 1];
                    tab[i + 1] = default(T);
                }
            }
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < size; i++)
            {
                if (tab[i] != null)
                {
                    s += tab[i].ToString() + "\n";
                }
            }

            return s;
        }
    }
}
