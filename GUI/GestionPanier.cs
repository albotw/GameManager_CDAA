using projet_CDAA_2020_2021.core.datastructures;
using projet_CDAA_2020_2021.core.jeux;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Console = projet_CDAA_2020_2021.core.consoles.Console;

namespace GUI
{
    public partial class GestionPanier : Form
    {
        private Panier<Jeu> panierJeux;
        private Panier<Console> panierConsoles;
        private Main m;

        private double total = 0;

        public GestionPanier(Main m)
        {
            this.m = m;
            InitializeComponent();
            panierJeux = new Panier<Jeu>();
            panierConsoles = new Panier<Console>();

            InitListes();
        }

        private void UpdateTotal()
        {
            if (total < 0.000001)
            {
                total = 0;
            }

            Total.Text = total + " €";
        }

        public void GrabFromMain(object o)
        {
            if (o is Jeu || o is JeuRetro)
            {
                panierJeux.Add(o as Jeu);
                total += (o as Jeu).Prix;
            }
            else if (o is Console)
            {
                panierConsoles.Add(o as Console);
                total += (o as Console).Prix;
            }

            UpdateTotal();
            InitListes();
        }

        public void InitListes()
        {
            Jeux.BeginUpdate();
            Jeux.Items.Clear();
            for (int i = 0; i < panierJeux.size; i++)
            {
                Jeux.Items.Add(panierJeux.Get(i).Nom);
            }
            Jeux.EndUpdate();

            Consoles.BeginUpdate();
            Consoles.Items.Clear();
            for (int i = 0; i < panierConsoles.size; i++)
            {
                Consoles.Items.Add(panierConsoles.Get(i).Nom);
            }
            Consoles.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (Jeux.SelectedItem != null)
                {
                    Jeu toRemove = panierJeux.Find(new Jeu(Jeux.SelectedItem.ToString()));
                    total -= toRemove.Prix;
                    m.GrabFromPanier(toRemove);
                    panierJeux.Remove(toRemove);
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                if (Consoles.SelectedItem != null)
                {
                    Console toRemove = panierConsoles.Find(new Console(Consoles.SelectedItem.ToString()));
                    total -= toRemove.Prix;
                    m.GrabFromPanier(toRemove);
                    panierConsoles.Remove(toRemove);
                }
            }

            UpdateTotal();
            InitListes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonction non implémentée", "Paiement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
