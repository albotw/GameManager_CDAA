using System;
using System.Collections.Generic;
using System.Text;

namespace projet_CDAA_2020_2021.CLI
{
    class CLIWindow : CLIElement
    {
        public CLIWindow() : base()
        {

        }

        public CLIWindow(int x, int y, int width, int height) : base(x, y, width, height)
        {

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
            throw new NotImplementedException();
        }
    }
}
