using projet_CDAA_2020_2021.core.datastructures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

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
            Add(new Jeu("Metal Gear Solid 2: Subsistance", "Un jeu de Hideo Kojima", "PC, PS2", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2003, 07, 14), false));
            Add(new Jeu("Metal Gear Solid", "Un jeu de Hideo Kojima", "PC, PS1, GameCube", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2000, 04, 21), false));
            Add(new Jeu("Metal Gear Solid V: The Phantom Pain", "Un jeu de Hideo Kojima", "PC, PS4, PS3", "Konami avec Hideo Kojima", Genre.Infiltration, 50.00, new DateTime(2013, 08, 22), false));
            Add(new Jeu("Dragon Ball: Fighter Z", "JAPOOON", "PC, PS4, XBOX ONE", "Akira Toriyama", Genre.Combat, 40.00, new DateTime(2017, 05, 13), false));
            Add(new Jeu("Minecraft RTX Edition", "Enfin des graphismes sympas", "PC", "Microsoft, Mojang", Genre.Aventure, 25.00, new DateTime(2018, 10, 12), false));
            Add(new Jeu("Genshin Impact", "Copier Coller de Zelda BotW", "PC, PS4, iOS, Android", "MiHoYo", Genre.Action_RPG, 0.00, new DateTime(2020, 09, 25), false));
            Add(new JeuRetro("Mario Bros 3", "Un clasiqque des jeux de plateforme", "Super NES", "Nintendo", Genre.Plateforme, 40.00, new DateTime(1991, 11, 30), false, "presque neuf", true));
        }

        //TODO: vérifier les cast dans les appels a search, surtout les DateTime.
        //TODO: Faire en sorte que les recherches soient plus flexibles, entre autre utiliser Contains au lieu de == pour les strings.
        public override List<Jeu> Search(Field field, string arg)
        {
            List<Jeu> tmp = new List<Jeu>();

            foreach (Jeu j in liste)
            {
                if (field == FieldJeu.Nom && j.Nom == arg)
                    tmp.Add(j);

                else if (field == FieldJeu.Genre)
                {
                    Genre g = (Genre)Enum.Parse(typeof(Genre), arg);
                    if (j.Genre == g)
                        tmp.Add(j);
                }
                
                //TODO: retirer car test virtuellement toujours faux.
                else if (field == FieldJeu.Description && j.Description == arg)
                    tmp.Add(j);

                else if (field == FieldJeu.Plateforme && j.Plateforme ==arg)
                    tmp.Add(j);

                else if (field == FieldJeu.Editeur && j.Editeur == arg)
                    tmp.Add(j);

                else if (field == FieldJeu.Prix)
                {
                    double p = Double.Parse(arg);
                    if (j.Prix == p)
                        tmp.Add(j);
                }

                else if (field == FieldJeu.Sortie)
                {
                    //date au format jj/mm/aaaa, tout autre format provoquera une exception
                    string[] date_values = arg.Split('/');
                    DateTime d = new DateTime(Int32.Parse(date_values[2]), Int32.Parse(date_values[1]), Int32.Parse(date_values[0]));
                    if (j.Sortie == d)
                        tmp.Add(j);
                }

                else if (field == FieldJeu.Reconditionne)
                {
                    bool r = Boolean.Parse(arg);
                    if (j.Reconditionne == r)
                        tmp.Add(j);
                }

                //TODO: retirer les photos car test impossible.
                //else if (field == FieldJeu.Photo && j.Photo == (Image)arg)
                    //tmp.Add(j);

                else if (field == FieldJeu.Retro && j.GetType().Equals(typeof(JeuRetro)))
                    tmp.Add(j);

                //pas sur que ça fonctionne
                else if (field == FieldJeu.Etat && j.GetType().Equals(typeof(JeuRetro)))
                {
                    if ((j as JeuRetro).Etat == arg)
                        tmp.Add(j);

                }

                else if (field == FieldJeu.Notice && j.GetType().Equals(typeof(JeuRetro)))
                {
                    bool n = Boolean.Parse(arg);
                    if ((j as JeuRetro).Notice == n)
                        tmp.Add(j);
                }
            }
            return tmp;
        }

        public override Jeu SearchSingle(Field field, string arg)
        {
            foreach(Jeu j in liste)
            {
                if (field == FieldJeu.Nom && j.Nom == arg)
                    return j;

                else if (field == FieldJeu.Genre)
                {
                    Genre g = (Genre)Enum.Parse(typeof(Genre), arg);
                    if (j.Genre == g)
                        return j;
                }

                //TODO: retirer car test virtuellement toujours faux.
                else if (field == FieldJeu.Description && j.Description == arg)
                    return j;

                else if (field == FieldJeu.Plateforme && j.Plateforme == arg)
                    return j;

                else if (field == FieldJeu.Editeur && j.Editeur == arg)
                    return j;

                else if (field == FieldJeu.Prix)
                {
                    double p = Double.Parse(arg);
                    if (j.Prix == p)
                        return j;
                }

                else if (field == FieldJeu.Sortie)
                {
                    //date au format jj/mm/aaaa, tout autre format provoquera une exception
                    string[] date_values = arg.Split('/');
                    DateTime d = new DateTime(Int32.Parse(date_values[2]), Int32.Parse(date_values[1]), Int32.Parse(date_values[0]));
                    if (j.Sortie == d)
                        return j;
                }

                else if (field == FieldJeu.Reconditionne)
                {
                    bool r = Boolean.Parse(arg);
                    if (j.Reconditionne == r)
                        return j;
                }

                //TODO: retirer les photos car test impossible.
                //else if (field == FieldJeu.Photo && j.Photo == (Image)arg)
                //tmp.Add(j);

                else if (field == FieldJeu.Retro && j.GetType().Equals(typeof(JeuRetro)))
                    return j;

                //pas sur que ça fonctionne
                else if (field == FieldJeu.Etat && j.GetType().Equals(typeof(JeuRetro)))
                {
                    if ((j as JeuRetro).Etat == arg)
                        return j;

                }

                else if (field == FieldJeu.Notice && j.GetType().Equals(typeof(JeuRetro)))
                {
                    bool n = Boolean.Parse(arg);
                    if ((j as JeuRetro).Notice == n)
                        return j;
                }
            }

            return null;
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

        public override List<string> GetAllNames()
        {
            List<string> output = new List<string>();

            foreach(Jeu j in liste)
            {
                output.Add(j.Nom);
            }

            return output;
        }
    }
}
