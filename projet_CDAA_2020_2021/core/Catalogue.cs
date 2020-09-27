using System;
using System.Collections.Generic;

namespace projet_CDAA_2020_2021.core
{
    public class Catalogue
    {
        private Jeux jeux;
        private DateTime lastUpdate;

        public Catalogue()
        {
            jeux = new Jeux();
            lastUpdate = DateTime.Now;
        }

        public void Add(Jeu j)
        {
            jeux.Add(j);
        }

        public void Remove(Jeu j)
        {
            jeux.Remove(j);
        }

        public List<Jeu> getAll(string property, object arg)
        {
            return jeux.getAll(property, arg);
        }

        public Jeu getJeu(string name)
        {
            return getJeu(name);
        }
    }
}
