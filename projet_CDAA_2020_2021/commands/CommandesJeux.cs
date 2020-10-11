using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using projet_CDAA_2020_2021.CLI;
using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.jeux;


namespace projet_CDAA_2020_2021.commands
{
    class CommandesJeux
    {
        public static void handleCommand(int command)
        {
            CLIManager cli = Program.cli;
            Catalogue c = Program.c;

            if (command == 0)
            {
                Jeu j;

                CLIInputWindow tmp = new CLIInputWindow(50, 3, 50, "");
                tmp.Init(8);
                cli.AddElement(tmp);

                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);

                if (tmp.UserText == "oui")  //pour les params spécifiques au JeuRetro
                {
                    j = new JeuRetro();

                    tmp.Init(9);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    (j as JeuRetro).Etat = tmp.UserText;

                    tmp.Init(10);
                    cli.Update();
                    tmp.handleInput(Console.ReadKey(true).Key);
                    (j as JeuRetro).Notice = (tmp.UserText == "oui");
                }
                else
                {
                    j = new Jeu();
                }

                tmp.Init(0);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                j.Nom = tmp.UserText;

                tmp.Init(1);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                j.Description = tmp.UserText;

                tmp.Init(2);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                j.Plateforme = tmp.UserText;

                tmp.Init(3);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                j.Editeur = tmp.UserText;

                tmp.Init(4);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                string s = tmp.UserText;
                j.Genre = (Genre)Enum.Parse(typeof(Genre), s, true);

                tmp.Init(5);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                j.Prix = Double.Parse(tmp.UserText);

                tmp.Init(6);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                int jour = Int32.Parse(tmp.UserText.Split('/')[0]);
                int mois = Int32.Parse(tmp.UserText.Split('/')[1]);
                int annee = Int32.Parse(tmp.UserText.Split('/')[2]);
                j.Sortie = new DateTime(annee, mois, jour);

                tmp.Init(7);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                j.Reconditionne = (tmp.UserText == "oui");

                cli.DeleteTop();

                //j.input();
                c.Add(j);
            }

            else if (command == 1)
            {
                CLIInputWindow nameInput = new CLIInputWindow(50, 3, 50, "Entrez le nom du jeu a supprimer");
                cli.AddElement(nameInput);
                cli.Update();
                nameInput.handleInput(Console.ReadKey(true).Key);

                //c.Remove(new Jeu(nameInput.Text));
            }

            else if (command == 2)
            {
                CLIMenu fieldSelector = new CLIMenu(35, 5);
                fieldSelector.Init(2);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= 20 && command < 30)
            {
                switch (command)
                {
                    case 20: c.Sort("nom", false); break;
                    case 21: c.Sort("description", false); break;
                    case 22: c.Sort("plateforme", false); break;
                    case 23: c.Sort("editeur", false); break;
                    case 24: c.Sort("genre", false); break;
                    case 25: c.Sort("prix", false); break;
                    case 26: c.Sort("sortie", false); break;
                    case 27: c.Sort("reconditionne", false); break;
                }

                cli.DeleteTop(); //pour supprimer le menu.
            }

            else if (command == 3)
            {
                CLIMenu fieldSelector = new CLIMenu(35, 5);
                fieldSelector.Init(3);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= 30 && command < 40)
            {
                CLIInputWindow tmp = new CLIInputWindow(55, 5, 40, "");
                tmp.Init(command - 20);
                
                cli.AddElement(tmp);
                cli.Update();
                tmp.handleInput(Console.ReadKey(true).Key);
                
                switch(command)
                {
                    case 30: Program.searchResult = new EnsembleJeux(c.GetEnsembleJeux().Search("nom", tmp.UserText)); break;
                    case 31: Program.searchResult = new EnsembleJeux(c.GetEnsembleJeux().Search("description", tmp.UserText)); break;
                    case 32: Program.searchResult = new EnsembleJeux(c.GetEnsembleJeux().Search("plateforme", tmp.UserText)); break;
                    case 33: Program.searchResult = new EnsembleJeux(c.GetEnsembleJeux().Search("editeur", tmp.UserText)); break;
                    case 34: Program.searchResult = new EnsembleJeux(c.GetEnsembleJeux().Search("genre", tmp.UserText)); break;
                    case 35: Program.searchResult = new EnsembleJeux(c.GetEnsembleJeux().Search("prix", tmp.UserText)); break;
                    case 36: Program.searchResult = new EnsembleJeux(c.GetEnsembleJeux().Search("sortie", tmp.UserText)); break;
                    case 37: Program.searchResult = new EnsembleJeux(c.GetEnsembleJeux().Search("reconditionne", tmp.UserText)); break;
                }

                cli.DeleteTop();    //on supprime tmp
                cli.DeleteTop();    //on supprime le menu de séléction 

                Program.state = 2;
                Program.table.Clear();
                Program.updateMainTable();
            }
        }
    }
}
