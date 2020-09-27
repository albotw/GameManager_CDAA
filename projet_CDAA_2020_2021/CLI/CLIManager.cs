using projet_CDAA_2020_2021.CLI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace projet_CDAA_2020_2021
{
    class CLIManager
    {
        public static int windowWidth = 220;
        public static int windowHeight = 64;

        public int userPos = 0;

        private string[] menu;
        private int menuOffset = 4;

        private CLIWindow w;
        private CLIWindow w2;

        public void init()
        {
            menu = new string[4];

            Console.CursorVisible = false;
            Console.SetWindowSize(windowWidth, windowHeight);

            w = new CLIWindow(0, 0, 220, 64);
            w2 = new CLIWindow(40, 40, 10, 10);

            menu[0] = "[ ] Ajouter un jeu";
            menu[1] = "[ ] Supprimer un jeu";
            menu[2] = "[ ] Rechercher un jeu";
            menu[3] = "[ ] Rechercher un genre";
        }

        public void Update()
        {
            Console.Clear();
            //drawBorder();
            w.Draw();
            w2.Draw();
            WriteMiddle("--- Gestionnaire de catalogue ---", 2);
            WriteMiddle("+---------------------------------+--------------------------------------+-------------------+------------+-----+--------+------------+-----+", 30);
            WriteMiddle("| Call of Duty Modern Warfare	  | Jeu de guerre développé par treyarch | PC, PS4, XBOX ONE | Activision | FPS | 45.0 € | 15/04/2020 | oui |", 31);
            WriteMiddle("+---------------------------------+--------------------------------------+-------------------+------------+-----+--------+------------+-----+", 32);
            DrawMenu();
        }

        public void drawBorder2()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("+");
            Console.SetCursorPosition(219, 63);
            Console.Write("+");
            Console.SetCursorPosition(0, 63);
            Console.Write("+");
            Console.SetCursorPosition(219, 0);
            Console.Write("+");

            for (int i = 1; i < 219; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("=");
                Console.SetCursorPosition(i, 63);
                Console.Write("=");
            }

            for (int i = 1; i < 63; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(219, i);
                Console.Write("|");
            }
        }

        public void WriteMiddle(string text, int line)
        {
            int cursorX = (windowWidth / 2) - (text.Length / 2);
            Console.SetCursorPosition(cursorX, line);
            Console.WriteLine(text);
        }

        public void DrawMenu()
        {
            for(int i = 0; i < menu.Length; i++)
            {
                if (i == userPos)
                {
                    char[] tmp = menu[i].ToCharArray();
                    tmp[1] = 'X';
                    menu[i] = new string(tmp);
                }
                else
                {
                    char[] tmp = menu[i].ToCharArray();
                    tmp[1] = ' ';
                    menu[i] = new string(tmp);
                }

                Console.SetCursorPosition(60, menuOffset + i);
                Console.WriteLine(menu[i]);
            }
        }
    }
}
