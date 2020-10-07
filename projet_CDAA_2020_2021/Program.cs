using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.CLI;
using System;
using System.Runtime.CompilerServices;

namespace projet_CDAA_2020_2021
{
    class Program
    {
        public static Catalogue c;

        public static EnsembleJeux searchResult = null;

        public static CLIManager cli;

        public static CLITable table;
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

                cli.AddElement(w);

                string[] tableHeader = { "NOM", "DESCRIPTION", "PLATEFORME", "EDITEUR", "GENRE", "PRIX", "SORTIE", "RECONDITIONNE" };
                int[] sizes = { 50, 50, 25, 25, 15, 5, 10, 14};
                table = new CLITable(2, 30, tableHeader,sizes,  null);
                table.Data = c.getJeux().ToStringArray().ToArray();

                CLIMenu menu = new CLIMenu(5, 5);
                menu.Init(1);

                cli.AddElement(table);
                cli.AddElement(menu);
                cli.Loop();
            }
        }

        public static void updateMainTable()
        {
            if (searchResult == null)
            {
                table.Data = c.getJeux().ToStringArray().ToArray();
            }
            else
            {
                table.Data = searchResult.ToStringArray().ToArray();
            }
        }

        public static void dispatchCommand(int command)
        {
            switch (command)
            {
                //TODO: Optimisation

                case -1:                    //suppression de la table de recherche et affichage de la table principale.
                    searchResult = null;
                    break;

                case 0:                     //Ajout d'un jeu
                    Jeu j = new Jeu();

                    CLIInputWindow tmp = new CLIInputWindow(50, 3, 50, "Entrez le nom du jeu");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    j.Nom = tmp.UserText;
                    cli.DeleteTop();

                    tmp = new CLIInputWindow(50, 3, 50, "Entrez une description du jeu");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    j.Description = tmp.UserText;
                    cli.DeleteTop();

                    tmp = new CLIInputWindow(50, 3, 50, "Entrez la/les plateforme/s du jeu");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    j.Plateforme = tmp.UserText;
                    cli.DeleteTop();

                    tmp = new CLIInputWindow(50, 3, 50, "Entrez l'éditeur du jeu");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    j.Editeur = tmp.UserText;
                    cli.DeleteTop();

                    tmp = new CLIInputWindow(50, 3, 50, "Entrez le genre du jeu");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    string s = tmp.UserText;
                    j.Genre = (Genre)Enum.Parse(typeof(Genre), s, true);
                    cli.DeleteTop();

                    tmp = new CLIInputWindow(50, 3, 50, "Entrez le prix du jeu");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    j.Prix = Double.Parse(tmp.UserText);
                    cli.DeleteTop();

                    tmp = new CLIInputWindow(50, 3, 50, "Entrez la date de sortie (jj/mm/aaaa) du jeu");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    int jour = Int32.Parse(tmp.UserText.Split('/')[0]);
                    int mois = Int32.Parse(tmp.UserText.Split('/')[1]);
                    int annee = Int32.Parse(tmp.UserText.Split('/')[2]);
                    j.Sortie = new DateTime(annee, mois, jour);
                    cli.DeleteTop();

                    tmp = new CLIInputWindow(50, 3, 50, "Le jeu est reconditionné ?");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    j.Reconditionne = (tmp.UserText == "oui" ? true : false);
                    cli.DeleteTop();

                    //j.input();
                    c.Add(j);
                    break;

                case 1:             // TODO: suppression d'un jeu
                    Jeu j2 = new Jeu();
                    j2.input();
                    c.Remove(j2);
                    break;

                case 2:             //Tri des jeux: menu de choix du champ
                    CLIMenu fieldSelector = new CLIMenu(35, 5);
                    fieldSelector.Init(2);
                    cli.AddElement(fieldSelector);
                    cli.Update();
                    break;

                //VARIANTES DE TRI
                case 20:
                    c.Sort("nom", false);
                    cli.DeleteTop();
                    break;

                case 21:
                    c.Sort("description", false);
                    cli.DeleteTop();
                    break;

                case 22:
                    c.Sort("plateforme", false);
                    cli.DeleteTop();
                    break;

                case 23:
                    c.Sort("editeur", false);
                    cli.DeleteTop();
                    break;

                case 24:
                    c.Sort("genre", false);
                    cli.DeleteTop();
                    break;

                case 25:
                    c.Sort("prix", false);
                    cli.DeleteTop();
                    break;

                case 26:
                    c.Sort("sortie", false);
                    cli.DeleteTop();
                    break;

                case 27:
                    c.Sort("reconditionne", false);
                    cli.DeleteTop();
                    break;

                case 3:
                    CLIMenu propertySelector = new CLIMenu(35, 5);
                    propertySelector.Init(3);
                    cli.AddElement(propertySelector);
                    cli.Update();
                    break;

                case 30:
                    tmp = new CLIInputWindow(55, 5, 40, "Entrez le nom");
                    cli.AddElement(tmp);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    searchResult = new EnsembleJeux(c.getJeux().Search("nom", tmp.UserText));
                    cli.DeleteTop();
                    cli.DeleteTop();
                    table.Clear();
                    updateMainTable();
                    break;

                //TODO: faire tous les cas de recherche

            }
        }
    }
}
