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
            initListeGenres();
        }

        private void initListeGenres()
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

            
            Jeu j = new Jeu();
            j.Nom = NomTB.Text;
            j.Description = DescriptionTB.Text;
            j.Plateforme = PlateformeTB.Text;
            j.Editeur = EditeurTB.Text;
            j.Genre = (Genre)Enum.Parse(typeof(Genre), CBGenre.SelectedItem as String);
            j.Prix = (double)PrixJeu.Value;
            j.Sortie = SortieDTP.Value;
            j.Photo = photo;
            j.Reconditionne = reconditionneRB.Checked;

            o = j;
            this.Dispose();
        }

        private void SaisieJeuDlg_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void ValiderRetro_Click(object sender, EventArgs e)
        {
            grab = true;

            Jeu j = new JeuRetro();

            j.Nom = NomRetro.Text;
            j.Description = DescriptionRetro.Text;
            j.Plateforme = PlateformeRetro.Text;
            j.Editeur = EditeurRetro.Text;
            j.Genre = (Genre)Enum.Parse(typeof(Genre), GenreRetro.SelectedItem.ToString());
            j.Prix = (double)PrixRetro.Value;
            j.Sortie = SortieRetro.Value;
            j.Photo = photo;
            j.Reconditionne = ReconditionneRetro.Checked;
            (j as JeuRetro).Etat = EtatRetro.Text;
            (j as JeuRetro).Notice = YesNoticeRetro.Checked;

            o = j;
            this.Dispose();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
