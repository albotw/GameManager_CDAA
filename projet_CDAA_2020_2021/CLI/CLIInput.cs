using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.CLI
{
    class CLIInput : CLIWindow
    {
        private string text;
        public string Text;

        private string userText;
        public string UserText;

        public CLIInput() : base()
        {
            text = "";
            UserText = "";
        }

        public CLIInput(int x, int y, int width, string text) : base(x, y, width, 5)
        {
            this.text = text;
        }

        public override void Draw()
        {
            base.Draw();
            Console.SetCursorPosition(this.X + (this.Width - text.Length)/2, this.Y + 1);
            Console.Write(text);
            Console.SetCursorPosition(this.X +1, this.Y + 3);
            Console.Write("> ");
            Console.CursorVisible = true;
            Console.ReadLine();
        }

        public override void Clear()
        {
            base.Clear();
        }
    }
}
