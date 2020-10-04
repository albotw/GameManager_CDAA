using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace projet_CDAA_2020_2021.CLI
{
    class CLIInputWindow : CLIWindow
    {
        private string text;
        public string Text;

        private string userText;
        public string UserText;

        private string placeholder = "<ESPACE> pour rentrer du texte";

        public CLIInputWindow() : base()
        {
            text = "";
            UserText = "";
        }

        ~CLIInputWindow()
        {
            Clear();
        }

        public CLIInputWindow(int x, int y, int width, string text) : base(x, y, width, 5)
        {
            this.text = text;
            this.userText = "";
        }

        public override void Draw()
        {
            base.Draw();
            SetCursorPosition(this.X + (this.Width - text.Length) / 2, this.Y + 1);
            Write(text);
            SetCursorPosition(this.X +1, this.Y + 3);
            Write(" > " + (this.userText == "" ? this.placeholder : this.userText));
            //Console.CursorVisible = true;
        }

        public override void Clear()
        {
            base.Clear();
            StringBuilder space = new StringBuilder();
            space.Append(' ', this.Width);

            SetCursorPosition(this.X+1, this.Y + 1);
            Write(space.ToString());
            SetCursorPosition(this.X+1, this.Y + 3);
            Write(space.ToString());

            space = null;

        }

        public override void handleInput(ConsoleKey key)
        {
            if (this.userText == "")
            {
                SetCursorPosition(this.X + 4, this.Y + 3);
                Write("                              ");
                SetCursorPosition(this.X + 4, this.Y + 3);
                CursorVisible = true;
                this.userText = ReadLine();
                CursorVisible = false;
            }
        }
    }
}
