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
using Console = projet_CDAA_2020_2021.core.consoles.Console;

namespace GUI
{
    public partial class Main : Form
    {
        public static Catalogue cat;

        public static AppState state = 0;

        public static List<Jeu> toDisplay_jeux;

        public static List<Console> toDisplay_consoles;

        public Main()
        {
            InitializeComponent();

            cat = new Catalogue();
            cat.Init();

            /*initialisation des listes d'affichages*/
            toDisplay_jeux = cat.GetLesJeux().GetAll();
            toDisplay_consoles = cat.GetLesConsoles().GetAll();

            CenterTextInfoTB();
            GenreCB.Enabled = false;

            LinkPhotos();
            InitPhotos();

            /*Initalisation des comboBox de l'interface */
            InitGenreCB();
            InitRechercheFieldCB();
            InitTriFieldCB();
        }

        public static void ImageClicked(object sender, EventArgs e)
        {
            
        }

        public void lockUI()
        {
            AjouterButton.Enabled = false;
            SupprimerButton.Enabled = false;
            ModifierButton.Enabled = false;
            VisualiserButton.Enabled = false;
            SwapCategorieButton.Enabled = false;
            TriFieldCB.Enabled = false;
            TriButton.Enabled = false;
            RechercheFieldCB.Enabled = false;
            GenreCB.Enabled = false;
        }

        public void unlockUI()
        {
            AjouterButton.Enabled = true;
            SupprimerButton.Enabled = true;
            ModifierButton.Enabled = true;
            VisualiserButton.Enabled = true;
            SwapCategorieButton.Enabled = true;
            TriFieldCB.Enabled = true;
            TriButton.Enabled = true;
            RechercheFieldCB.Enabled = true;
            GenreCB.Enabled = true;
        }

