using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.CLI;
using System;
using System.Runtime.CompilerServices;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.commands;

namespace projet_CDAA_2020_2021
{
    class Program
    {
        public static Catalogue c;

        public static EnsembleJeux searchResult = null;

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
            Console.SetCursorPosition(1, 1);
            Console.Write(c.GetEnsembleJeux().GetAll().Count);
            switch(state)
            {
                case 0: table.Data = c.GetEnsembleJeux().ToStringArray().ToArray(); break;
                case 1: table.Data = c.GetEnsembleAccessoires().ToStringArray().ToArray(); break;
                case 2: table.Data = searchResult.ToStringArray().ToArray(); break;
            }
        }

        public static void dispatchCommand(int command)
        {
            //commandes particulières.
            if (state == 0)
            {
                CommandesJeux.handleCommand(command);
            }

            switch (command)
            {
                //commandes générales.
                case -1:                    //suppression de la table de recherche et affichage de la table principale.
                    searchResult = null;
                    state = 0;
                    break;
            }
        }
    }
}
