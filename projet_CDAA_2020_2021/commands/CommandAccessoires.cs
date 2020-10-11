using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projet_CDAA_2020_2021.CLI;
using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.accessoires;
using Type = projet_CDAA_2020_2021.core.accessoires.Type;

namespace projet_CDAA_2020_2021.commands
{
    class CommandAccessoires
    {
        public static void handleCommand(int command)
        {
            CLIManager cli = Program.cli;
            Catalogue c = Program.c;

            if (command == 100)
            {
                Accessoire a = new Accessoire();

                CLIInputWindow temp = new CLIInputWindow(100, 2, 100, "");

                temp.Init(14);
                cli.AddElement(temp);
                cli.Update();
                temp.handleInput(Console.ReadKey(true).Key);
                a.Nom = temp.UserText;

                temp.Init(11);
                cli.Update();
                temp.handleInput(Console.ReadKey(true).Key);
                a.FabriquantPays = temp.UserText;

                temp.Init(12);
                cli.Update();
                temp.handleInput(Console.ReadKey(true).Key);
                a.Plateforme = temp.UserText;

                temp.Init(13);
                cli.Update();
                temp.handleInput(Console.ReadKey(true).Key);
                String j = temp.UserText;
                a.Type = (Type)Enum.Parse(typeof(Type), j, true);


                cli.DeleteTop();
                c.Add(a);
            }

            else if (command == 101)
            {
                CLIInputWindow nameInput = new CLIInputWindow(100, 2, 100, "Quelle commande voulez vous supprimer ?");
                cli.AddElement(nameInput);
                cli.Update();
                nameInput.handleInput(Console.ReadKey(true).Key);
                cli.DeleteTop();

                c.Remove(new Accessoire(nameInput.UserText));
                Program.table.Clear();
                Program.updateMainTable();

            }

            else if (command == 102)
            {
                CLIMenu fieldSelector = new CLIMenu(35, 5);
                fieldSelector.Init(4);
                cli.AddElement(fieldSelector);
                cli.Update();
            }

            else if (command >= 120 && command <= 123)
            {
                switch( command)
                {
                    case 120: c.Sort("Accessoire", "nom", false); break;
                    case 121: c.Sort("Accessoire", "fabriquandPays", false);break;
                    case 122: c.Sort("Accessoire", "plateforme", false); break;
                    case 123: c.Sort("Accessoire", "type", false); break;
                }
            }

        }
    }
}
