using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.CLI;
using System;
using System.Runtime.CompilerServices;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.commands;
using projet_CDAA_2020_2021.core.consoles;

using static System.Console;

using Console = projet_CDAA_2020_2021.core.consoles.Console;

namespace projet_CDAA_2020_2021
{
    class Program
    {
        public static Catalogue c;

        public static EnsembleJeux searchResultJeux = null;

        public static EnsembleConsoles searchResultConsoles = null;

        public static CLIManager cli;

        public static CLITable table;

        public static  int state = 0;
        // 0 -> affichage de la table des jeux
        // 1 -> affichage de la table des consoles
        // 2 -> affichage d'une recherche

        static void Main()
        {
            c = new Catalogue();
            c.Init();
            

            if (true)
            {
                cli = new CLIManager();
                cli.init();

                CLIWindow w = new CLIWindow(0, 0, 200, 40);
                //taille yann PC FIXE: 200x40
                //taille yann MAC: 190x40

                cli.AddElement(w);

                string[] tableHeader = { "NOM", "DESCRIPTION", "PLATEFORME", "EDITEUR", "GENRE", "PRIX", "SORTIE", "RECONDITIONNE", "ETAT", "NOTICE" };
                int[] sizes = { 50, 50, 25, 25, 15, 5, 10, 14, 20, 5 };
                table = new CLITable(2, 30, tableHeader, sizes, null);
                table.Data = c.GetEnsembleJeux().ToStringArray().ToArray();

                CLIMenu menu = new CLIMenu(5, 5);
                menu.Init(1);

                cli.AddElement(table);
                cli.AddElement(menu);
                cli.Loop();
            }
        }

        public static void updateMainTable()
        {
            SetCursorPosition(1, 1);
            Write(c.GetEnsembleJeux().GetAll().Count);

            switch(state)
            {
                case 0: table.Data = c.GetEnsembleJeux().ToStringArray().ToArray(); break;
                case 1: table.Data = c.GetEnsembleConsoles().ToStringArray().ToArray(); break;
                case 2: table.Data = searchResultJeux.ToStringArray().ToArray(); break;
                case 3: table.Data = searchResultConsoles.ToStringArray().ToArray(); break;
            }
        }

        public static void dispatchCommand(int command)
        {
            //commandes particulières.
            if (state == 0)
            {
                CommandesJeux.handleCommand(command);
            }
            else if (state == 1)
            {
                CommandesConsoles.handleCommand(command);
            }

            switch (command)
            {
                //commandes générales.
                case -1:                    //suppression de la table de recherche et affichage de la table principale (jeux);
                    searchResultJeux = null;
                    state = 0;
                    break;

                case -2:                    //passage de jeux a console
                    state = 1;
                    break;

                case -3:                    //suppression de la table de recherche et affichage de la table principale (consoles)
                    searchResultConsoles = null;
                    state = 1;
                    break;
            }
        }
    }
}