        public void LinkPhotos()
        {
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid").Photo = Properties.Resources.MGS;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid 2: Subsistance").Photo = Properties.Resources.MGS2;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid V: The Phantom Pain").Photo = Properties.Resources.MGSV;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Dragon Ball: Fighter Z").Photo = Properties.Resources.DBFZ;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Minecraft RTX Edition").Photo = Properties.Resources.MC_RTX;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Genshin Impact").Photo = Properties.Resources.GENSHIN;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Mario Bros 3").Photo = Properties.Resources.SMB3;
        }

        public void CenterTextInfoTB()
        {
            /*Mise en forme du texte des informations pour qu'il soit au centre*/
            InfoTB.SelectAll();
            InfoTB.SelectionAlignment = HorizontalAlignment.Center;
            InfoTB.DeselectAll();
        }

        public void InitPhotos()
        {
            ImagePanel.Controls.Clear();

            if (state == AppState.ShowJeux || state == AppState.ShowSearchJeux)
            {
                foreach(Jeu j in toDisplay_jeux)
                {
                    PictureBox pb = new PictureBox();
                    pb.Name = j.Nom;
                    pb.Image = j.Photo;
                    pb.Size = new Size(300, 300);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    pb.Click += (o, i) =>
                    {
                        InfoTB.Text = cat.GetLesJeux().SearchSingle(FieldJeu.Nom, (o as PictureBox).Name).ToString();
                        PrixLabel.Text = "Prix: " + cat.GetLesJeux().SearchSingle(FieldJeu.Nom, (o as PictureBox).Name).Prix + " €";

                        CenterTextInfoTB();
                    };

                    ImagePanel.Controls.Add(pb);
                }
            }
            else if (state == AppState.ShowConsoles || state == AppState.ShowSearchConsoles)
            {
                foreach (Console c in toDisplay_consoles)
                {
                    PictureBox pb = new PictureBox();
                    pb.Name = c.Nom;
                    //TODO: Implémenter les images dans les consoles.
                    //pb.Image = c.Photo;
                    pb.Size = new Size(300, 300);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    pb.Click += (o, i) =>
                    {
                        InfoTB.Text = cat.GetLesConsoles().SearchSingle(FieldConsole.Nom, (o as PictureBox).Name).ToString();
                        PrixLabel.Text = "Prix: " + cat.GetLesConsoles().SearchSingle(FieldConsole.Nom, (o as PictureBox).Name).Prix + " €";

                        CenterTextInfoTB();
                    };

                    ImagePanel.Controls.Add(pb);
                }
            }
        }


        public void InitTriFieldCB()
        {
            TriFieldCB.Items.Clear();
            if (state == AppState.ShowJeux)
            {
                TriFieldCB.Items.AddRange(FieldJeu.GetNames());
            }
            else if (state == AppState.ShowConsoles)
            {
                TriFieldCB.Items.AddRange(FieldJeu.GetNames());
            }
        }

        public void InitRechercheFieldCB()
        {
            RechercheFieldCB.Items.Clear();
            if (state == AppState.ShowJeux)
            {
                RechercheFieldCB.Items.AddRange(FieldJeu.GetNames());
            }
            else if (state == AppState.ShowConsoles)
            {
                RechercheFieldCB.Items.AddRange(FieldConsole.GetNames());
            }
        }

        public void InitGenreCB()
        {
            //La combobox pour les genre(jeux) sert aussi pour les supports(console)
            GenreCB.Items.Clear();
            if (state == AppState.ShowJeux)
            {
                GenreCB.Items.AddRange(Enum.GetNames(typeof(Genre)));
            }
            else if (state == AppState.ShowConsoles)
            {
                GenreCB.Items.AddRange(Enum.GetNames(typeof(Support)));
            }
        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            SaisieJeuDlg sdlg = new SaisieJeuDlg();
            sdlg.ShowDialog();

            //Ajouter support pour les jeux rétros et les consoles.
            if (sdlg.GrabJeu)
            {
                cat.Add(sdlg.J);
                InitPhotos();
            }
        }

        private void VisualiserButton_Click(object sender, EventArgs e)
        {
            VisuJeuDlg vjdlg = new VisuJeuDlg();
            vjdlg.ShowDialog();
        }

        private void TriFieldCB_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void TriButton_Click(object sender, EventArgs e)
        {
            if (TriFieldCB.SelectedItem != null)
            {
                cat.GetLesJeux().Sort((FieldJeu)TriFieldCB.SelectedItem.ToString(), false);
                toDisplay_jeux = cat.GetLesJeux().GetAll();
                InitPhotos();
            }
        }

        private void RechercheFieldCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state == AppState.ShowJeux)
            {
                if ((FieldJeu)RechercheFieldCB.SelectedItem.ToString() == FieldJeu.Genre)
                {
                    GenreCB.Enabled = true;
                    RechercheValueTB.Enabled = false;
                }
                else
                {
                    GenreCB.Enabled = false;
                    RechercheValueTB.Enabled = true;
                }
            }
        }

        private void RechercheButton_Click(object sender, EventArgs e)
        {
            if (state == AppState.ShowJeux)
            {
                if (RechercheFieldCB.SelectedItem != null)
                {
                    FieldJeu champ = (FieldJeu)RechercheFieldCB.SelectedItem.ToString();

                    /*Recherche par genre*/
                    if ((FieldJeu)RechercheFieldCB.SelectedItem.ToString() == FieldJeu.Genre)
                    {
                        if (GenreCB.SelectedItem != null)
                        {
                            toDisplay_jeux = cat.GetLesJeux().Search(champ, GenreCB.SelectedItem.ToString());
                        }
                    }

                    /*recherche par autre champ*/
                    else
                    {
                        toDisplay_jeux = cat.GetLesJeux().Search(champ, RechercheValueTB.Text);
                    }

                    state = AppState.ShowSearchJeux;
                    lockUI();
                    RechercheButton.Text = "Réinitialiser";
                    InitPhotos();
                }
            }
            else if (state == AppState.ShowSearchJeux)
            {
                unlockUI();
                RechercheButton.Text = "Rechercher";
                state = AppState.ShowJeux;
                toDisplay_jeux = cat.GetLesJeux().GetAll();
                InitPhotos();
            }
        }
    }
}
