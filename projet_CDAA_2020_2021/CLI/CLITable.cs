using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace projet_CDAA_2020_2021.CLI
{
    class CLITable : CLIElement
    {
        private StringBuilder header;
        private int[] columnSizes;
        private StringBuilder separator;

        private string[][] data;
        public string[][] Data { get => data; set => data = value; }

        public CLITable() : base()
        {
            this.header = new StringBuilder();
            this.separator = new StringBuilder();
            this.data = new string[0][];
        }

        public CLITable(int x, int y, string[] headerValues, int[] columnSizes, string[][] data) : base(x, y)
        {
            this.columnSizes = columnSizes;
            this.header = new StringBuilder("|");
            this.separator = new StringBuilder("+");

            //construction des entêtes et séparateurs dépendants des données
            for (int i = 0; i < headerValues.Length; i++)
            {
                string tmp = headerValues[i];
                int tmpSize = columnSizes[i];

                if (tmp.Length < tmpSize)
                {
                    header.Append(tmp);
                    header.Append(' ', tmpSize - tmp.Length);
                }
                else if (tmp.Length > tmpSize)
                {
                    header.Append(tmp.Substring(0, tmpSize));
                }
                header.Append("|");

                separator.Append('-', tmpSize);
                separator.Append('+');
            }

            this.data = data;
        }

        public override void Draw()
        {
            SetCursorPosition(this.X, this.Y);
            Write(header.ToString());

            SetCursorPosition(this.X, this.Y + 1);
            Write(separator.ToString());

            int lineY = this.Y+2;
            //TODO: Mettre en fonction et rendre générique.
            foreach(string[] line in data)
            {
                StringBuilder formattedLine = new StringBuilder("|");

                int sizeIndex = 0;
                foreach(string s in line)
                {
                    if (s.Length < columnSizes[sizeIndex])
                    {
                        formattedLine.Append(s);
                        formattedLine.Append(' ', columnSizes[sizeIndex] - s.Length);
                    }
                    else
                    {
                        formattedLine.Append(s.Substring(0, columnSizes[sizeIndex]));
                    }
                    formattedLine.Append("|");
                    sizeIndex++;
                }

                SetCursorPosition(this.X, lineY);
                Write(formattedLine.ToString());
                SetCursorPosition(this.X, lineY + 1);
                Write(separator.ToString());

                lineY += 2;
            }
        }

        public override void Clear()
        {
            
        }

        public override void handleInput(ConsoleKey key)
        {
            
        }
    }
}
