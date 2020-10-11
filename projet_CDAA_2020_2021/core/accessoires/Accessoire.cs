using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core.accessoires
{
    public class Accessoire : IEquatable<Accessoire>, IComparable<Accessoire>, IFieldComparable<Accessoire>
    {

        private string fabriquantPays;
        public string FabriquantPays { get => fabriquantPays; set => fabriquantPays = value; }

        private String plateforme;
        public String Plateforme { get => plateforme; set => plateforme = value; }
        private Type type;
        public Type Type { get => type; set => type = value; }

        public Accessoire()
        {
            this.fabriquantPays = "";
            this.plateforme = "";
            this.type = 0;
        }

        public Accessoire(string fabriquant, string plateforme,  Type type)
        {
            this.fabriquantPays = fabriquant;
            this.plateforme = plateforme;
            this.type = type;
        }

        public override string ToString()
        {
            string s = "";
            s += "\nfabriquant: " + this.fabriquantPays;
            s += "\nplateforme: " + this.plateforme;
            s += "\ntype: " + this.type;

            return s;
        }

        public List<string> ToStringArray()
        {
            List<string> output = new List<string>();

            output.Add(fabriquantPays);
            output.Add("" + plateforme);
            output.Add(type.ToString());
            return output;
        }

        public bool Equals (Accessoire other)
        {
            if (other != null)
                return (this.fabriquantPays == other.FabriquantPays
                    && this.plateforme == other.Plateforme);
            else
                return false;
        }

        public int CompareTo(Accessoire other)
        {
            if (other == null)
                return 1;
            else
                return this.Type.CompareTo(other.Type);
        }

        public int CompareFieldTo(string field, Accessoire other)
        {
            if (other != null)
            {
                switch (field)
                {
                    case "fabriquant": return this.fabriquantPays.CompareTo(other.FabriquantPays);
                    case "plateforme": return this.plateforme.CompareTo(other.Plateforme);
                    case "type": return this.type.CompareTo(other.Type);
                    default: return -1;
                }
            }
            else
                return 1;
        }

        public static bool operator == (Accessoire acc1, Accessoire acc2)
        {
            if (acc1 == null)
                return acc2 == null;
            else
                return acc1.Equals(acc2);
        }
        
        public static bool operator != (Accessoire acc1, Accessoire acc2)
        {
            return !(acc1 == acc2);
        }
    }
}
