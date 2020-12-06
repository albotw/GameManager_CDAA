using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.CLI;
using System;
using System.Runtime.CompilerServices;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.commands;
using projet_CDAA_2020_2021.core.accessoires;
using projet_CDAA_2020_2021.datastructures;

namespace projet_CDAA_2020_2021.core
{
    class TestPanier
    {
        public static Panier<Jeu> p;

        public static void Init()
        {
            p = new Panier<Jeu>();
            p.Add(new Jeu("Metal Gear Solid 2: Subsistance", "Un jeu de Hideo Kojima", "PC, PS2", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2003, 07, 14), false));
            p.Add(new Jeu("Metal Gear Solid", "Un jeu de Hideo Kojima", "PC, PS1, GameCube", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2000, 04, 21), false));
            p.Add(new Jeu("Genshin Impact", "Copier Coller de Zelda BotW", "PC, PS4, iOS, Android", "MiHoYo", Genre.Action_RPG, 0.00, new DateTime(2020, 09, 25), false));
            p.Add(new JeuRetro("Mario Bros 3", "Un clasiqque des jeux de plateforme", "Super NES", "Nintendo", Genre.Plateforme, 40.00, new DateTime(1991, 11, 30), false, "presque neuf", true));
            Loop();
        }

        public static void Loop()
        {
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Ajouter un jeu au Panier");
                Console.WriteLine("2 - Supprimer un jeu du Panier");
                Console.WriteLine("3 - Faire un tri du panier");
                Console.WriteLine(p.ToString());

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Jeu J = new Jeu();
                        J.input();

                        try
                        {
                            p.Add(J);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        break;

                    case "2":

                        Console.WriteLine("Quel est le jeu à supprimer");
                        string name = Console.ReadLine();
                        p.Remove(new Jeu(name));
                        break;

                    case "3":

                        p.Sort();
                        break;
                }

            } while (input != "4");
        }
    }
}



     
    
   