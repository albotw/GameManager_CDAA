using System;
using System.Collections.Generic;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.core.consoles;

namespace projet_CDAA_2020_2021.core
{
    public class Catalogue
    {
        private EnsembleJeux lesJeux;
        private DateTime lastUpdate;

        public Catalogue()
        {
            lesJeux = new EnsembleJeux();
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

        public EnsembleJeux getJeux()
        {
            return this.lesJeux;
        }
    }
}
