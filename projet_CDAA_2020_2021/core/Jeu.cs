using System;

namespace projet_CDAA_2020_2021.core
{
    public class Jeu
    {
        public  string nom { get; set; }

        public string description { get; set; }

        public string plateforme { get; set; }

        public string editeur { get; set; }

        public Genre genre { get; set; }

        public double prix { get; set; }

        public DateTime sortie { get; set; }

        public bool reconditionne { get; set; }

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

        public override String ToString()
        {
            string s = "";
            s += "\nnom: " + this.nom;
            s += "\ndescription: " + this.description;
            s += "\nplateforme: " + this.plateforme;
            s += "\nediteur: " + this.editeur;
            s += "\ngenre: " + Enum.GetName(typeof(Genre), this.genre);
            s += "\nprix: " + this.prix;
            s += "\nsortie: " + this.sortie.ToLongDateString();
            s += "\nreconditionné: " + this.reconditionne;

            return s;
        }

        public void input()
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

            Console.Write("reconditionné ? (true | false) "); this.reconditionne = Boolean.Parse(Console.ReadLine());
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
