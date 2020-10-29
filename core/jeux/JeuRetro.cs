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
        public int CompareFieldTo(string field, JeuRetro other)
        {
            if (other != null)
            {
                base.CompareFieldTo(field, other);
                switch (field)
                {
                    case "etat":
                        return this.etat.CompareTo(other.etat);
                    case "notice":
                        return this.notice.CompareTo(other.notice);
                    default:
                        return -1;
                }
            }
            else
            {
                return 1;
            }
        }

        public static bool operator ==(JeuRetro j1, JeuRetro j2)
        {
            if ((Object)j1 == null)
                return (Object)j2 == null;
            else
                return j1.Equals(j2);
        }

        public static bool operator !=(JeuRetro j1, JeuRetro j2)
        {
            return !(j1 == j2);
        }
    }
}
