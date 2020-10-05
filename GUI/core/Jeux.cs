using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace projet_CDAA_2020_2021.core
{
    public class Jeux
    {
        private DateTime lastUpdate;
        public DateTime LastUpdate { get => lastUpdate; }

        private List<Jeu> liste;

        public Jeux()
        {
            liste = new List<Jeu>();
            lastUpdate = DateTime.Now;
        }

        public Jeux(List<Jeu> liste)
        {
            this.liste = liste;
            lastUpdate = DateTime.Now;
        }

        public void Init()
        {
            Add(new Jeu("Metal Gear Solid 2: Subsistance", "Un jeu de Hideo Kojima", "PC, PS2", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2003, 07, 14), false));
            Add(new Jeu("Metal Gear Solid", "Un jeu de Hideo Kojima", "PC, PS1, GameCube", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2000, 04, 21), false));
            Add(new Jeu("Metal Gear Solid V: The Phantom Pain", "Un jeu de Hideo Kojima", "PC, PS4, PS3", "Konami avec Hideo Kojima", Genre.Infiltration, 50.00, new DateTime(2013, 08, 22), false));
            Add(new Jeu("Dragon Ball: Fighter Z", "JAPOOON", "PC, PS4, XBOX ONE", "Akira Toriyama", Genre.Combat, 40.00, new DateTime(2017, 05, 13), false));
            Add(new Jeu("Minecraft RTX Edition", "Enfin des graphismes sympas", "PC", "Microsoft, Mojang", Genre.Aventure, 25.00, new DateTime(2018, 10, 12), false));
            Add(new Jeu("Genshin Impact", "Copier Coller de Zelda BotW mais en moins bien", "PC, PS4, iOS, Android", "MiHoYo", Genre.Action_RPG, 0.00, new DateTime(2020, 09, 25), false));
        }

        public void Add(Jeu j)
        {
            if (!liste.Contains(j))
            {
                this.liste.Add(j);
                this.lastUpdate = DateTime.Now;
            }
        }

        public void Remove(Jeu j)
        {
            this.liste.Remove(j);
            this.lastUpdate = DateTime.Now;
        }

        public List<Jeu> Search()
        {
            return this.liste;
        }

        public List<Jeu> Search(string property, object arg)
        {
            List<Jeu> tmp = new List<Jeu>();

            foreach (Jeu j in liste)
            {
                switch (property)
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

        public List<Jeu> Sort(string field, bool reverse)
        {
            QuickSort<Jeu> qk = new QuickSort<Jeu>();
            Jeu[] tmp = liste.ToArray();
            qk.Sort(ref tmp, 0, liste.Count - 1, field, reverse);
            return new List<Jeu>(tmp);
        }

        public int Size()
        {
            return this.liste.Count;
        }

        public Jeu getJeu(string name)
        {
            foreach (Jeu j in liste)
            {
                if (j.Nom == name)
                {
                    return j;
                }
            }

            return null;
        }

        public List<string> getNames()
        {
            List<string> output = new List<string>();
            foreach(Jeu j in liste)
            {
                output.Add(j.Nom);
            }

            return output;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "\ndenière modification : " + lastUpdate.ToString("F", new System.Globalization.CultureInfo("fr-FR"));
            s += "\n Contenu:";
            foreach (Jeu j in liste)
            {
                s += "\n\n" + j.ToString();
            }
            return s;
        }
    }
}
