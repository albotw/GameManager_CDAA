using System;
using System.Collections.Generic;
using System.Text;

namespace projet_CDAA_2020_2021.CLI
{
    class CLIWindow : CLIElement
    {
        private int width;
        public int Width { get => width; set => width = value; }

        private int height;
        public int Height { get => height; set => height = value; }

        public CLIWindow() : base()
        {
            this.width = 1;
            this.height = 1;
        }

        public CLIWindow(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width - 1;
            this.height = height - 1;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("+");
            Console.SetCursorPosition(X+Width, Y);
            Console.Write("+");
            Console.SetCursorPosition(X, Y+Height);
            Console.Write("+");
            Console.SetCursorPosition(X+Width, Y+Height);
            Console.Write("+");

            for (int i = X+1; i < X +Width; i++)
            {
                Console.SetCursorPosition(i, Y);
                Console.Write("=");
                Console.SetCursorPosition(i, Y+Height);
                Console.Write("=");
            }

            for (int i = Y+1; i < Y+Height; i++)
            {
                Console.SetCursorPosition(X, i);
                Console.Write("|");
                Console.SetCursorPosition(X+Width, i);
                Console.Write("|");
            }
        }

        public override void Clear()
        {
            for(int i = X; i < X+width; i++)
            {
                Console.SetCursorPosition(i, Y);
                Console.Write(" ");
                Console.SetCursorPosition(i, Y + Height);
                Console.Write(" ");
            }

            for (int i = Y; i < Y + Height; i++)
            {
                Console.SetCursorPosition(X, i);
                Console.Write(" ");
                Console.SetCursorPosition(X + Width, i);
                Console.Write(" ");
            }
        }
    }
}
