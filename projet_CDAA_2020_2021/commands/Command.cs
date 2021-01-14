namespace projet_CDAA_2020_2021.commands
{
    public enum Command : int
    {
        //=-=-=-=-=-=-=-=-=- COMMANDES GENERALES =-=-=-=-=-=-=-=-=-
        AfficherTousJeux =          -1,
        AfficherTousConsoles =      -2,

        //=-=-=-=-=-=-=-=-=- COMMANDES JEUX=-=-=-=-=-=-=-=-=-
        AjouterJeu =                 0,
        SupprimerJeu =               1,
        TrierJeu =                   2,
        RechercherJeu =              3,
        //--- commandes tri jeu ---
        TriNomJeu =                  20,
        TriDescriptionJeu =          21,
        TriPlateformeJeu =           22,
        TriEditeurJeu =              23,
        TriGenreJeu =                24,
        TriPrixJeu =                 25,
        TriSortieJeu =               26,
        TriReconditionneJeu =        27,
        //--- commandes recherche jeu ---
        RechNomJeu =                 30,
        RechDescriptionJeu =         31,
        RechPlateformeJeu =          32,
        RechEditeurJeu =             33,
        RechGenreJeu =               34,
        RechPrixJeu =                35,
        RechSortieJeu =              36,
        RechReconditionneJeu =       37,

        //=-=-=-=-=-=-=-=-=- COMMANDES CONSOLE=-=-=-=-=-=-=-=-=-
        AjouterConsole =             100,
        SupprimerConsole =           101,
        TrierConsole =               102,
        RechercherConsole =          103,
        //--- commandes tri console ----
        TriNomConsole =              120,
        TriFabriquantConsole =       121,
        TriGenerationConsole =       122,
        TriSortieConsole =           123,
        TriPortsConsole =            124,
        TriSupportConsole =          125,
        TriTypeConsole =             126,
        //--- commandes recherche console ---
        RechNomConsole =             130,
        RechFabriquantConsole =      131,
        RechGenerationConsole =      132,
        RechSortieConsole =          133,
        RechPortsConsole =           134,
        RechSupportConsole =         135,
        RechTypeConsole =            136,

    }
}
