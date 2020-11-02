using System;
using System.Linq.Expressions;
using projet_CDAA_2020_2021.CLI;
using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.core.datastructures;

namespace projet_CDAA_2020_2021
{
    class TestPanier
    {
        public static Panier<Jeu> p;

        public static void Init()
        {
            p = new Panier<Jeu>();
            p.Add(new Jeu("Metal Gear Solid 2: Subsistance", "Un jeu de Hideo Kojima", "PC, PS2", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2003, 07, 14), false));
            p.Add(new Jeu("Metal Gear Solid", "Un jeu de Hideo Kojima", "PC, PS1, GameCube", "Konami, avec Hideo Kojima", Genre.Infiltration, 9.99, new DateTime(2000, 04, 21), false));
            p.Add(new Jeu("Metal Gear Solid V: The Phantom Pain", "Un jeu de Hideo Kojima", "PC, PS4, PS3", "Konami avec Hideo Kojima", Genre.Infiltration, 50.00, new DateTime(2013, 08, 22), false));
            p.Add(new Jeu("Dragon Ball: Fighter Z", "JAPOOON", "PC, PS4, XBOX ONE", "Akira Toriyama", Genre.Combat, 40.00, new DateTime(2017, 05, 13), false));
            p.Add(new Jeu("Minecraft RTX Edition", "Enfin des graphismes sympas", "PC", "Microsoft, Mojang", Genre.Aventure, 25.00, new DateTime(2018, 10, 12), false));
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
                Console.WriteLine("1 | Ajouter un jeu au panier");
                Console.WriteLine("2 | Supprimer un jeu du panier");
                Console.WriteLine("3 | Trier le panier");
                Console.WriteLine("4 | Quitter");
                Console.WriteLine("\n\n");
                Console.WriteLine(p.ToString());

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Jeu j = new Jeu();
                        j.Input();

                        try
                        {
                            p.Add(j);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        break;

                    case "2":
                        Console.WriteLine("Entrez le nom du jeu a supprimer");
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
