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
            TriFieldCB.Enabled = false;
            TriButton.Enabled = false;
            RechercheFieldCB.Enabled = false;
            GenreCB.Enabled = false;
            CategorieButton.Enabled = false;
        }

        public void unlockUI()
        {
            AjouterButton.Enabled = true;
            SupprimerButton.Enabled = true;
            ModifierButton.Enabled = true;
            VisualiserButton.Enabled = true;
            TriFieldCB.Enabled = true;
            TriButton.Enabled = true;
            RechercheFieldCB.Enabled = true;
            GenreCB.Enabled = true;
            CategorieButton.Enabled = true;
        }

        public void LinkPhotos()
        {
            //Liaison entre les jeux et leurs photos.
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid").Photo = Properties.Resources.MGS;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid 2: Subsistance").Photo = Properties.Resources.MGS2;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid V: The Phantom Pain").Photo = Properties.Resources.MGSV;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Dragon Ball: Fighter Z").Photo = Properties.Resources.DBFZ;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Minecraft RTX Edition").Photo = Properties.Resources.MC_RTX;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Genshin Impact").Photo = Properties.Resources.GENSHIN;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Mario Bros 3").Photo = Properties.Resources.SMB3;

            //liaison entre les consoles et leurs photos
            cat.GetLesConsoles().SearchSingle(FieldConsole.Nom, "Switch").Photo = Properties.Resources.SWITCH;
            cat.GetLesConsoles().SearchSingle(FieldConsole.Nom, "Super NES").Photo = Properties.Resources.SNES;
            cat.GetLesConsoles().SearchSingle(FieldConsole.Nom, "PlayStation 3").Photo = Properties.Resources.PS3;
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
                    pb.Image = c.Photo;
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
                TriFieldCB.Items.AddRange(FieldConsole.GetNames());
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
            AddJeu sdlg = new AddJeu();
            sdlg.ShowDialog();

            if (sdlg.Grab)
            {
                cat.Add(sdlg.Out);
                InitPhotos();
            }
            /*
             * Pas besoin de donner un type autre que Object pour le passage de la dlg à catalogue.
             * Comme catalogue vérifie le type à l'ajout pour le placer dans le bon ensemble.
             */
        }

        private void VisualiserButton_Click(object sender, EventArgs e)
        {
            if (state == AppState.ShowJeux)
            {
                TreeViewGenre tvg = new TreeViewGenre();
                tvg.ShowDialog();
            }
            else if (state == AppState.ShowConsoles)
            {
                TreeViewSupport tvs = new TreeViewSupport();
                tvs.ShowDialog();
            }
        }

        private void TriFieldCB_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void TriButton_Click(object sender, EventArgs e)
        {
            if (state == AppState.ShowJeux)
            {
                if (TriFieldCB.SelectedItem != null)
                {
                    cat.GetLesJeux().Sort((FieldJeu)TriFieldCB.SelectedItem.ToString(), false);
                    toDisplay_jeux = cat.GetLesJeux().GetAll();
                    InitPhotos();
                }
            }
            else if (state == AppState.ShowConsoles)
            {
                if (TriFieldCB.SelectedItem != null)
                {
                    cat.GetLesConsoles().Sort((FieldConsole)TriFieldCB.SelectedItem.ToString(), false);
                    toDisplay_consoles = cat.GetLesConsoles().GetAll();
                    InitPhotos();
                }
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
            else if (state == AppState.ShowConsoles)
            {
                if ((FieldConsole)RechercheFieldCB.SelectedItem.ToString() == FieldConsole.Support)
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
            else if (state == AppState.ShowConsoles)
            {
                if (RechercheFieldCB.SelectedItem != null)
                {
                    FieldConsole champ = (FieldConsole)RechercheFieldCB.SelectedItem.ToString();
                    if((FieldConsole)RechercheFieldCB.SelectedItem.ToString() == FieldConsole.Support)
                    {
                        if (GenreCB.SelectedItem != null)
                        {
                            toDisplay_consoles = cat.GetLesConsoles().Search(champ, GenreCB.SelectedItem.ToString());
                        }
                    }
                    else
                    {
                        toDisplay_consoles = cat.GetLesConsoles().Search(champ, RechercheValueTB.Text);
                    }

                    state = AppState.ShowSearchConsoles;
                    lockUI();
                    RechercheButton.Text = "Réinitialiser";
                    InitPhotos();
                }
            }
            else if (state == AppState.ShowSearchConsoles)
            {
                unlockUI();
                RechercheButton.Text = "Rechercher";
                state = AppState.ShowConsoles;
                toDisplay_consoles = cat.GetLesConsoles().GetAll();
                InitPhotos();
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            Remove sdlg = new Remove();
            sdlg.ShowDialog();

            if (sdlg.Delete)
            {
                if (state == AppState.ShowJeux)
                    cat.Remove(new Jeu(sdlg.DeleteName));
                else if (state == AppState.ShowConsoles)
                    cat.Remove(new Console(sdlg.DeleteName));

                InitPhotos();
            }
        }

        private void jeuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = AppState.ShowJeux;
            InitPhotos();
            InitGenreCB();
            InitTriFieldCB();
            InitRechercheFieldCB();
        }

        private void consolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = AppState.ShowConsoles;
            InitPhotos();
            InitGenreCB();
            InitTriFieldCB();
            InitRechercheFieldCB();
        }
    }
}
