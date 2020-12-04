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
            Add(new Console("Switch", "Nintendo", 8, new DateTime(2017, 03, 1), 8, Support.Cartouche, "hybride", 300.0));
            Add(new Console("PlayStation 3", "Sony", 7, new DateTime(2007, 05, 23), 4, Support.Blu_Ray, "salon", 100.0));
            Add(new Console("Super NES", "Nintendo", 4, new DateTime(1992, 06, 6), 4, Support.Cartouche, "salon", 40.0));
        }

        public override List<Console> Search(Field field, string arg)
        {
            List<Console> output = new List<Console>();

            foreach (Console c in liste)
            {
                if (field == FieldConsole.Nom && c.Nom == arg)
                    output.Add(c);
                else if (field == FieldConsole.Fabriquant && c.Fabriquant == arg)
                    output.Add(c);
                else if (field == FieldConsole.Generation)
                {
                    int g = Int32.Parse(arg);
                    if (c.Generation == g)
                        output.Add(c);
                }
                else if (field == FieldConsole.Sortie)
                {
                    string[] d_values = arg.Split('/');
                    DateTime d = new DateTime(Int32.Parse(d_values[2]), Int32.Parse(d_values[1]), Int32.Parse(d_values[0]));
                    if (c.Sortie == d)
                        output.Add(c);
                }
                else if (field == FieldConsole.Ports)
                {
                    int p = Int32.Parse(arg);
                    if (c.Ports == p)
                        output.Add(c);
                }
                else if (field == FieldConsole.Support)
                {
                    Support s = (Support)Enum.Parse(typeof(Support), arg);
                    if (c.Support == s)
                        output.Add(c);
                }
                else if (field == FieldConsole.Type && c.Type == arg)
                    output.Add(c);
                else if (field == FieldConsole.Prix)
                {
                    double p = Double.Parse(arg);
                    if (c.Prix == p)
                        output.Add(c);
                }
            }

            return output;
        }

        public override Console SearchSingle(Field field, string arg)
        {
            foreach (Console c in liste)
            {
                if (field == FieldConsole.Nom && c.Nom == arg)
                    return c;
                else if (field == FieldConsole.Fabriquant && c.Fabriquant == arg)
                    return c;
                else if (field == FieldConsole.Generation)
                {
                    int g = Int32.Parse(arg);
                    if (c.Generation == g)
                        return c;
                }
                else if (field == FieldConsole.Sortie)
                {
                    string[] d_values = arg.Split('/');
                    DateTime d = new DateTime(Int32.Parse(d_values[2]), Int32.Parse(d_values[1]), Int32.Parse(d_values[0]));
                    if (c.Sortie == d)
                        return c;
                }
                else if (field == FieldConsole.Ports)
                {
                    int p = Int32.Parse(arg);
                    if (c.Ports == p)
                        return c; ;
                }
                else if (field == FieldConsole.Support)
                {
                    Support s = (Support)Enum.Parse(typeof(Support), arg);
                    if (c.Support == s)
                        return c;
                }
                else if (field == FieldConsole.Type && c.Type == arg)
                    return c;
                else if (field == FieldConsole.Prix)
                {
                    double p = Double.Parse(arg);
                    if (c.Prix == p)
                        return c;
                }
            }

            return null;
        }

        public override List<string> GetAllNames()
        {
            List<string> output = new List<string>();
            foreach(Console c in liste)
            {
                output.Add(c.Nom);
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
