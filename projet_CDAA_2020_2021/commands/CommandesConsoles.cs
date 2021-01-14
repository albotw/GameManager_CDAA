using projet_CDAA_2020_2021.CLI;
using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using static projet_CDAA_2020_2021.commands.Command;
using static projet_CDAA_2020_2021.core.consoles.FieldConsole;

using Console = projet_CDAA_2020_2021.core.consoles.Console;

namespace projet_CDAA_2020_2021.commands
{
    class CommandesConsoles
    {

        public static void HandleCommand(Command command)
        {
            CLIManager cli = Program.cli;
            Catalogue cat = Program.c;

            if (command == AjouterConsole)
            {
                Console c = new Console();

                CLIInputWindow tmp = new CLIInputWindow(50, 3, 50, "");
                tmp.Init(11);
                cli.Interrupt(tmp);
                c.Nom = tmp.UserText;

                tmp.Init(12);
                cli.Interrupt(tmp);
                c.Fabriquant = tmp.UserText;

                tmp.Init(13);
                cli.Interrupt(tmp);
                c.Generation = Int32.Parse(tmp.UserText);

                tmp.Init(14);
                cli.Interrupt(tmp);
                int jour = Int32.Parse(tmp.UserText.Split('/')[0]);
                int mois = Int32.Parse(tmp.UserText.Split('/')[1]);
                int annee = Int32.Parse(tmp.UserText.Split('/')[2]);
                c.Sortie = new DateTime(annee, mois, jour);

                tmp.Init(15);
                cli.Interrupt(tmp);
                c.Ports = Int32.Parse(tmp.UserText);

                tmp.Init(16);
                cli.Interrupt(tmp);
                c.Support = (Support)Enum.Parse(typeof(Support), tmp.UserText, true);

                tmp.Init(17);
                cli.Interrupt(tmp);
                c.Type = tmp.UserText;

                cat.Add(c);
            }

            else if (command == SupprimerConsole)
            {
                CLIInputWindow nameInput = new CLIInputWindow(50, 3, 50, "Entrez le nom de la console a supprimer");
                cli.AddElement(nameInput);
                cli.Update();
                nameInput.HandleInput(System.Console.ReadKey(true).Key);
                cli.DeleteTop();

                cat.Remove(new Console(nameInput.UserText));
                Program.tableJeux.Clear();
                Program.UpdateMainTable();
            }

            else if (command == TrierConsole)
            {
                CLIMenu fieldSelector = new CLIMenu(35, 1);
                fieldSelector.Init(4);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= TriNomConsole && command <= TriTypeConsole)
            {
                switch(command)
                {
                    case TriNomConsole: cat.Sort("consoles", Nom, false); break;
                    case TriFabriquantConsole: cat.Sort("consoles", Fabriquant, false); break;
                    case TriGenerationConsole: cat.Sort("consoles", Generation, false); break;
                    case TriSortieConsole: cat.Sort("consoles", Sortie, false); break;
                    case TriPortsConsole: cat.Sort("consoles", Ports, false); break;
                    case TriSupportConsole: cat.Sort("consoles", FieldConsole.Support, false); break;
                    case TriTypeConsole: cat.Sort("consoles", FieldConsole.Type, false); break;
                }

                cli.DeleteTop();
            }

            else if (command == RechercherConsole)
            {
                CLIMenu fieldSelector = new CLIMenu(35, 1);
                fieldSelector.Init(5);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= RechNomConsole && command <= RechTypeConsole)
            {
                CLIInputWindow tmp = new CLIInputWindow(60, 1, 40, "");
                tmp.Init((int)command - 119);

                cli.AddElement(tmp);
                cli.Update();
                tmp.HandleInput(System.Console.ReadKey(true).Key);

                switch(command)
                {
                    //TODO: Faire casts pour éviter les exceptions.
                    case RechNomConsole: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(Nom, tmp.UserText)); break;
                    case RechFabriquantConsole: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(Fabriquant, tmp.UserText)); break;
                    case RechGenerationConsole: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(Generation, tmp.UserText)); break;
                    case RechSortieConsole: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(Sortie, tmp.UserText)); break;
                    case RechPortsConsole: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(Ports, tmp.UserText)); break;
                    case RechSupportConsole: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Support, tmp.UserText)); break;
                    case RechTypeConsole: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Type, tmp.UserText)); break;
                }

                cli.DeleteTop();        //suppprime tmp
                cli.DeleteTop();        //Supprime FieldSelector.

                Program.state = 3;
                Program.tableJeux.Clear();
                Program.UpdateMainTable();
            }
        }
    }
}
