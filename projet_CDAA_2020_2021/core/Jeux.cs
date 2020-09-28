using System;
using System.Collections.Generic;
using System.Text;

namespace projet_CDAA_2020_2021.core
{
    class Jeux
    {
        private DateTime lastUpdate;
        public DateTime LastUpdate { get => lastUpdate;}

        private List<Jeu> jeux;

        public Jeux()
        {
            jeux = new List<Jeu>();
            lastUpdate = DateTime.Now;
        }

        public void Init()
        {
            Add(new Jeu("Metal Gear Solid 2: Subsistance", "Un jeu de Hideo Kojima", "PC, PS2", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2003, 07, 14), false)); 
            Add(new Jeu("Metal Gear Solid", "Un jeu de Hideo Kojima", "PC, PS1, GameCube", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2000, 04, 21), false)); 
        }

        public void Add(Jeu j)
        {
            if (!jeux.Contains(j))
            {
                this.jeux.Add(j);
            this.lastUpdate = DateTime.Now;
            }
        }

        public void Remove(Jeu j)
        {
            this.jeux.Remove(j);
            this.lastUpdate = DateTime.Now;
        }

        public List<Jeu> getAll()
        {
            return this.jeux;
        }

        public List<Jeu> getAll(string property, object arg)
        {
            List<Jeu> tmp = new List<Jeu>();

            foreach(Jeu j in jeux)
            {
                switch(property)
                {
                    case "genre":
                        if (j.Genre == (Genre)arg)
                            tmp.Add(j);
                        break;

                    case "plateforme":
                        if (j.Plateforme == (string)arg)
                            tmp.Add(j);
                        break;

                    case "editeur":
                        if (j.Editeur == (string)arg)
                            tmp.Add(j);
                        break;

                    case "prix":
                        if (j.Prix == (double)arg)
                            tmp.Add(j);
                        break;

                    case "sortie":
                        if (j.Sortie == (DateTime)arg)
                            tmp.Add(j);
                        break;

                    case "reconditionne":
                        if (j.Reconditionne == (bool)arg)
                            tmp.Add(j);
                        break;

                    case "retro":
                        if (j.GetType().Equals(typeof(JeuRetro)))
                            tmp.Add(j);
                        break;
                }
            }

            return tmp;
        }

        public List<Jeu> getAll(Genre g)
        {
            List<Jeu> tmp = new List<Jeu>();
            foreach(Jeu j in jeux)
            {
                if (j.Genre == g)
                {
                    tmp.Add(j);
                }
            }

            return tmp;
        }

        public int Size()
        {
            return this.jeux.Count;
        }

        public Jeu getJeu(string name)
        {
            foreach(Jeu j in jeux)
            {
                if (j.Nom == name)
                {
                    return j;
                }
            }

            return null;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "\ndenière modification : " + lastUpdate.ToString("F", new System.Globalization.CultureInfo("fr-FR"));
            s += "\n Contenu:";
            foreach(Jeu j in jeux)
            {
                s += "\n\n" + j.ToString(); 
            }
            return s;
        }
    }
}
