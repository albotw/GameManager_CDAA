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
    public partial class AddJeu : Form
    {
        private object o;
        public object Out { get => o; }

        private Image photo;

        private bool grab = false;
        public bool Grab { get => grab; set => grab = value; }

        public AddJeu()
        {
            InitializeComponent();
            InitListeGenres();
        }

        private void InitListeGenres()
        {
            CBGenre.Items.AddRange(Enum.GetNames(typeof(Genre)));
            GenreRetro.Items.AddRange(Enum.GetNames(typeof(Genre)));
        }

        private void ParcourirPB_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                photo = Image.FromFile(fdlg.FileName);
                DirTB.Text = fdlg.FileName;
                ImgDirRetro.Text = fdlg.FileName;
            }
            fdlg.Dispose();

            ApercuPB.Image = photo;
            ImgRetro.Image = photo;
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            grab = false;

            this.Dispose();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            grab = true;


            Jeu j = new Jeu
            {
                Nom = NomTB.Text,
                Description = DescriptionTB.Text,
                Plateforme = PlateformeTB.Text,
                Editeur = EditeurTB.Text,
                Genre = (Genre)Enum.Parse(typeof(Genre), CBGenre.SelectedItem as String),
                Prix = (double)PrixJeu.Value,
                Sortie = SortieDTP.Value,
                Photo = photo,
                Reconditionne = reconditionneRB.Checked
            };

            o = j;
            this.Dispose();
        }

        private void SaisieJeuDlg_Load(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void ValiderRetro_Click(object sender, EventArgs e)
        {
            grab = true;

            Jeu j = new JeuRetro
            {
                Nom = NomRetro.Text,
                Description = DescriptionRetro.Text,
                Plateforme = PlateformeRetro.Text,
                Editeur = EditeurRetro.Text,
                Genre = (Genre)Enum.Parse(typeof(Genre), GenreRetro.SelectedItem.ToString()),
                Prix = (double)PrixRetro.Value,
                Sortie = SortieRetro.Value,
                Photo = photo,
                Reconditionne = ReconditionneRetro.Checked
            };
            (j as JeuRetro).Etat = EtatRetro.Text;
            (j as JeuRetro).Notice = YesNoticeRetro.Checked;

            o = j;
            this.Dispose();
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
