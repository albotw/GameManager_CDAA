using projet_CDAA_2020_2021.core.sort;
using System;
using System.Collections.Generic;

namespace projet_CDAA_2020_2021.core.jeux
{
    public class JeuRetro : Jeu, IFieldComparable<JeuRetro>
    {
        //TODO: vériifer l'implémentation dans le programme.

        private string etat;
        public string Etat { get => etat; set => etat = value; }

        private bool notice;
        public bool Notice { get => notice; set => notice = value; }

        //private List<Image> photos;

        public JeuRetro() : base()
        {
            this.etat = "";
            this.notice = true;
        }

        public JeuRetro(string nom, string description, string plateforme, string editeur, Genre genre, double prix, DateTime sortie, bool reconditionne, string etat, bool notice) : base(nom, description, plateforme, editeur, genre, prix, sortie, reconditionne)
        {
            this.etat = etat;
            this.notice = notice;
        }

        public override string ToString()
        {
            string s = base.ToString();

            s += "\nétat: " + this.etat;
            s += "\nnotice: " + (this.notice == true ? "présente" : "abstente");

            return s;
        }

        public override List<string> ToStringArray()
        {
            List<String> output = base.ToStringArray();

            output.Add(etat);
            output.Add(notice ? "oui" : "non");

            return output;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(JeuRetro))
            {
                JeuRetro oAsJR = obj as JeuRetro;
                return (this.etat == oAsJR.etat
                    && this.notice == oAsJR.notice);
            }
            else 
                return base.Equals(obj);
        }

        //TODO: tests
        public int CompareFieldTo(Field field, JeuRetro other)
        {
            if (other != null)
            {
                base.CompareFieldTo(field, other);

                if (field == FieldJeu.Etat) return this.Etat.CompareTo(other.Etat);
                else if (field == FieldJeu.Notice) return this.Notice.CompareTo(other.Notice);
            }
            return -1;
        }

        public static bool operator ==(JeuRetro j1, JeuRetro j2)
        {
            return j1 is null ? j2 is null : j1.Equals(j2);
        }

        public static bool operator !=(JeuRetro j1, JeuRetro j2)
        {
            return !(j1 == j2);
        }
    }
}
