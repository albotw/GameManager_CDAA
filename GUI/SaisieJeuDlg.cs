using projet_CDAA_2020_2021.core;
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
    public partial class SaisieJeuDlg : Form
    {
        private Jeu j;
        public Jeu J { get => j; }

        private Image photo;

        private bool grabJeu = false;
        public bool GrabJeu { get => grabJeu; set => grabJeu = value; }

        public SaisieJeuDlg()
        {
            InitializeComponent();
            initListeGenres();
        }

        private void initListeGenres()
        {
            CBGenre.Items.AddRange(Enum.GetNames(typeof(Genre)));
        }

        private void ParcourirPB_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                photo = Image.FromFile(fdlg.FileName);
                DirTB.Text = fdlg.FileName;
            }
            fdlg.Dispose();

            ApercuPB.Image = photo;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            grabJeu = false;

            this.Dispose();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            grabJeu = true;

            j = new Jeu();
            j.Nom = NomTB.Text;
            j.Description = DescriptionTB.Text;
            j.Plateforme = PlateformeTB.Text;
            j.Editeur = EditeurTB.Text;
            j.Genre = (Genre)Enum.Parse(typeof(Genre), CBGenre.SelectedItem as String);
            j.Prix = Double.Parse(PrixTB.Text);
            j.Sortie = SortieDTP.Value;
            j.Photo = photo;
            j.Reconditionne = reconditionneRB.Checked;

            this.Dispose();
        }
    }
}
