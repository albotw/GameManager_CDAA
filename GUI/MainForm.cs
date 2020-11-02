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

        private ImageList imList;

        public MainForm()
        {
            InitializeComponent();
            cat = new Catalogue();
            cat.Init();
            linkPhotos();
            initGenres();
            initJeux();
            initPhotos();
        }

        public void linkPhotos()
        {
            cat.GetLesJeux().SearchSingle("nom", "Metal Gear Solid").Photo = Properties.Resources.Metal_Gear_Solid;
            cat.GetLesJeux().SearchSingle("nom", "Metal Gear Solid 2: Subsistance").Photo = Properties.Resources.Metal_Gear_Solid_2;
            cat.GetLesJeux().SearchSingle("nom", "Metal Gear Solid V: The Phantom Pain").Photo = Properties.Resources.Metal_Gear_Solid_V__The_Phantom_Pain;
            cat.GetLesJeux().SearchSingle("nom", "Dragon Ball: Fighter Z").Photo = Properties.Resources.Dragon_Ball__Fighter_Z;
            cat.GetLesJeux().SearchSingle("nom", "Minecraft RTX Edition").Photo = Properties.Resources.Minecraft_RTX_Edition;
            cat.GetLesJeux().SearchSingle("nom", "Genshin Impact").Photo = Properties.Resources.Genshin_Impact;
            cat.GetLesJeux().SearchSingle("nom", "Mario Bros 3").Photo = Properties.Resources.Genshin_Impact;
        }

        public void initPhotos()
        {
            ListeJeuxPhotos.DrawMode = DrawMode.OwnerDrawVariable;
            imList = new ImageList();
            
            foreach(Jeu j in cat.GetLesJeux().GetAll())
            {
                imList.Images.Add(j.Photo);
                ListeJeuxPhotos.Items.Add(j.Nom);
            }

            imList.ImageSize = new Size(255, 255);
            ListeJeuxPhotos.ItemHeight = 255;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void initJeux()
        {
            ListeJeux.Items.AddRange(cat.GetLesJeux().GetAllNames().ToArray());
        }

        public void initGenres()
        {
            CBGenre.Items.AddRange(Enum.GetNames(typeof(Genre)));
        }

        private void ListeJeux_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.GetLesJeux().SearchSingle("nom", (string)ListeJeux.SelectedItem).ToString();
        }

        private void ListeJeuxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.GetLesJeux().SearchSingle("nom", (string)ListeJeuxPhotos.SelectedItem).ToString();
        }

        private void ListeJeuxPhotos_DrawItem(object sender, DrawItemEventArgs e)
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
    }
}
