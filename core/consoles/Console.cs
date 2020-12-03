using projet_CDAA_2020_2021.core.sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core.consoles
{
    public class Console : IEquatable<Console>, IComparable<Console>, IFieldComparable<Console>
    {
        private string nom;
        public string Nom { get => nom; set => nom = value; }

        private string fabriquant;
        public string Fabriquant { get => fabriquant; set => fabriquant = value; }

        private int generation;
        public int Generation { get => generation; set => generation = value; }

        private DateTime sortie;
        public DateTime Sortie { get => sortie; set => sortie = value; }

        private int ports;
        public int Ports { get => ports; set => ports = value; }

        private Support support;
        public Support Support { get => support; set => support = value; }

        private string type;
        public string Type { get => type; set => type = value; }

        private double prix;
        public double Prix { get => prix; set => prix = value; }

        public Console()
        {
            this.nom = "";
            this.fabriquant = "";
            this.generation = 0;
            this.sortie = DateTime.Now;
            this.ports = 0;
            this.Support = 0;
            this.type = "";
            this.prix = 0.0;
        }

        public Console(string nom)
        {
            this.nom = nom;
        }

        public Console(string nom, string fabriquant, int generation, DateTime sortie, int ports, Support sup, string type, double prix)
        {
            this.nom = nom;
            this.fabriquant = fabriquant;
            this.generation = generation;
            this.sortie = sortie;
            this.ports = ports;
            this.support = sup;
            this.type = type;
            this.prix = prix;
        }

        public override string ToString()
        {
            string s = "";
            s += "\nnom: " + this.nom;
            s += "\nfabriquant: " + this.fabriquant;
            s += "\ngeneration: " + this.generation;
            s += "\nsortie: " + this.sortie;
            s += "\nports: " + this.ports;
            s += "\nsupport: " + this.support;
            s += "\ntype: " + this.type;
            s += "\nprix: " + this.prix;

            return s;
        }

        public List<string> ToStringArray()
        {
            List<string> output = new List<string>
            {
                nom,
                fabriquant,
                "" + generation,
                sortie.ToString("d", new System.Globalization.CultureInfo("fr-FR")),
                "" + ports,
                support.ToString(),
                type,
                prix.ToString()
            };

            return output;
        }

        /*
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Console tmp = obj as Console;
                return (this.nom == tmp.Nom
                    && this.fabriquant == tmp.Fabriquant
                    && this.generation == tmp.Generation)
            }
            return false;
        }
        */

        public bool Equals (Console other)
        {
            if (other != null)
                return (this.nom == other.Nom);
            else
                return false;
        }

        public int CompareTo(Console other)
        {
            if (other == null)
                return 1;
            else
                return this.nom.CompareTo(other.nom);
        }

        public int CompareFieldTo(Field field, Console other)
        {
            if (other != null)
            {
                if (field == FieldConsole.Nom) return this.Nom.CompareTo(other.Nom);
                else if (field == FieldConsole.Fabriquant) return this.Fabriquant.CompareTo(other.Fabriquant);
                else if (field == FieldConsole.Generation) return this.Generation.CompareTo(other.Generation);
                else if (field == FieldConsole.Sortie) return this.Sortie.CompareTo(other.Sortie);
                else if (field == FieldConsole.Ports) return this.Ports.CompareTo(other.Ports);
                else if (field == FieldConsole.Support) return this.Support.CompareTo(other.Support);
                else if (field == FieldConsole.Type) return this.Type.CompareTo(other.Type);
                else if (field == FieldConsole.Prix) return this.Prix.CompareTo(other.Prix);
            }
            return 1;
        }

        public static bool operator == (Console c1, Console c2)
        {
            return c1 is null ? c2 is null : c1.Equals(c2);
        }
        
        public static bool operator != (Console c1, Console c2)
        {
            return !(c1 == c2);
        }
    }
}
