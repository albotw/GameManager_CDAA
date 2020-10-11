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

        public Console()
        {
            this.nom = "";
            this.fabriquant = "";
            this.generation = 0;
            this.sortie = DateTime.Now;
            this.ports = 0;
            this.Support = 0;
            this.type = "";
        }

        public Console(string nom)
        {
            this.nom = nom;
        }

        public Console(string nom, string fabriquant, int generation, DateTime sortie, int ports, Support sup, string type)
        {
            this.nom = nom;
            this.fabriquant = fabriquant;
            this.generation = generation;
            this.sortie = sortie;
            this.ports = ports;
            this.support = sup;
            this.type = type;
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

            return s;
        }

        public List<string> ToStringArray()
        {
            List<string> output = new List<string>();

            output.Add(nom);
            output.Add(fabriquant);
            output.Add("" + generation);
            output.Add(sortie.ToString("d", new System.Globalization.CultureInfo("fr-FR")));
            output.Add("" + ports);
            output.Add(support.ToString());
            output.Add(type);

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

        public int CompareFieldTo(string field, Console other)
        {
            if (other != null)
            {
                switch (field)
                {
                    case "nom": return this.nom.CompareTo(other.Nom);
                    case "fabriquant": return this.fabriquant.CompareTo(other.Fabriquant);
                    case "generation": return this.generation.CompareTo(other.Generation);
                    case "sortie": return this.sortie.CompareTo(other.Sortie);
                    case "ports": return this.ports.CompareTo(other.Ports);
                    case "support": return this.support.CompareTo(other.Support);
                    case "type": return this.type.CompareTo(other.Type);
                    default: return -1;
                }
            }
            else
                return 1;
        }

        public static bool operator == (Console c1, Console c2)
        {
            if (c1 == null)
                return c2 == null;
            else
                return c1.Equals(c2);
        }
        
        public static bool operator != (Console c1, Console c2)
        {
            return !(c1 == c2);
        }
    }
}
