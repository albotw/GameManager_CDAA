using System;
using System.Windows.Forms;

using projet_CDAA_2020_2021.core;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Catalogue cat;
        private ImageList photos;
        public Form1()
        {
            InitializeComponent();
            cat = new Catalogue();
            Jeux jeux = cat.getJeux();
            jeux.Init();
            initGenres();
            initJeux();
            initListePhotos();
        }

        public void initListePhotos()
        {
            List1.BeginUpdate();
            photos = new ImageList();
            List1.Items.Clear();
            List1.DrawMode = DrawMode.OwnerDrawFixed;
            foreach (Jeu j in cat.getJeux().GetAll())
            {
               photos.Images.Add(j.Photos);
                List1.Items.Add(j.Nom);
            }
            photos.ImageSize = new Size(255, 255);
            List1.ItemHeight = 255;
            List1.EndUpdate();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void initJeux()
        {
            ListeJeux.Items.AddRange(cat.getJeux().getNames().ToArray());
        }

        public void initGenres()
        {
            CBGenre.Items.AddRange(Enum.GetNames(typeof(Genre)));
        }

        private void CBGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListeJeux_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
