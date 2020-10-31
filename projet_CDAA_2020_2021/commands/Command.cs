using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_CDAA_2020_2021.commands
{
    public class Command
    {
        public int ID { get; set; }

        private Command(int id) { ID = id; }


        //commandes GENERALES
        public static Command AfficherTousJeux { get { return new Command(-1); } }
        public static Command AfficherTousConsoles { get { return new Command(-2); } }


        //================ COMMANDES JEUX =================
        public static Command AjouterJeu { get { return new Command(0); } }
        public static Command SupprimerJeu { get { return new Command(1); } }
        public static Command TrierJeu { get { return new Command(2); } }
        public static Command RechercherJeu { get { return new Command(3); } }
        //--- spécifications du champ ou appliquer le tri ---
        public static Command TriNomJeu { get { return new Command(20); } }
        public static Command TriDescriptionJeu { get { return new Command(21); } }
        public static Command TriPlateformeJeu { get { return new Command(22); } }
        public static Command TriEditeurJeu { get { return new Command(23); } }
        public static Command TriGenreJeu { get { return new Command(24); } }
        public static Command TriPrixJeu { get { return new Command(25); } }
        public static Command TriSortieJeu { get { return new Command(26); } }
        public static Command TriReconditionneJeu { get { return new Command(27); } }
        //--- spécification du champ ou appliquer la recherche ---
        public static Command RechNomJeu { get { return new Command(30); } }
        public static Command RechDescriptionJeu { get { return new Command(31); } }
        public static Command RechPlateformeJeu { get { return new Command(32); } }
        public static Command RechEditeurJeu { get { return new Command(33); } }
        public static Command RechGenreJeu { get { return new Command(34); } }
        public static Command RechPrixJeu { get { return new Command(35); } }
        public static Command RechSortieJeu { get { return new Command(36); } }
        public static Command RechReconditionneJeu { get { return new Command(37); } }


        //======================= COMMANDES CONSOLES =================================
        public static Command AjouterConsole { get { return new Command(100); } }
        public static Command SupprimerConsole { get { return new Command(100); } }
        public static Command TrierConsole { get { return new Command(100); } }
        public static Command RechercherConsole { get { return new Command(100); } }
    }
}
