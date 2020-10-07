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

        public EnsembleConsoles(List<Console> l) : base (l)
        { }

        public override void Init()
        {
            Add(new Console("Switch", "Nintendo", 8, new DateTime(2017, 03, 1), 8, Support.Cartouche, "hybride"));
        }

        public override List<Console> Search(string property, object arg)
        {
            throw new NotImplementedException();
        }

        public override List<string[]> ToStringArray()
        {
            throw new NotImplementedException();
        }
    }
}
