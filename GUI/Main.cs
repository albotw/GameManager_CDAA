using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.jeux;
using projet_CDAA_2020_2021.core.consoles;

namespace GUI
{
    public partial class Main : Form
    {
        public static Catalogue cat;

        private ImageList listeImages;

        private int state = 0;
        // 0 -> afficher tous les jeux;
        // 1 -> afficher toutes les consoles;

        public Main()
        {
            InitializeComponent();

            /*Mise en forme du texte des informations pour qu'il soit au centre*/
            InfoTB.SelectAll();
            InfoTB.SelectionAlignment = HorizontalAlignment.Center;
            InfoTB.DeselectAll();

            cat = new Catalogue();
            cat.Init();
            LinkPhotos();

            /*Initalisation des comboBox de l'interface */
            TriFieldCB.Items.AddRange(Enum.GetNames(typeof(FieldJeu)));
            RechercheFieldCB.Items.AddRange(Enum.GetNames(typeof(FieldJeu)));
            

        }

        public void LinkPhotos()
        {

        }

        public void InitTriFieldCB()
        {
            TriFieldCB.Items.Clear();
            if (state == 0)
            {
                TriFieldCB.Items.AddRange(Enum.GetNames(typeof(FieldJeu)));
            }
            else if (state == 1)
            {
                TriFieldCB.Items.AddRange(Enum.GetNames(typeof(FieldConsole)));
            }
        }

        public void InitRechercheFieldCB()
        {
            RechercheFieldCB.Items.Clear();
            if (state == 0)
            {
                RechercheFieldCB.Items.AddRange(Enum.GetNames(typeof(FieldJeu)));
            }
            else if (state == 1)
            {

            }
        }

        public void InitGenreCB()
        {

        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
