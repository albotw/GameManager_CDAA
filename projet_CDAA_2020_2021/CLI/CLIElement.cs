using System;
using System.Collections.Generic;
using System.Text;

namespace projet_CDAA_2020_2021.CLI
{
    abstract class CLIElement
    {
        private int x;
        public int X { get => x; set => x = value; }

        private int y;
        public int Y { get => y; set => y = value; }

        private int width;
        public int Width { get => width; set => width = value; }

        private int height;
        public int Height { get => height; set => height = value; }

        public CLIElement(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width-1;
            this.height = height-1;
        }

        public CLIElement()
        {
            this.x = 0;
            this.y = 0;
            this.width = 1;
            this.height = 1;
        }

        public abstract void Draw();

        public abstract void Clear();
    }
}
