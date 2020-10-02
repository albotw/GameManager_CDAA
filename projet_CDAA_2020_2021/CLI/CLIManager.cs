using projet_CDAA_2020_2021.CLI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace projet_CDAA_2020_2021.CLI
{
    class CLIManager
    {
        public static int windowWidth = 220;
        public static int windowHeight = 60;

        private CLIWindow w;
        private CLIWindow w2;

        private CLIMenu menu;

        private Stack<CLIElement> drawStack;

        public void init()
        {
            Console.Title = "Gestion des jeux | 4 entrées";
            ConsoleHelper.SetCurrentFont("Cascadia code", 15);
            drawStack = new Stack<CLIElement>();


            Console.CursorVisible = false;
            //Console.WriteLine(Console.LargestWindowWidth);
            //Console.WriteLine(Console.LargestWindowHeight);
            Console.SetWindowSize(windowWidth, windowHeight);

            w = new CLIWindow(0, 0, 220, 60);
            drawStack.Push(w);
            //w2 = new CLIWindow(60, 4, 10, 10);
            //drawStack.Push(w2);
            //menu = new CLIMenu(60, 4);
            //menu.Init(1);
            //drawStack.Push(menu);
            CLIInput entree = new CLIInput(60, 4, 50, "Entrez le nom du jeu");
            drawStack.Push(entree);
        }

        public void Loop()
        {
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                drawStack.Peek().handleInput(cki.Key);
                Update();
            } while (cki.Key != ConsoleKey.Escape);
        }

        public void Update()
        {
            //Console.Clear();
            CLIElement[] tmp = drawStack.ToArray();
            for (int i = tmp.Length - 1; i >= 0; i--)
            {
                tmp[i].Clear();
                tmp[i].Draw();
            }

            WriteMiddle("--- Gestionnaire de catalogue ---", 2);
            WriteMiddle("+---------------------------------+--------------------------------------+-------------------+------------+-----+--------+------------+-----+", 30);
            WriteMiddle("| Call of Duty Modern Warfare	  | Jeu de guerre développé par treyarch | PC, PS4, XBOX ONE | Activision | FPS | 45.0 € | 15/04/2020 | oui |", 31);
            WriteMiddle("+---------------------------------+--------------------------------------+-------------------+------------+-----+--------+------------+-----+", 32);
        }

        public void WriteMiddle(string text, int line)
        {
            int cursorX = (windowWidth / 2) - (text.Length / 2);
            Console.SetCursorPosition(cursorX, line);
            Console.WriteLine(text);
        }
    }
}
