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
        public string Text { set => text = value; }

        private string userText;
        public string UserText { get => userText; }

        private string placeholder = "<ESPACE> pour rentrer du texte";

        public CLIInputWindow() : base()
        {
            text = "";
            userText = "";
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

        public void Init(int config)
        {
            this.userText = "";
            switch (config)
            {

                case 0: this.text = "Entrez le nom"; break;
                case 1: this.text = "Entrez une description:"; break;
                case 2: this.text = "Entrez la/les plateforme/s du jeu"; break;
                case 3: this.text = "Entrez l'editeur"; break;
                case 4: this.text = "Entrez le genre"; break;
                case 5: this.text = "Entrez le prix"; break;
                case 6: this.text = "Entrez la date de sortie (jj/mm/aaaa) du jeu"; break;
                case 7: this.text = "Le jeu est reconditionné ?"; break;

                case 8: this.text = "Le jeu est un jeu rétro ?"; break;
                case 9: this.text = "Entrez l'état du jeu ?"; break;
                case 10: this.text = "Le jeu a une notice ?"; break;
                case 11: this.text = " Entre le nom de votre accessoire"; break;
                case 12: this.text = "Entre le pays de fabrication"; break;
                case 13: this.text = "Entrez la plateforme de l'accessoire ( ex PS4, WII...)"; break;
                case 14: this.text = " Entrez le type d'accessoire"; break;
            }
        }

        public override void Draw()
        {
            base.Draw();
            SetCursorPosition(this.X + (this.Width - text.Length) / 2, this.Y + 1);
            Write(text);
            SetCursorPosition(this.X + 1, this.Y + 3);
            Write(" > " + (this.userText == "" ? this.placeholder : this.userText));
            //Console.CursorVisible = true;
        }

        public override void Clear()
        {
            base.Clear();
            StringBuilder space = new StringBuilder();
            space.Append(' ', this.Width + 1);

            SetCursorPosition(this.X + 1, this.Y + 1);
            Write(space.ToString());
            SetCursorPosition(this.X + 1, this.Y + 3);
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
