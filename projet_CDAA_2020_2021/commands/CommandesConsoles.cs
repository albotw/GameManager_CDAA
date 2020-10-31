using projet_CDAA_2020_2021.CLI;
using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Console = projet_CDAA_2020_2021.core.consoles.Console;

namespace projet_CDAA_2020_2021.commands
{
    class CommandesConsoles
    {

        public static void HandleCommand(int command)
        {
            CLIManager cli = Program.cli;
            Catalogue cat = Program.c;

            if (command == 100)
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

            else if (command == 101)
            {
                CLIInputWindow nameInput = new CLIInputWindow(50, 3, 50, "Entrez le nom de la console a supprimer");
                cli.AddElement(nameInput);
                cli.Update();
                nameInput.HandleInput(System.Console.ReadKey(true).Key);
                cli.DeleteTop();

                cat.Remove(new Console(nameInput.UserText));
                Program.tableJeux.Clear();
                Program.updateMainTable();
            }

            else if (command == 102)
            {
                CLIMenu fieldSelector = new CLIMenu(35, 1);
                fieldSelector.Init(4);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= 120 && command < 127)
            {
                switch(command)
                {
                    case 120: cat.Sort("consoles", "nom", false); break;
                    case 121: cat.Sort("consoles", "fabriquant", false); break;
                    case 122: cat.Sort("consoles", "generation", false); break;
                    case 123: cat.Sort("consoles", "sortie", false); break;
                    case 124: cat.Sort("consoles", "ports", false); break;
                    case 125: cat.Sort("consoles", "support", false); break;
                    case 126: cat.Sort("consoles", "type", false); break;
                }

                cli.DeleteTop();
            }

            else if (command == 103)
            {
                CLIMenu fieldSelector = new CLIMenu(35, 1);
                fieldSelector.Init(5);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= 130 && command < 137)
            {
                CLIInputWindow tmp = new CLIInputWindow(55, 1, 40, "");
                tmp.Init(command - 119);

                cli.AddElement(tmp);
                cli.Update();
                tmp.HandleInput(System.Console.ReadKey(true).Key);

                switch(command)
                {
                    //TODO: Faire casts pour éviter les exceptions.
                    case 130: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Nom, tmp.UserText)); break;
                    case 131: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Fabriquant, tmp.UserText)); break;
                    case 132: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Generation, tmp.UserText)); break;
                    case 133: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Sortie, tmp.UserText)); break;
                    case 134: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Ports, tmp.UserText)); break;
                    case 135: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Support, tmp.UserText)); break;
                    case 136: Program.searchResultConsoles = new EnsembleConsoles(cat.GetLesConsoles().Search(FieldConsole.Type, tmp.UserText)); break;
                }

                cli.DeleteTop();        //suppprime tmp
                cli.DeleteTop();        //Supprime FieldSelector.

                Program.state = 3;
                Program.tableJeux.Clear();
                Program.updateMainTable();
            }
        }
    }
}
