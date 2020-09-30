using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.CLI
{
    class CLIMenu : CLIElement
    {
        public static int MAX_SIZE = 10;

        private string[] content;

        private int userPos;


        public CLIMenu() : base()
        {
            this.content = new string[MAX_SIZE];
            this.userPos = 0;
        }

        public CLIMenu(int x, int y, string[] info) : base(x, y)
        {
            this.userPos = 0;
            this.content = new string[info.Length];
            for(int i = 0; i < info.Length; i++)
            {
                content[i] = info[i].Insert(0, "[ ] ");
            }
        }
        public void Init(int config)
        {
            switch(config)
            {
                case 0:
                    content[0] = "[ ] Ajouter un jeu";
                    content[1] = "[ ] Supprimer un jeu";
                    content[2] = "[ ] Rechercher un jeu";
                    content[3] = "[ ] Rechercher un genre";
                    break;
            }
        }

        public override void Draw()
        {
            for (int i = 0; i < content.Length; i++)
            {
                if (i == userPos)
                {
                    char[] tmp = content[i].ToArray();
                    tmp[1] = 'X';
                    content[i] = new string(tmp);
                }
                else
                {
                    char[] tmp = content[i].ToCharArray();
                    tmp[1] = ' ';
                    content[i] = new string(tmp);
                }
                Console.SetCursorPosition(this.X, this.Y + 1 + i);
                Console.Write(content[i]);
            }
        }

        public override void Clear()
        {
            for (int i = 0; i < content.Length; i++)
            {
                Console.SetCursorPosition(this.X, this.Y + 1 + i);
                char[] tmp = new char[content[i].Length];
                for (int j = 0; j < tmp.Length; j++)
                {
                    tmp[j] = ' ';
                }
                Console.Write(tmp);
            }
        }
    }
}
