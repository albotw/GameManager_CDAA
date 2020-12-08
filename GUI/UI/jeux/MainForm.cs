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

            //pour centrer le texte.
            ToStringBox.SelectAll();
            ToStringBox.SelectionAlignment = HorizontalAlignment.Center;
            ToStringBox.DeselectAll();

            cat = new Catalogue();
            cat.Init();
            initGenres();
            InitListes();
        }

        public void InitListes()
        {
            ListeJeux.BeginUpdate();
            ListeJeux.Items.Clear();

            ListeJeuxPhotos.BeginUpdate();  //pour éviter un rafraichissement pendant la mise a jour des données.
            listeImages = new ImageList();
            ListeJeuxPhotos.Items.Clear();
            ListeJeuxPhotos.DrawMode = DrawMode.OwnerDrawVariable;
            
            foreach (Jeu j in cat.GetEnsembleJeux().GetAll())
            {
                ListeJeux.Items.Add(j.Nom);

                listeImages.Images.Add(j.Photo);
                ListeJeuxPhotos.Items.Add(j.Nom);
            }

            listeImages.ImageSize = new Size(255, 255);
            ListeJeuxPhotos.ItemHeight = 255;

            ListeJeux.EndUpdate();
            ListeJeuxPhotos.EndUpdate(); //fin de la mise a jour des données, débloquage de l'affichage.
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void initGenres()
        {
            CBGenre.Items.Add("Afficher tous");
            CBGenre.Items.AddRange(Enum.GetNames(typeof(Genre)));
        }

        private void ListeJeux_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.GetEnsembleJeux().Search("nom", (string)ListeJeux.SelectedItem)[0].ToString();
        }

        private void ListeJeuxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.GetEnsembleJeux().Search("nom", (string)ListeJeuxPhotos.SelectedItem)[0].ToString();
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
            AddJeu sdlg = new AddJeu();
            sdlg.ShowDialog();

            if (sdlg.Grab)
            {
                cat.Add(sdlg.Out);
                Console.WriteLine("jeu ajouté");
            }
            InitListes();
        }

        private void jeuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeViewGenre vjdlg = new TreeViewGenre();
            vjdlg.ShowDialog();

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditJeux mdlg = new EditJeux();
            mdlg.ShowDialog();

            InitListes();
        }

        private void CBGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CBGenre.SelectedIndex == 0)
            {
                InitListes();
            }
            else
            {
                ListeJeux.BeginUpdate();
                ListeJeuxPhotos.BeginUpdate();

                ListeJeux.Items.Clear();
                ListeJeuxPhotos.Items.Clear();
                ListeJeuxPhotos.DrawMode = DrawMode.OwnerDrawVariable;
                listeImages = new ImageList();

                foreach (Jeu j in cat.GetEnsembleJeux().Search("genre", (Genre)Enum.Parse(typeof(Genre), CBGenre.SelectedItem.ToString())))
                {
                    listeImages.Images.Add(j.Photo);
                    ListeJeuxPhotos.Items.Add(j.Nom);
                    ListeJeux.Items.Add(j.Nom);
                }

                listeImages.ImageSize = new Size(255, 255);
                ListeJeuxPhotos.ItemHeight = 255;

                ListeJeux.EndUpdate();
                ListeJeuxPhotos.EndUpdate();

            }
        }

        private void TousJeuxBouton_Click(object sender, EventArgs e)
        {
            InitListes();
        }

        private void JeuxRetroButton_Click(object sender, EventArgs e)
        {
            ListeJeux.BeginUpdate();
            ListeJeuxPhotos.BeginUpdate();

            ListeJeux.Items.Clear();
            ListeJeuxPhotos.Items.Clear();
            ListeJeuxPhotos.DrawMode = DrawMode.OwnerDrawVariable;
            listeImages = new ImageList();

            foreach (Jeu j in cat.GetEnsembleJeux().Search("retro", null))
            {
                listeImages.Images.Add(j.Photo);
                ListeJeuxPhotos.Items.Add(j.Nom);
                ListeJeux.Items.Add(j.Nom);
            }

            listeImages.ImageSize = new Size(255, 255);
            ListeJeuxPhotos.ItemHeight = 255;

            ListeJeux.EndUpdate();
            ListeJeuxPhotos.EndUpdate();
        }

        private void accessoiresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainFormAccessoires acc = new MainFormAccessoires();

            acc.ShowDialog();
            this.Show();
        }
    }
}
