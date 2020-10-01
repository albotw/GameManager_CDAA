using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.CLI;
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
            c.Init();

            if (false)
            {
                cli = new CLIManager();
                cli.init();
                cli.Update();
                cli.Loop();
            }

            Jeux j2 = new Jeux(c.Sort());
        }

        public static void dispatchCommand(int command)
        {
            switch (command)
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
