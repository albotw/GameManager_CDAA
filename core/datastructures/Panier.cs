using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.jeux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core.datastructures
{
    public class Panier<T> where T: IEquatable<T>, IComparable<T>
    {
        private readonly T[] tab;
        private readonly int MAX_SIZE = 50;
        public int size;

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

        public T[] GetAll()
        {
            return tab;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
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

        public T Find(T equiv)
        {
            for (int i = 0; i < size; i++)
            {
                if (tab[i].Equals(equiv))
                    return tab[i];
            }
            return default(T);
        }

        public T Get(int index)
        {
            if (index < size)
            {
                return tab[index];
            }
            else
            {
                return default(T);
            }
        }

        public void Remove(T obj)
        {
            for(int i = 0; i < size; i++)
            {
                if (tab[i].Equals(obj))
                {
                    tab[i] = default;
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
                    tab[i + 1] = default;
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
