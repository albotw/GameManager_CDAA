using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.CLI
{
    class CLIMenu : CLIElement
    {
        public static int MAX_SIZE = 10;

        private string[] commands;
        private int[] commandID;

        private int userPos;

        public CLIMenu() : base()
        {
            this.commands = new string[MAX_SIZE];
            this.commandID = new int[MAX_SIZE];
            this.userPos = 0;
        }

        public CLIMenu(int x, int y) : base(x, y)
        {
            this.commands = new string[MAX_SIZE];
            this.commandID = new int[MAX_SIZE];
            this.userPos = 0;
        }

        public CLIMenu(int x, int y, string[] info, int[] commandID) : base(x, y)
        {
            this.userPos = 0;
            this.commands = new string[info.Length];
            this.commandID = commandID;
            for (int i = 0; i < info.Length; i++)
            {
                commands[i] = info[i].Insert(0, "[ ] ");
            }
        }
        public void Init(int config)
        {
            switch (config)
            {
                case 1:
                    this.commands = new string[6];
                    this.commandID = new int[6];

                    commands[0] = "[ ] Ajouter un jeu";
                    commands[1] = "[ ] Supprimer un jeu";
                    commands[2] = "[ ] Trier par champ";
                    commands[3] = "[ ] Faire une recherche";
                    commands[4] = "[ ] Afficher tout les jeux";
                    commands[5] = "[ ] Afficher les consoles";

                    commandID[0] = 0;
                    commandID[1] = 1;
                    commandID[2] = 2;
                    commandID[3] = 3;
                    commandID[4] = -1;
                    commandID[5] = -2;
                    break;

                case 6:
                    this.commands = new string[6];
                    this.commandID = new int[6];

                    commands[0] = "[ ] Ajouter une console";
                    commands[1] = "[ ] Supprimer une console";
                    commands[2] = "[ ] Trier par champ";
                    commands[3] = "[ ] Faire une recherche";
                    commands[4] = "[ ] Afficher toutes les consoles";
                    commands[5] = "[ ] Afficher les jeux";

                    commandID[0] = 100;
                    commandID[1] = 101;
                    commandID[2] = 102;
                    commandID[3] = 103;
                    commandID[4] = -2;
                    commandID[5] = -1;

                    break;

                case 2:
                    this.commands = new string[8];
                    this.commandID = new int[8];

                    commands[0] = "[ ] Nom";
                    commands[1] = "[ ] Description";
                    commands[2] = "[ ] Plateforme";
                    commands[3] = "[ ] Editeur";
                    commands[4] = "[ ] Genre";
                    commands[5] = "[ ] Prix";
                    commands[6] = "[ ] Sortie";
                    commands[7] = "[ ] Reconditionne";

                    for (int i = 20; i < 28; i++)
                    {
                        commandID[i - 20] = i;
                    }

                    break;

                case 3:
                    this.commands = new string[8];
                    this.commandID = new int[8];

                    commands[0] = "[ ] Nom";
                    commands[1] = "[ ] Description";
                    commands[2] = "[ ] Plateforme";
                    commands[3] = "[ ] Editeur";
                    commands[4] = "[ ] Genre";
                    commands[5] = "[ ] Prix";
                    commands[6] = "[ ] Sortie";
                    commands[7] = "[ ] Reconditionne";

                    for (int i = 30; i < 38; i++)
                    {
                        commandID[i - 30] = i;
                    }

                    break;

                case 4:
                    this.commands = new string[7];
                    this.commandID = new int[7];

                    commands[0] = "[ ] Nom";
                    commands[1] = "[ ] Fabriquant";
                    commands[2] = "[ ] Génération";
                    commands[3] = "[ ] Sortie";
                    commands[4] = "[ ] Ports";
                    commands[5] = "[ ] Support";
                    commands[6] = "[ ] Type";

                    for (int i = 120; i < 127; i++)
                    {
                        commandID[i - 120] = i;
                    }
                    break;

                case 5:
                    this.commands = new string[7];
                    this.commandID = new int[7];

                    commands[0] = "[ ] Nom";
                    commands[1] = "[ ] Fabriquant";
                    commands[2] = "[ ] Génération";
                    commands[3] = "[ ] Sortie";
                    commands[4] = "[ ] Ports";
                    commands[5] = "[ ] Support";
                    commands[6] = "[ ] Type";

                    for (int i = 130; i < 137; i++)
                    {
                        commandID[i - 130] = i;
                    }
                    break;
            }
        }

        public override void Draw()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] != null)
                {
                    if (i == userPos)
                    {
                        char[] tmp = commands[i].ToArray();
                        tmp[1] = 'X';
                        commands[i] = new string(tmp);
                    }
                    else
                    {
                        char[] tmp = commands[i].ToCharArray();
                        tmp[1] = ' ';
                        commands[i] = new string(tmp);
                    }
                    Console.SetCursorPosition(this.X, this.Y + 1 + i);
                    Console.Write(commands[i]);
                }
            }
        }

        public override void Clear()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] != null)
                {
                    Console.SetCursorPosition(this.X, this.Y + 1 + i);
                    StringBuilder space = new StringBuilder();
                    space.Append(' ', commands[i].Length);
                    Console.Write(space.ToString());
                }
            }
        }

        public override void HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (this.userPos > 0) this.userPos--;
                    break;

                case ConsoleKey.DownArrow:
                    if (this.userPos < commands.Length - 1) this.userPos++;
                    break;

                case ConsoleKey.Enter:
                    Program.dispatchCommand(commandID[this.userPos]);
                    break;
            }
        }
    }
}
