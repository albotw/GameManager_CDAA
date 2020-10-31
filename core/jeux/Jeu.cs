using System;
using System.Collections.Generic;
using System.Drawing;
using projet_CDAA_2020_2021.core.sort;

namespace projet_CDAA_2020_2021.core.jeux
{
    public class Jeu : IEquatable<Jeu>, IComparable<Jeu>, IFieldComparable<Jeu>
    {
        private string nom;
        public string Nom { get => nom; set => nom = value; }

        private string description;
        public string Description { get => description; set => description = value; }

        private string plateforme;
        public string Plateforme { get => plateforme; set => plateforme = value; }

        private string editeur;
        public string Editeur { get => editeur; set => editeur = value; }

        private Genre genre;
        public Genre Genre { get => genre; set => genre = value; }

        private double prix;
        public double Prix { get => prix; set => prix = value; }

        private DateTime sortie;
        public DateTime Sortie { get => sortie; set => sortie = value; }

        private bool reconditionne;

        public bool Reconditionne { get => reconditionne; set => reconditionne = value; }

        private Image photo;
        public Image Photo { get => photo; set => photo = value;  }

        public Jeu()
        {
            this.nom = "";
            this.description = "";
            this.plateforme = "";
            this.editeur = "";
            this.genre = 0;
            this.prix = 0.0;
            this.sortie = DateTime.Now;
            this.reconditionne = false;
        }

        public Jeu(string nom, string desc, string plateforme, string editeur, Genre g, double prix, DateTime sortie, bool reconditionne)
        {
            this.nom = nom;
            this.description = desc;
            this.plateforme = plateforme;
            this.editeur = editeur;
            this.genre = g;
            this.prix = prix;
            this.sortie = sortie;
            this.reconditionne = reconditionne;
        }

        public Jeu(string nom)
        {
            this.nom = nom;
        }

        public override string ToString()
        {
            string s = "";
            s += "\nnom: " + this.nom;
            s += "\ndescription: " + this.description;
            s += "\nplateforme: " + this.plateforme;
            s += "\nediteur: " + this.editeur;
            s += "\ngenre: " + Enum.GetName(typeof(Genre), this.genre);
            s += "\nprix: " + this.prix + " euros";
            s += "\nsortie: " + this.sortie.ToString("d", new System.Globalization.CultureInfo("fr-FR"));
            s += "\nreconditionné: " + (this.reconditionne == true ? "oui" : "non");

            return s;
        }

        //pour affichage dans une CLITable
        public virtual List<string> ToStringArray()
        {
            List<string> output = new List<string>
            {
                nom,
                description,
                plateforme,
                editeur,
                genre.ToString(),
                "" + prix,
                sortie.ToString("d", new System.Globalization.CultureInfo("fr-FR")),
                (this.reconditionne == true ? "oui" : "non")
            };

            return output;
        }

        //inutile car utilisation de la CLI
        public virtual void Input()
        {
            Console.Write("nom ?"); this.nom = Console.ReadLine();
            Console.Write("description ? "); this.description = Console.ReadLine();
            Console.Write("plateforme ? "); this.plateforme = Console.ReadLine();
            Console.Write("editeur ? "); this.editeur = Console.ReadLine();

            string tmp;
            Console.Write("Genre ? "); tmp = Console.ReadLine();
            this.genre = (Genre)Enum.Parse(typeof(Genre), tmp, true);

            Console.Write("prix ? "); this.prix = Double.Parse(Console.ReadLine());

            int jour, mois, annee;
            Console.Write("Date de sortie (j, m, a) ? ");
            jour = Int32.Parse(Console.ReadLine());
            mois = Int32.Parse(Console.ReadLine());
            annee = Int32.Parse(Console.ReadLine());
            this.sortie = new DateTime(annee, mois, jour);

            Console.Write("reconditionné ? (oui | non) "); this.reconditionne = (Console.ReadLine() == "oui");
        }

        //? méthode Equals de IEquatable
        public bool Equals(Jeu other)
        {
            if (other == null)
            {
                return false;
            }
            else
            {
                return (this.nom.Equals(other.Nom));
            }
        }

        //? méthode CompareFieldTo de IComparable (classification par défaut)
        public int CompareTo(Jeu other)
        {
            if (other == null) 
                return 0;
            else 
                return this.nom.CompareTo(other.Nom);
        }

        //? méthode CompareFieldTo de IFieldComparison (classification par d'autres champs).
        public int CompareFieldTo(Field field, Jeu other)
        {
            if (other != null)
            {
                if      (field == FieldJeu.Nom)             return this.nom.CompareTo(other.Nom);
                else if (field == FieldJeu.Description)     return this.description.CompareTo(other.description);
                else if (field == FieldJeu.Plateforme)      return this.Plateforme.CompareTo(other.Plateforme);
                else if (field == FieldJeu.Editeur)         return this.Editeur.CompareTo(other.Editeur);
                else if (field == FieldJeu.Genre)           return this.Genre.CompareTo(other.Genre);
                else if (field == FieldJeu.Prix)            return this.Prix.CompareTo(other.Prix);
                else if (field == FieldJeu.Sortie)          return this.Sortie.CompareTo(other.Sortie);
                else if (field == FieldJeu.Reconditionne)   return this.Reconditionne.CompareTo(other.Reconditionne);
            }

            return -1;
        }

        // pour pouvoir faire j1 == j2
        public static bool operator ==(Jeu j1, Jeu j2)
        {
            return j1 is null ? j2 is null : j1.Equals(j2);
        }

        //pour pouvoir faire j1 != j2
        public static bool operator !=(Jeu j1, Jeu j2)
        {
            return !(j1 == j2);
        }
    }
}
