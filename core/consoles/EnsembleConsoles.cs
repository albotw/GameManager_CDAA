using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using projet_CDAA_2020_2021.core.datastructures;

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

        public override List<Console> Search(Field field, object arg)
        {
            List<Console> output = new List<Console>();

            foreach (Console c in liste)
            {
                if (field == FieldConsole.Nom && c.Nom == (string)arg)
                    output.Add(c);
                else if (field == FieldConsole.Fabriquant && c.Fabriquant == (string)arg)
                    output.Add(c);
                else if (field == FieldConsole.Generation && c.Generation == (int)arg)
                    output.Add(c);
                else if (field == FieldConsole.Sortie && c.Sortie == (DateTime)arg)
                    output.Add(c);
                else if (field == FieldConsole.Ports && c.Ports == (int)arg)
                    output.Add(c);
                else if (field == FieldConsole.Support && c.Support == (Support)arg)
                    output.Add(c);
                else if (field == FieldConsole.Type && c.Type == (string)arg)
                    output.Add(c);
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
