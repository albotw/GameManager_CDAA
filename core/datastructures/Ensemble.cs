using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core.datastructures
{
    abstract public class Ensemble<T> where T : IFieldComparable<T>
    {
        protected DateTime lastUpdate;
        public DateTime LastUpdate { get => lastUpdate; }

        protected List<T> liste;

        public Ensemble()
        {
            this.liste = new List<T>();
            lastUpdate = DateTime.Now;
        }

        public Ensemble(List<T> l)
        {
            this.liste = l;
            lastUpdate = DateTime.Now;
        }

        public abstract void Init();

        public virtual void Add(T obj)
        {
            if (!liste.Contains(obj))
            {
                this.liste.Add(obj);
                this.lastUpdate = DateTime.Now;
            }
        }
        public void Remove(T obj)
        {
            this.liste.Remove(obj);
            this.lastUpdate = DateTime.Now;
        }

        public List<T> GetAll()
        {
            return this.liste;
        }

        public abstract List<T> Search(Field field, object arg);

        public void Sort(Field field, bool reverse)
        {
            QuickSort<T> qk = new QuickSort<T>();
            T[] tmp = liste.ToArray();
            qk.Sort(ref tmp, 0, tmp.Length - 1, field, reverse);
            this.liste = new List<T>(tmp);
        }

        public abstract List<string[]> ToStringArray();
    }
}
