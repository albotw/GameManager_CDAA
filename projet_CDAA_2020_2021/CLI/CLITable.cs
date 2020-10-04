using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.CLI
{
    class CLITable : CLIElement
    {
        private StringBuilder header;
        private StringBuilder separator;
        private int cellLength;
        private string[][] data;

        public CLITable() : base()
        {
            this.header = new StringBuilder();
            this.separator = new StringBuilder();
            this.cellLength = 0;
            this.data = new string[0][];
        }

        public CLITable(int x, int y, int cellLength, string[] headerValues, string[][] data) : base(x, y)
        {
            this.cellLength = cellLength;
            this.header = new StringBuilder("|");
            this.separator = new StringBuilder("+");

            //construction des entêtes et séparateurs dépendants des données
            foreach(string h in headerValues)
            {
                if (h.Length < cellLength)
                {
                    header.Append(h);
                    header.Append(' ', cellLength - h.Length);
                }
                else if (h.Length > cellLength)
                {
                    header.Append(h.Substring(0, cellLength));
                }
                header.Append("|");

                separator.Append('-', cellLength);
                separator.Append('+');
            }

            this.data = data;
        }
    }
}
