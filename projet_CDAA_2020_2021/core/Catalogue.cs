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

        public List<Jeu> getAll(string property, object arg)
        {
            return lesJeux.Search(property, arg);
        }

        public Jeu getJeu(string name)
        {
            return getJeu(name);
        }

        public List<Jeu> Sort(string field, bool reverse)
        {
            return lesJeux.Sort(field, reverse);
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
