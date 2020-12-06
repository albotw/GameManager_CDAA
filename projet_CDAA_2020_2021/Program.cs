using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.CLI;
using System;
using System.Runtime.CompilerServices;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.commands;
using projet_CDAA_2020_2021.core.accessoires;

namespace projet_CDAA_2020_2021
{
    class Program
    {
        public static Catalogue c;

        public static EnsembleJeux searchResultJeux = null;
        public static EnsembleAccessoire searchResultAccessoire = null;

        public static CLIManager cli;

        public static CLITable tableJeux;
        public static CLIMenu menuJeux;

        public static CLITable tableAccessoire;
        public static CLIMenu menuAccessoire;

        public static  int state = 0;
        // 0 -> affichage de la table des jeux
        // 1 -> affichage de la table des accessoires        
        // 2 -> affichage d'une recherche

        static void Main()
        {

            Console.WriteLine("Quel programme voulez vous executer ? ");
            Console.WriteLine("1 - Gestionnaire de jeux ");
            Console.WriteLine("2 - Test du panier");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Program.Init();
            }
            else if (result == "2")
            {
                TestPanier.Init();
            }
        }

            public static void Init() {
               Console.Clear();
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
                    tableJeux = new CLITable(2, 30, tableHeader, sizes, null);
                    tableJeux.Data = c.GetEnsembleJeux().ToStringArray().ToArray();

                    string[] tableHeaderAccessoires = { "NOM", "FRABRIQUANTPAYS", "PLATEFORME", "TYPE" };
                    int[] sizesAccessoires = { 40, 40, 40, 40 };
                    tableAccessoire = new CLITable(2, 30, tableHeaderAccessoires, sizesAccessoires, null);
                    tableJeux.Data = c.GetEnsembleAccessoires().ToStringArray().ToArray();

                    menuJeux = new CLIMenu(5, 3);
                    menuJeux.Init(1);

                    menuAccessoire = new CLIMenu(5, 3);
                    menuAccessoire.Init(6);

                    cli.AddElement(tableJeux);
                    cli.AddElement(menuJeux);
                    cli.Loop();
                }
            }
        
        public static void updateMainTable()
        {
            Console.SetCursorPosition(1, 1);
            Console.Write(c.GetEnsembleJeux().GetAll().Count);
            switch(state)
            {
                case 0: tableJeux.Data = c.GetEnsembleJeux().ToStringArray().ToArray(); break;
                case 1: tableAccessoire.Data = c.GetEnsembleAccessoires().ToStringArray().ToArray(); break;
                case 2: tableJeux.Data = searchResultJeux.ToStringArray().ToArray(); break;
                case 3: tableAccessoire.Data = searchResultAccessoire.ToStringArray().ToArray(); Console.WriteLine(" TEST"); break;
            }
        }

        public static void dispatchCommand(int command)
        {
            //commandes particulières.
            if (state == 0)
            {
                CommandesJeux.handleCommand(command);
            }
            else if ( state==1 )
            {
                CommandAccessoires.handleCommand(command);
            }

            switch (command)
            {
                //commandes générales.
                case -1:                    //suppression de la table de recherche et affichage de la table principale.
                    cli.DeleteTop();
                    cli.DeleteTop();
                    cli.AddElement(tableJeux);
                    cli.AddElement(menuJeux);
                    searchResultJeux = null;
                    state = 0;
                    break;
                case -2:
                    cli.DeleteTop();
                    cli.DeleteTop();
                    cli.AddElement(tableAccessoire);
                    cli.AddElement(menuAccessoire);
                    searchResultAccessoire = null;
                    state = 1;
                    break;
            }
        }
    }
}
