using System;
using System.Collections.Generic;

namespace projet_CDAA_2020_2021.core
{
    public class Catalogue
    {
        private Jeux lesJeux;
        private DateTime lastUpdate;

        public Catalogue()
        {
            lesJeux = new Jeux();
            lastUpdate = DateTime.Now;
        }

        public void Add(Jeu j)
        {
            lesJeux.Add(j);
        }

        public void Remove(Jeu j)
        {
            lesJeux.Remove(j);
        }

        public List<Jeu> Search(string property, object arg)
        {
            return lesJeux.Search(property, arg);
        }

        public void Sort(string field, bool reverse)
        {
            lesJeux.Sort(field, reverse);
            //return lesJeux.Sort(field, reverse);
        }

        public void Init()
        {
            lesJeux.Init();
        }

        public Jeux getJeux()
        {
            return this.lesJeux;
        }
    }
}
