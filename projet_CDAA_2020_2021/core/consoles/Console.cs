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
    }
}
