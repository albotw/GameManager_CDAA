using System;
using System.Collections.Generic;
using System.Text;

namespace projet_CDAA_2020_2021.CLI
{
    public abstract class CLIElement
    {
        private int x;
        public int X { get => x; set => x = value; }

        private int y;
        public int Y { get => y; set => y = value; }

        

        public CLIElement(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public CLIElement()
        {
            this.x = 0;
            this.y = 0;
        }

        public abstract void Draw();

        public abstract void Clear();
    }
}
