using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core.jeux
{
    //Classe ayant le même usage qu'une énumération mais avec des strings, chose incompatible avec une énum normale.
    public class FieldJeu : Field
    {
        private FieldJeu(string value) : base(value)
        { }

        /*opérateurs de cast implicite et explicite depuis et vers un string*/
        public static explicit operator string(FieldJeu f) { return f.Value; }
        public static explicit operator FieldJeu(string s) { return new FieldJeu(s); }

        public static string[] GetNames()
        {
            return new string[]
            {
                Nom.Value,
                Description.Value,
                Plateforme.Value,
                Editeur.Value,
                Genre.Value,
                Prix.Value,
                Sortie.Value,
                Reconditionne.Value,
                Photo.Value,
                Retro.Value,
                Etat.Value,
                Notice.Value
            };
        }

        //Champs JEU
        public static FieldJeu Nom { get { return new FieldJeu("nom"); } }
        public static FieldJeu Description { get { return new FieldJeu("description"); } }
        public static FieldJeu Plateforme { get { return new FieldJeu("plateforme"); } }
        public static FieldJeu Editeur { get { return new FieldJeu("editeur"); } }
        public static FieldJeu Genre { get { return new FieldJeu("genre"); } }
        public static FieldJeu Prix { get { return new FieldJeu("prix"); } }
        public static FieldJeu Sortie { get { return new FieldJeu("sortie"); } }
        public static FieldJeu Reconditionne { get { return new FieldJeu("reconditionne"); } }
        public static FieldJeu Photo { get { return new FieldJeu("photo"); } }

        //Champs JEU RETRO
        public static FieldJeu Retro { get { return new FieldJeu("jeuretro"); } }
        public static FieldJeu Etat { get { return new FieldJeu("etat"); } }
        public static FieldJeu Notice { get { return new FieldJeu("notice"); } }
    }
}
