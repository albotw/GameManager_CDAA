using projet_CDAA_2020_2021.datastructures;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using GUI;

namespace projet_CDAA_2020_2021.core.jeux
{
    public class EnsembleJeux : Ensemble<Jeu>
    {
        public EnsembleJeux() : base()
        {}

        public EnsembleJeux(List<Jeu> liste) : base (liste)
        { }

        public override void Init()
        {
            Add(new Jeu("Metal Gear Solid 2: Subsistance", "Un jeu de Hideo Kojima", "PC, PS2", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2003, 07, 14), false, GUI.Properties.Resources.MGS2));
            Add(new Jeu("Metal Gear Solid", "Un jeu de Hideo Kojima", "PC, PS1, GameCube", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2000, 04, 21), false, GUI.Properties.Resources.MGS1));
            Add(new Jeu("Metal Gear Solid V: The Phantom Pain", "Un jeu de Hideo Kojima", "PC, PS4, PS3", "Konami avec Hideo Kojima", Genre.Infiltration, 50.00, new DateTime(2013, 08, 22), false, GUI.Properties.Resources.MGSV));
            Add(new Jeu("Dragon Ball: Fighter Z", "JAPOOON", "PC, PS4, XBOX ONE", "Akira Toriyama", Genre.Combat, 40.00, new DateTime(2017, 05, 13), false, GUI.Properties.Resources.DBFZ));
            Add(new Jeu("Minecraft RTX Edition", "Enfin des graphismes sympas", "PC", "Microsoft, Mojang", Genre.Aventure, 25.00, new DateTime(2018, 10, 12), false, GUI.Properties.Resources.MC_RTX));
            Add(new Jeu("Genshin Impact", "Copier Coller de Zelda BotW", "PC, PS4, iOS, Android", "MiHoYo", Genre.Action_RPG, 0.00, new DateTime(2020, 09, 25), false, GUI.Properties.Resources.GENSHIN));
            Add(new JeuRetro("Mario Bros 3", "Un clasiqque des jeux de plateforme", "Super NES", "Nintendo", Genre.Plateforme, 40.00, new DateTime(1991, 11, 30), false, "presque neuf", true, GUI.Properties.Resources.SMB3));
        }

        public override List<Jeu> Search(string property, object arg)
        {
            List<Jeu> tmp = new List<Jeu>();

            foreach (Jeu j in liste)
            {
                switch (property)
                {
                    case "nom":
                        if (j.Nom == (string)arg)
                            tmp.Add(j);
                        break;
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

        public override List<string[]> ToStringArray()
        {
            List<string[]> output = new List<string[]>();
            foreach(Jeu j in liste)
            {

                output.Add(j.ToStringArray().ToArray());
            }

            return output;
        }

        //Inutile pour le moment.
        /*
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
        }*/
    }
}
