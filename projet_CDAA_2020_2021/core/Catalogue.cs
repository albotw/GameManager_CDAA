using System;
using System.Collections.Generic;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.core.consoles;

namespace projet_CDAA_2020_2021.core
{
    public class Catalogue
    {
        private EnsembleJeux lesJeux;
        private EnsembleConsoles lesConsoles;

        private DateTime lastUpdate;

        public Catalogue()
        {
            lesJeux = new EnsembleJeux();
            lesConsoles = new EnsembleConsoles();

            lastUpdate = DateTime.Now;
        }

        public void Add(object o)
        {
            if (o.GetType() == typeof(Jeu) || o.GetType() == typeof(JeuRetro))
                lesJeux.Add(o as Jeu);
            else if (o.GetType() == typeof(consoles.Console))
                lesConsoles.Add(o as consoles.Console);
        }

        public void Remove(object o)
        {
            if (o.GetType() == typeof(Jeu) || o.GetType() == typeof(JeuRetro))
                lesJeux.Remove(o as Jeu);
            else if (o.GetType() == typeof(consoles.Console))
                lesConsoles.Remove(o as consoles.Console);
        }

        public List<Jeu> Search(string property, object arg)
        {
            return lesJeux.Search(property, arg);
        }

        public void Sort(string categorie, string field, bool reverse)
        {
            if (categorie == "jeux")
                lesJeux.Sort(field, reverse);
            else if (categorie == "consoles")
                lesConsoles.Sort(field, reverse);
            //return lesJeux.Sort(field, reverse);
        }

        public void Init()
        {
            lesJeux.Init();
            lesConsoles.Init();
        }

        public EnsembleJeux GetEnsembleJeux()
        {
            return this.lesJeux;
        }

        public EnsembleConsoles GetEnsembleConsoles()
        {
            return this.lesConsoles;
        }
    }
}
