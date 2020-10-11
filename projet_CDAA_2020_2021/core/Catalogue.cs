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

        public void Add(object o)
        {
            if (o.GetType() == typeof(Jeu) || o.GetType() == typeof(JeuRetro))
                lesJeux.Add(o as Jeu);
            else if (o.GetType() == typeof(Accessoire))
                lesAccessoires.Add(o as Accessoire);
        }

        public void Remove(object o)
        {
            if (o.GetType() == typeof(Jeu) || o.GetType() == typeof(JeuRetro))
                lesJeux.Add(o as Jeu);
            else if (o.GetType() == typeof(Accessoire));
                lesAccessoires.Remove( o as Accessoire);
        }

        public List<Jeu> Search(string property, object arg)
        {
            return lesJeux.Search(property, arg);
        }

        public void Sort(string categorie, string field, bool reverse)
        {
            if(categorie == "jeux")
                lesJeux.Sort(field, reverse);

            else if ( categorie == "Accessoire")
            {
                lesAccessoires.Sort(field, reverse);
            }
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
