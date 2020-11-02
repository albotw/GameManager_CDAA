using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using projet_CDAA_2020_2021.CLI;
using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.jeux;

using static projet_CDAA_2020_2021.commands.Command;
using static projet_CDAA_2020_2021.core.jeux.FieldJeu;

namespace projet_CDAA_2020_2021.commands
{
    class CommandesJeux
    {
        public static void HandleCommand(Command command)
        {
            CLIManager cli = Program.cli;
            Catalogue c = Program.c;

            if (command == AjouterJeu)
            {
                Jeu j;

                CLIInputWindow tmp = new CLIInputWindow(50, 3, 50, "");
                tmp.Init(8);
                cli.Interrupt(tmp);

                if (tmp.UserText == "oui")  //pour les params spécifiques au JeuRetro
                {
                    j = new JeuRetro();

                    tmp.Init(9);
                    cli.Interrupt(tmp);
                    (j as JeuRetro).Etat = tmp.UserText;

                    tmp.Init(10);
                    cli.Interrupt(tmp);
                    (j as JeuRetro).Notice = (tmp.UserText == "oui");
                }
                else
                {
                    j = new Jeu();
                }

                tmp.Init(0);
                cli.Interrupt(tmp);
                j.Nom = tmp.UserText;

                tmp.Init(1);
                cli.Interrupt(tmp);
                j.Description = tmp.UserText;

                tmp.Init(2);
                cli.Interrupt(tmp);
                j.Plateforme = tmp.UserText;

                tmp.Init(3);
                cli.Interrupt(tmp);
                j.Editeur = tmp.UserText;

                tmp.Init(4);
                cli.Interrupt(tmp);
                string s = tmp.UserText;
                j.Genre = (Genre)Enum.Parse(typeof(Genre), s, true);

                tmp.Init(5);
                cli.Interrupt(tmp);
                j.Prix = Double.Parse(tmp.UserText);

                tmp.Init(6);
                cli.Interrupt(tmp);
                int jour = Int32.Parse(tmp.UserText.Split('/')[0]);
                int mois = Int32.Parse(tmp.UserText.Split('/')[1]);
                int annee = Int32.Parse(tmp.UserText.Split('/')[2]);
                j.Sortie = new DateTime(annee, mois, jour);

                tmp.Init(7);
                cli.Interrupt(tmp);
                j.Reconditionne = (tmp.UserText == "oui");

                //j.input();
                c.Add(j);
            }

            else if (command == SupprimerJeu)  //suppression d'un jeu, l'utilisateur n'a qu'a rentrer le nom du jeu pour le supprimer.
            {
                CLIInputWindow nameInput = new CLIInputWindow(50, 3, 50, "Entrez le nom du jeu a supprimer");
                cli.Interrupt(nameInput);

                c.Remove(new Jeu(nameInput.UserText));
                Program.tableJeux.Clear();
                Program.UpdateMainTable();
            }

            else if (command == TrierJeu)  //partie 1 du tri: création du menu de séléction de champ de tri
            {
                CLIMenu fieldSelector = new CLIMenu(35, 1);
                fieldSelector.Init(2);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= TriNomJeu && command <= TriReconditionneJeu) //partie 2 du tri: application sur la table
            {
                switch (command)
                {
                    case TriNomJeu: c.Sort("jeux", Nom, false); break;
                    case TriDescriptionJeu: c.Sort("jeux", Description, false); break;
                    case TriPlateformeJeu: c.Sort("jeux", Plateforme, false); break;
                    case TriEditeurJeu: c.Sort("jeux", Editeur, false); break;
                    case TriGenreJeu: c.Sort("jeux", FieldJeu.Genre, false); break;
                    case TriPrixJeu: c.Sort("jeux", Prix, false); break;
                    case TriSortieJeu: c.Sort("jeux", Sortie, false); break;
                    case TriReconditionneJeu: c.Sort("jeux", Reconditionne, false); break;
                }

                cli.DeleteTop(); //pour supprimer le menu.
            }

            else if (command == RechercherJeu)  //partie 1 de la recherche: création du menu de séléction de champ de recherche
            {
                CLIMenu fieldSelector = new CLIMenu(35, 1);
                fieldSelector.Init(3);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= RechNomJeu && command <= RechReconditionneJeu) //partie 2 de la recherche: saisie de la valeur du champ, application de la recherche et mise a jour de la table d'affichage
            {
                CLIInputWindow tmp = new CLIInputWindow(55, 1, 40, "");
                tmp.Init((int)command - 30);

                cli.AddElement(tmp);
                cli.Update();
                tmp.HandleInput(Console.ReadKey(true).Key);

                switch (command)
                {
                    case RechNomJeu: Program.searchResultJeux = new EnsembleJeux(c.GetLesJeux().Search(Nom, tmp.UserText)); break;
                    case RechDescriptionJeu: Program.searchResultJeux = new EnsembleJeux(c.GetLesJeux().Search(Description, tmp.UserText)); break;
                    case RechPlateformeJeu: Program.searchResultJeux = new EnsembleJeux(c.GetLesJeux().Search(Plateforme, tmp.UserText)); break;
                    case RechEditeurJeu: Program.searchResultJeux = new EnsembleJeux(c.GetLesJeux().Search(Editeur, tmp.UserText)); break;
                    case RechGenreJeu: Program.searchResultJeux = new EnsembleJeux(c.GetLesJeux().Search(FieldJeu.Genre, tmp.UserText)); break;
                    case RechPrixJeu: Program.searchResultJeux = new EnsembleJeux(c.GetLesJeux().Search(Prix, tmp.UserText)); break;
                    case RechSortieJeu: Program.searchResultJeux = new EnsembleJeux(c.GetLesJeux().Search(Sortie, tmp.UserText)); break;
                    case RechReconditionneJeu: Program.searchResultJeux = new EnsembleJeux(c.GetLesJeux().Search(Reconditionne, tmp.UserText)); break;
                }

                cli.DeleteTop();    //on supprime tmp
                cli.DeleteTop();    //on supprime le menu de séléction 

                Program.state = 2;
                Program.tableJeux.Clear();
                Program.UpdateMainTable();
            }
        }
    }
}
