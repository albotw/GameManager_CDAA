using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.core.consoles
{
    public class FieldConsole : Field
    {
        private FieldConsole(string value) : base(value)
        { }

        public static FieldConsole Nom { get { return new FieldConsole("nom"); } }
        public static FieldConsole Fabriquant { get { return new FieldConsole("fabriquant"); } }
        public static FieldConsole Generation { get { return new FieldConsole("generation"); } }
        public static FieldConsole Sortie { get { return new FieldConsole("sortie"); } }
        public static FieldConsole Ports { get { return new FieldConsole("ports"); } }
        public static FieldConsole Support { get { return new FieldConsole("support"); } }
        public static FieldConsole Type { get { return new FieldConsole("type"); } }
    }
}
