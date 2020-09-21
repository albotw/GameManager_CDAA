using System;
using System.Collections.Generic;
using projet_CDAA_2020_2021.core;

namespace projet_CDAA_2020_2021.console
{
    public class Catalogue
    {
        protected DateTime lastUpdate { get; set; }

        protected List<Jeu> lj;

        public Catalogue()
        {
            this.lastUpdate = DateTime.Now;
            this.lj = new List<Jeu>();
        }

        public Catalogue(DateTime lastUpdate, List<Jeu> lj)
        {
            this.lastUpdate = lastUpdate;
            this.lj = lj ?? throw new ArgumentNullException(nameof(lj));
        }

        public void add(Jeu j)
        {
            this.lj.Add(j);
            this.lastUpdate = DateTime.Now;
        }

        public void delete(Jeu j)
        {
            this.lj.Remove(j);
            this.lastUpdate = DateTime.Now;
        }

        public List<Jeu> getJeux()
        {
            return this.lj;
        }

        public Jeu getJeu(string name)
        {
            Jeu tmp = null;
            foreach(Jeu j in lj)
            {
                if (j.nom == name)
                {
                    tmp = j;
                }
            }

            return tmp;
        }

        public List<Jeu> getJeux(Genre g)
        {
            List<Jeu> tmp = new List<Jeu>();

            foreach(Jeu j in lj)
            {
                if (j.genre == g)
                {
                    tmp.Add(j);
                }
            }

            return tmp;
        }

        public override string ToString()
        {
            string s = "";
            s += "\ndernière modification: " + lastUpdate.ToString();
            s += "\njeux: ";
            foreach(Jeu j in lj)
            {
                s += "\n[JEU] " + j.ToString();
            }
            
            return s;
        }
    }

}
