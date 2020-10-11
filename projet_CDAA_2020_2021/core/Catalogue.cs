using System;
using System.Collections.Generic;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.core.accessoires;

namespace projet_CDAA_2020_2021.core
{
    public class Catalogue
    {
        private EnsembleJeux lesJeux;
       private EnsembleAccessoire lesAccessoires;

        private DateTime lastUpdate;

        public Catalogue()
        {
            lesJeux = new EnsembleJeux();
            lesAccessoires = new EnsembleAccessoire();

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
        }

        public void Init()
        {
            lesJeux.Init();
        }

        public EnsembleJeux GetEnsembleJeux()
        {
            return this.lesJeux;
        }

        public EnsembleAccessoire GetEnsembleAccessoires()
        {
            return this.lesAccessoires;
        }
    }
}
