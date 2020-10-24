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

namespace GUI
{
    public partial class MainForm : Form
    {
        private Catalogue cat;
        private ImageList photos;

        private ImageList imList;
        public MainForm()
        {
            InitializeComponent();
            cat = new Catalogue();
            Jeux jeux = cat.getJeux();
            jeux.Init();
            initGenres();
            initJeux();
            initPhotos();
        }

        public void initPhotos()
        {
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            imList = new ImageList();
            
            foreach(Jeu j in cat.getJeux().Search())
            {
                imList.Images.Add(j.Photo);
                listBox1.Items.Add(j.Nom);
            }

            imList.ImageSize = new Size(255, 255);
            listBox1.ItemHeight = 255;
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

        private void ListeJeux_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.getJeux().getJeu((string)ListeJeux.SelectedItem).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.getJeux().getJeu((string)listBox1.SelectedItem).ToString();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Point p = e.Bounds.Location;
            imList.Draw(e.Graphics, p, e.Index);
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
    }
}
