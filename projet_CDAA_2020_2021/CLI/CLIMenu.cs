using System;
using System.Linq;
using System.Text;
using projet_CDAA_2020_2021.commands;

namespace projet_CDAA_2020_2021.CLI
{
    class CLIMenu : CLIElement
    {
        public static int MAX_SIZE = 10;

        private string[] commands;
        private Command[] commandID;

        private int userPos;

        public CLIMenu() : base()
        {
            this.commands = new string[MAX_SIZE];
            this.commandID = new Command[MAX_SIZE];
            this.userPos = 0;
        }

        public CLIMenu(int x, int y) : base(x, y)
        {
            this.commands = new string[MAX_SIZE];
            this.commandID = new Command[MAX_SIZE];
            this.userPos = 0;
        }

        public CLIMenu(int x, int y, string[] info, Command[] commandID) : base(x, y)
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
            if (config == 1 || config == 6)
            {
                commands = new string[6];
                commandID = new Command[6];

                if (config == 1)
                {
                    commands[0] = "[ ] Ajouter un jeu";
                    commands[1] = "[ ] Supprimer un jeu";
                    commands[2] = "[ ] Trier par champ";
                    commands[3] = "[ ] Faire une recherche";
                    commands[4] = "[ ] Afficher tout les jeux";
                    commands[5] = "[ ] Afficher les consoles";

                    commandID[0] = Command.AjouterJeu;
                    commandID[1] = Command.SupprimerJeu;
                    commandID[2] = Command.TrierJeu;
                    commandID[3] = Command.RechercherJeu;
                    commandID[4] = Command.AfficherTousJeux;
                    commandID[5] = Command.AfficherTousConsoles;
                }
                else if (config == 6)
                {

                    commands[0] = "[ ] Ajouter une console";
                    commands[1] = "[ ] Supprimer une console";
                    commands[2] = "[ ] Trier par champ";
                    commands[3] = "[ ] Faire une recherche";
                    commands[4] = "[ ] Afficher toutes les consoles";
                    commands[5] = "[ ] Afficher les jeux";

                    commandID[0] = Command.AjouterConsole;
                    commandID[1] = Command.SupprimerConsole;
                    commandID[2] = Command.TrierConsole;
                    commandID[3] = Command.RechercherConsole;
                    commandID[4] = Command.AfficherTousConsoles;
                    commandID[5] = Command.AfficherTousJeux;
                }
            }
            else if (config == 2 || config == 3)
            {
                this.commands = new string[8];
                this.commandID = new Command[8];

                commands[0] = "[ ] Nom";
                commands[1] = "[ ] Description";
                commands[2] = "[ ] Plateforme";
                commands[3] = "[ ] Editeur";
                commands[4] = "[ ] Genre";
                commands[5] = "[ ] Prix";
                commands[6] = "[ ] Sortie";
                commands[7] = "[ ] Reconditionne";

                for (int i = 0; i < 8; i++)
                {
                    if (config == 2)
                        commandID[i] = (Command)20 + i;
                    else if (config == 3)
                        commandID[i] = (Command)30 + i;
                }
            }
            else if (config == 4 || config == 5)
            {
                this.commands = new string[7];
                this.commandID = new Command[7];

                commands[0] = "[ ] Nom";
                commands[1] = "[ ] Fabriquant";
                commands[2] = "[ ] Génération";
                commands[3] = "[ ] Sortie";
                commands[4] = "[ ] Ports";
                commands[5] = "[ ] Support";
                commands[6] = "[ ] Type";

                for (int i = 0; i < 8; i++)
                {
                    if (config == 4)
                        commandID[i] = (Command)120 + i;
                    else if (config == 5)
                        commandID[i] = (Command)130 + i;
                }
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
                    Program.DispatchCommand(commandID[this.userPos]);
                    break;
            }
        }
    }
}
