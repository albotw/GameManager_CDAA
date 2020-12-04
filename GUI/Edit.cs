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
    public partial class Edit : Form
    {
        private Catalogue cat = MainForm.cat;
        public Edit()
        {
            InitializeComponent();
            InitGrid();
        }

        public void InitGrid()
        {
            /*
             * string
             * string
             * string
             * string
             * Genre
             * double
             * DateTime
             * bool
             * Image
             * bool -> isJeuRétro ?
             * string
             * bool
             */ 

            DataGridViewTextBoxColumn nom = new DataGridViewTextBoxColumn();
            nom.HeaderText = "Nom";
            nom.Name = "Nom";
            nom.ReadOnly = false;


            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn();
            description.HeaderText = "description";
            description.Name = "description";
            description.ReadOnly = false;

            DataGridViewTextBoxColumn editeur = new DataGridViewTextBoxColumn();
            editeur.HeaderText = "editeur";
            editeur.Name = "editeur";
            editeur.ReadOnly = false;

            DataGridViewTextBoxColumn plateforme = new DataGridViewTextBoxColumn();
            plateforme.HeaderText = "plateforme";
            plateforme.Name = "plateforme";
            plateforme.ReadOnly = false;

            DataGridViewComboBoxColumn genre = new DataGridViewComboBoxColumn();
            genre.DataSource = Enum.GetNames(typeof(Genre));

            DataGridViewTextBoxColumn prix = new DataGridViewTextBoxColumn();
            prix.HeaderText = "prix";
            prix.Name = "prix";
            prix.ReadOnly = false;

            DataGridViewTextBoxColumn sortie = new DataGridViewTextBoxColumn();
            sortie.HeaderText = "sortie";
            sortie.Name = "sortie";
            sortie.ReadOnly = false;

            DataGridViewTextBoxColumn reconditionne = new DataGridViewTextBoxColumn();
            reconditionne.HeaderText = "reconditionne";
            reconditionne.Name = "reconditionne";
            reconditionne.ReadOnly = false;

            DataGridViewImageColumn photo = new DataGridViewImageColumn();
            photo.HeaderText = "Image";
            photo.Name = "photo";
            photo.ReadOnly = true;

            DataGridViewCheckBoxColumn retro = new DataGridViewCheckBoxColumn();
            retro.HeaderText = "Jeu Retro";
            retro.Name = "retro";
            retro.ReadOnly = true;

            DataGridViewTextBoxColumn etat = new DataGridViewTextBoxColumn();
            etat.HeaderText = "etat";
            etat.Name = "etat";
            etat.ReadOnly = false;

            DataGridViewCheckBoxColumn notice = new DataGridViewCheckBoxColumn();
            notice.HeaderText = "notice";
            notice.Name = "notice";
            notice.ReadOnly = true;

            grille.Columns.AddRange(new DataGridViewColumn[] { nom, description, editeur, plateforme, genre, prix, sortie, reconditionne, photo, retro, etat, notice });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
