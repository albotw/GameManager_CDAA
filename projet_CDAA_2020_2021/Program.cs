using System;
using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.console;

namespace projet_CDAA_2020_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Catalogue c = new Catalogue();

            Jeu j = new Jeu();

            c.add(j);
            Console.WriteLine(c.ToString());

            //j.input();
            Console.WriteLine(j.ToString());
            j.nom = "nom test";
            Jeu j2 = new Jeu("jeu", "jeu", "jeu", "jeu", Genre.Action_RPG, 15.0, DateTime.Now, false);
            Console.WriteLine(j == j2);

            c.add(j2);
            Console.WriteLine(c.ToString());
            c.delete(j2);
            Console.WriteLine(c.ToString());

            Jeu tmp = c.getJeu("nom test");
        }
    }
}
