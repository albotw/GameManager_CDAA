using projet_CDAA_2020_2021.core;
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


namespace GUI
{
    public partial class MainForm : Form
    {
        public static Catalogue cat;

        private ImageList listeImages;

        public MainForm()
        {
            InitializeComponent();
            Main m = new Main();
            m.ShowDialog();

            //pour centrer le texte.
            ToStringBox.SelectAll();
            ToStringBox.SelectionAlignment = HorizontalAlignment.Center;
            ToStringBox.DeselectAll();

            cat = new Catalogue();
            cat.Init();
            linkPhotos();
            initGenres();
            initJeux();
            initPhotos();
        }

        public void linkPhotos()
        {
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid").Photo = Properties.Resources.MGS;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid 2: Subsistance").Photo = Properties.Resources.MGS2;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Metal Gear Solid V: The Phantom Pain").Photo = Properties.Resources.MGSV;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Dragon Ball: Fighter Z").Photo = Properties.Resources.DBFZ;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Minecraft RTX Edition").Photo = Properties.Resources.MC_RTX;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Genshin Impact").Photo = Properties.Resources.GENSHIN;
            cat.GetLesJeux().SearchSingle(FieldJeu.Nom, "Mario Bros 3").Photo = Properties.Resources.SMB3;
        }

        public void initPhotos()
        {
            ListeJeuxPhotos.BeginUpdate();  //pour éviter un rafraichissement pendant la mise a jour des données.
            listeImages = new ImageList();
            ListeJeuxPhotos.Items.Clear();
            ListeJeuxPhotos.DrawMode = DrawMode.OwnerDrawVariable;
            
            foreach (Jeu j in cat.GetLesJeux().GetAll())
            {
                listeImages.Images.Add(j.Photo);
                ListeJeuxPhotos.Items.Add(j.Nom);
            }

            listeImages.ImageSize = new Size(255, 255);
            ListeJeuxPhotos.ItemHeight = 255;
            ListeJeuxPhotos.EndUpdate(); //fin de la mise a jour des données, débloquage de l'affichage.
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void initJeux()
        {
            ListeJeux.DataSource = cat.GetLesJeux().GetAllNames();
        }

        public void initGenres()
        {
            CBGenre.Items.Add("Afficher tous");
            CBGenre.Items.AddRange(Enum.GetNames(typeof(Genre)));
        }

        private void ListeJeux_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.GetLesJeux().SearchSingle(FieldJeu.Nom, (string)ListeJeux.SelectedItem).ToString();
        }

        private void ListeJeuxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.GetLesJeux().SearchSingle(FieldJeu.Nom, (string)ListeJeuxPhotos.SelectedItem).ToString();
        }

        private void ListeJeuxPhotos_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (!listeImages.Images.Empty)   //pour éviter de sortir une exception
            {
                Point p = e.Bounds.Location;
                listeImages.Draw(e.Graphics, p, e.Index);
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaisieJeuDlg sdlg = new SaisieJeuDlg();
            sdlg.ShowDialog();

            if (sdlg.GrabJeu)
            {
                cat.Add(sdlg.J);
                Console.WriteLine("jeu ajouté");
            }
            initJeux();
            initPhotos();
        }

        private void jeuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisuJeuDlg vjdlg = new VisuJeuDlg();
            vjdlg.ShowDialog();

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajDlg mdlg = new MajDlg();
            mdlg.ShowDialog();
        }

        private void CBGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CBGenre.SelectedIndex == 0)
            {
                initPhotos();
            }
            else
            {
                Genre selected = (Genre)Enum.Parse(typeof(Genre), (string)CBGenre.SelectedItem);

                ListeJeuxPhotos.Items.Clear();
                ListeJeuxPhotos.DrawMode = DrawMode.OwnerDrawVariable;
                listeImages = new ImageList();

                foreach (Jeu j in cat.GetLesJeux().Search(FieldJeu.Genre, selected))
                {
                    listeImages.Images.Add(j.Photo);
                    ListeJeuxPhotos.Items.Add(j.Nom);
                }

                listeImages.ImageSize = new Size(255, 255);
                ListeJeuxPhotos.ItemHeight = 255;
            }
        }
    }
}
