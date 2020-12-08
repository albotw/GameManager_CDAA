using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.accessoires;
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

using Type = projet_CDAA_2020_2021.core.accessoires.Type;

namespace GUI
{
    public partial class MainFormAccessoires : Form
    {
        public static Catalogue cat = MainForm.cat;

        private ImageList listeImages;

        public MainFormAccessoires()
        {
            InitializeComponent();

            //pour centrer le texte.
            ToStringBox.SelectAll();
            ToStringBox.SelectionAlignment = HorizontalAlignment.Center;
            ToStringBox.DeselectAll();

            initGenres();
            InitListes();
        }

        public void InitListes()
        {
            ListeAccessoires.BeginUpdate();
            ListeAccessoires.Items.Clear();

            ListeAccessoiresPhotos.BeginUpdate();  //pour éviter un rafraichissement pendant la mise a jour des données.
            listeImages = new ImageList();
            ListeAccessoiresPhotos.Items.Clear();
            ListeAccessoiresPhotos.DrawMode = DrawMode.OwnerDrawVariable;
            
            foreach (Accessoire a in cat.GetEnsembleAccessoires().GetAll())
            {
                ListeAccessoires.Items.Add(a.Nom);

                listeImages.Images.Add(a.Photo);
                ListeAccessoiresPhotos.Items.Add(a.Nom);
            }

            listeImages.ImageSize = new Size(255, 255);
            ListeAccessoiresPhotos.ItemHeight = 255;

            ListeAccessoires.EndUpdate();
            ListeAccessoiresPhotos.EndUpdate(); //fin de la mise a jour des données, débloquage de l'affichage.
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void initGenres()
        {
            CBType.Items.Add("Afficher tous");
            CBType.Items.AddRange(Enum.GetNames(typeof(Type)));
        }

        private void ListeJeux_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.GetEnsembleAccessoires().Search("nom", (string)ListeAccessoires.SelectedItem)[0].ToString();
        }

        private void ListeJeuxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToStringBox.Text = cat.GetEnsembleAccessoires().Search("nom", (string)ListeAccessoiresPhotos.SelectedItem)[0].ToString();
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
            AddAccessoire sdlg = new AddAccessoire();
            sdlg.ShowDialog();

            if (sdlg.Grab)
            {
                cat.Add(sdlg.Out);
            }
            InitListes();
        }

        private void accessoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeViewType vjdlg = new TreeViewType();
            vjdlg.ShowDialog();

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccessoire mdlg = new EditAccessoire();
            mdlg.ShowDialog();

            InitListes();
        }

        private void CBType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CBType.SelectedIndex == 0)
            {
                InitListes();
            }
            else
            {
                ListeAccessoires.BeginUpdate();
                ListeAccessoiresPhotos.BeginUpdate();

                ListeAccessoires.Items.Clear();
                ListeAccessoiresPhotos.Items.Clear();
                ListeAccessoiresPhotos.DrawMode = DrawMode.OwnerDrawVariable;
                listeImages = new ImageList();

                foreach (Accessoire a in cat.GetEnsembleAccessoires().Search("type", (Type)Enum.Parse(typeof(Type), CBType.SelectedItem.ToString())))
                {
                    listeImages.Images.Add(a.Photo);
                    ListeAccessoiresPhotos.Items.Add(a.Nom);
                    ListeAccessoires.Items.Add(a.Nom);
                }

                listeImages.ImageSize = new Size(255, 255);
                ListeAccessoiresPhotos.ItemHeight = 255;

                ListeAccessoires.EndUpdate();
                ListeAccessoiresPhotos.EndUpdate();

            }
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jeuxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
