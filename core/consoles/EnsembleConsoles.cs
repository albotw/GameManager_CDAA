using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using projet_CDAA_2020_2021.datastructures;

namespace projet_CDAA_2020_2021.core.consoles
{
    public class EnsembleConsoles : Ensemble<Console>
    {
        public EnsembleConsoles() : base()
        { }

        public EnsembleConsoles(List<Console> l) : base(l)
        { }

        public override void Init()
        {
            Add(new Console("Switch", "Nintendo", 8, new DateTime(2017, 03, 1), 8, Support.Cartouche, "hybride"));
        }

        public override List<Console> Search(string property, object arg)
        {
            List<Console> output = new List<Console>();

            foreach (Console c in liste)
            {
                switch (property)
                {
                    case "nom":
                        if (c.Nom == (string)arg)
                            output.Add(c);
                        break;
                    case "fabriquant":
                        if (c.Fabriquant == (string)arg)
                            output.Add(c);
                        break;
                    case "generation":
                        if (c.Generation == Int32.Parse((string)arg))
                            output.Add(c);
                        break;
                    case "sortie":
                        if (c.Sortie == (DateTime)arg)
                            output.Add(c);
                        break;
                    case "ports":
                        if (c.Ports == (int)arg)
                            output.Add(c);
                        break;
                    case "support":
                        if (c.Support == (Support)arg)
                            output.Add(c);
                        break;
                    case "type":
                        if (c.Type == (string)arg)
                            output.Add(c);
                        break;
                }
            }

            return output;
        }

        public override List<string[]> ToStringArray()
        {
            List<string[]> output = new List<string[]>();
            foreach (Console c in liste)
            {
                output.Add(c.ToStringArray().ToArray());
            }

            return output;
        }
    }
}
