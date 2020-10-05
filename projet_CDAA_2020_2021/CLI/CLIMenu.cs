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
                    this.commands = new string[4];
                    this.commandID = new int[4];

                    commands[0] = "[ ] Ajouter un jeu";
                    commands[1] = "[ ] Supprimer un jeu";
                    commands[2] = "[ ] Rechercher un jeu";
                    commands[3] = "[ ] Rechercher un genre";

                    commandID[0] = 0;
                    commandID[1] = 1;
                    commandID[2] = 2;
                    commandID[3] = 3;
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
                    char[] tmp = new char[commands[i].Length];
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        tmp[j] = ' ';
                    }
                    Console.Write(tmp);
                }
            }
        }

        public override void handleInput(ConsoleKey key)
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
                    Program.dispatchCommand(0);
                    break;
            }
        }
    }
}
