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

        public static CLITable tableJeux;
        public static CLIMenu menuJeux;

        public static CLITable tableConsoles;
        public static CLIMenu menuConsoles;

        public static  int state = 0;
        // 0 -> affichage de la table des jeux
        // 1 -> affichage de la table des consoles
        // 2 -> affichage d'une recherche de jeu
        // 3 -> affichage d'une recherche de console.

        static void Main()
        {
            WriteLine("Quel programme voulez vous éxécuter ?");
            WriteLine("1 : Gestionnaire de jeux");
            WriteLine("2 : Test du panier ");
            string result = ReadLine();
            if (result == "1")
            {
                Program.Init();
            }
            else if (result == "2")
            {
                TestPanier.Init();
            }
        }

        public static void Init()
        {
            Clear();
            c = new Catalogue();
            c.Init();

            cli = new CLIManager();
            cli.init();

            //CLIWindow w = new CLIWindow(0, 0, 200, 40);
            //taille yann PC FIXE: 200x40
            //taille yann MAC: 190x40

            //cli.AddElement(w);

            string[] tableHeader = { "NOM", "DESCRIPTION", "PLATEFORME", "EDITEUR", "GENRE", "PRIX", "SORTIE", "RECONDITIONNE", "ETAT", "NOTICE" };
            int[] sizes = { 50, 50, 25, 25, 15, 5, 10, 14, 20, 5 };
            tableJeux = new CLITable(2, 10, tableHeader, sizes, null);
            tableJeux.Data = c.GetLesJeux().ToStringArray().ToArray();

            string[] tableHeaderConsoles = { "NOM", "FABRIQUANT", "GENERATION", "SORTIE", "PORTS", "SUPPORT", "TYPE", "PRIX" };
            int[] sizesConsoles = { 50, 50, 15, 10, 10, 20, 20, 5 };
            tableConsoles = new CLITable(2, 10, tableHeaderConsoles, sizesConsoles, null);
            tableJeux.Data = c.GetLesConsoles().ToStringArray().ToArray();

            menuJeux = new CLIMenu(2, 1);
            menuJeux.Init(1);

            menuConsoles = new CLIMenu(2, 1);
            menuConsoles.Init(6);

            cli.AddElement(tableJeux);
            cli.AddElement(menuJeux);
            cli.Loop();
        }

        public static void UpdateMainTable()
        {
            switch(state)
            {
                case 0: tableJeux.Data = c.GetLesJeux().ToStringArray().ToArray(); break;
                case 1: tableConsoles.Data = c.GetLesConsoles().ToStringArray().ToArray(); break;
                case 2: tableJeux.Data = searchResultJeux.ToStringArray().ToArray(); break;
                case 3: tableConsoles.Data = searchResultConsoles.ToStringArray().ToArray(); break;
            }
        }

        public static void DispatchCommand(Command command)
        {
            //commandes particulières.
            if (state == 0)
            {
                CommandesJeux.HandleCommand(command);
            }
            else if (state == 1)
            {
                CommandesConsoles.HandleCommand(command);
            }

            switch (command)
            {
                //commandes générales.
                case Command.AfficherTousJeux:      //suppression de la table de recherche et affichage de la table principale (jeux);
                    cli.DeleteTop();                //suppression de la table (jeux ou console) de la pile d'affichage
                    cli.DeleteTop();                //pour s'assurer qu'il s'agit bien des objets concernant les jeux (comme la commande est utilisée comme commande de réinitialisation)
                    cli.AddElement(tableJeux);
                    cli.AddElement(menuJeux);
                    searchResultJeux = null;
                    state = 0;
                    break;

                case Command.AfficherTousConsoles:  //suppression de la table de recherche et affichage de la table principale (consoles)
                    cli.DeleteTop();
                    cli.DeleteTop();
                    cli.AddElement(tableConsoles);
                    cli.AddElement(menuConsoles);
                    searchResultConsoles = null;
                    state = 1;
                    break;
            }
        }
    }
}
