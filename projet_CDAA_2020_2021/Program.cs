using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.CLI;
using System;

namespace projet_CDAA_2020_2021
{
    class Program
    {
        public static Catalogue c;

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

                CLIWindow w = new CLIWindow(0, 0, 180, 40);
                cli.AddElement(w);

                string[] tableHeader = { "NOM", "DESCRIPTION", "PLATEFORME", "EDITEUR", "GENRE", "PRIX", "SORTIE", "RECONDITIONNE" };
                int[] sizes = { 50, 50, 25, 25, 15, 5, 10, 14};
                table = new CLITable(2, 30, tableHeader,sizes,  null);
                table.Data = c.getJeux().ToStringArray().ToArray();

                CLIMenu menu = new CLIMenu(20, 3);
                menu.Init(1);

                cli.AddElement(table);
                cli.AddElement(menu);
                cli.Loop();
            }

            if (false)
            {
                Console.WriteLine(c.getJeux().ToString());
                Console.WriteLine("\n\n\n APPLICATION TRI\n\n\n");
                Jeux j2 = new Jeux(c.Sort("prix", false));
                Console.WriteLine(j2.ToString());
                while (true) { }
            }
        }

        public static void updateMainTable()
        {
            table.Data = c.getJeux().ToStringArray().ToArray();
        }

        public static void dispatchCommand(int command)
        {
            switch (command)
            {
                case 0:
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

                    tmp.Clear();

                    //j.input();
                    c.Add(j);
                    break;

                case 1:
                    Jeu j2 = new Jeu();
                    j2.input();
                    c.Remove(j2);
                    break;

            }
        }
    }
}
