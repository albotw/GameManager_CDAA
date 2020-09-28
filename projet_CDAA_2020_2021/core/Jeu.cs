using System;

namespace projet_CDAA_2020_2021.core
{
    public class Jeu : IEquatable<Jeu>, IComparable<Jeu>
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

        public override string ToString()
        {
            string s = "";
            s += "\nnom: " + this.nom;
            s += "\ndescription: " + this.description;
            s += "\nplateforme: " + this.plateforme;
            s += "\nediteur: " + this.editeur;
            s += "\ngenre: " + Enum.GetName(typeof(Genre), this.genre);
            s += "\nprix: " + this.prix + " euros";
            s += "\nsortie: " + this.sortie.ToString("F", new System.Globalization.CultureInfo("fr-FR"));
            s += "\nreconditionné: " + (this.reconditionne == true ? "oui" : "non");

            return s;
        }

        public virtual void input2()
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

            Console.Write("reconditionné ? (oui | non) "); this.reconditionne = (Console.ReadLine() == "oui" ? true : false);
        }

        public virtual void input()
        {
            
            Program.cli.WriteMiddle("nom ?", 10);
            Console.CursorVisible = true;
            Console.SetCursorPosition(110, 11);
            this.nom = Console.ReadLine();



            Program.cli.WriteMiddle("description ? ", 10); this.description = Console.ReadLine();
            Program.cli.WriteMiddle("plateforme ? ", 10); this.plateforme = Console.ReadLine();
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

            Console.Write("reconditionné ? (oui | non) "); this.reconditionne = (Console.ReadLine() == "oui" ? true : false);
        }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Jeu tmp = obj as Jeu;
                return (this.nom == tmp.nom
                    && this.plateforme == tmp.plateforme
                    && this.reconditionne == tmp.reconditionne
                    && this.prix == tmp.prix);
            }
            return false;
        }


        public override int GetHashCode()
        {
            //return HashCode.Combine(nom, description, plateforme, editeur, genre, prix, sortie, reconditionne);
            return 0;
        }

        public bool Equals(Jeu other)
        {
            if (other == null)
            {
                return false;
            }
            else
            {
                return (other.nom == this.nom
                    && other.Plateforme == this.plateforme
                    && other.reconditionne == this.reconditionne
                    && other.prix == this.prix);
            }
        }

        public int CompareTo(Jeu other)
        {
            if (other == null) return 1;
            else return this.nom.CompareTo(other.nom);
        }

        public static bool operator== (Jeu j1, Jeu j2)
        {
            if ((Object)j1 == null)
                return (Object)j2 == null;
            else
                return j1.Equals(j2);
        }

        public static bool operator!= (Jeu j1, Jeu j2)
        {
            return !(j1 == j2);
        }
    }
}
