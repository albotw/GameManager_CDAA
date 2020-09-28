using projet_CDAA_2020_2021.core;
using System;

namespace projet_CDAA_2020_2021
{
    class Program
    {
        public static Catalogue c;

        public static CLIManager cli;
        static void Main()
        {
            c = new Catalogue();

            if (true)
            {
                cli = new CLIManager();
                cli.init();
                cli.Update();

                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (cli.userPos != 0) cli.userPos--;
                            cli.Update();
                            break;
                        case ConsoleKey.DownArrow:
                            if (cli.userPos != 3) cli.userPos++;
                            cli.Update();
                            break;
                        case ConsoleKey.Enter:
                            cli.WriteMiddle("selected: " + cli.userPos, 40);
                            dispatchCommand(cli.userPos);
                            break;
                    }
                } while (cki.Key != ConsoleKey.Escape);
            }
            
        }

        public static void dispatchCommand(int command)
        {
            switch(command)
            {
                case 0:
                    Jeu j = new Jeu();
                    j.input();
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
