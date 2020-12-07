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
    public partial class EditJeux : Form
    {
        private Catalogue cat = Main.cat;

        private bool isUpdating = false;
        public EditJeux()
        {
            InitializeComponent();
            InitGrid();
        }

        public void InitGrid()
        {
            isUpdating = true;
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
            nom.Name = "nom";
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
            genre.Name = "genre";
            genre.HeaderText = "genre";
            genre.ReadOnly = false;
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
            notice.ReadOnly = false;

            grille.Columns.AddRange(new DataGridViewColumn[] { nom, description, editeur, plateforme, genre, prix, sortie, reconditionne, photo, retro, etat, notice });

            grille.Rows.Add(cat.GetLesJeux().GetAll().Count -1);
            int i = 0;
            foreach(Jeu j in cat.GetLesJeux().GetAll())
            {
                grille.Rows[i].Cells["nom"].Value = j.Nom;
                grille.Rows[i].Cells["description"].Value = j.Description;
                grille.Rows[i].Cells["editeur"].Value = j.Editeur;
                grille.Rows[i].Cells["plateforme"].Value = j.Plateforme;
                grille.Rows[i].Cells["prix"].Value = j.Prix;
                grille.Rows[i].Cells["sortie"].Value = j.Sortie;
                grille.Rows[i].Cells["reconditionne"].Value = j.Reconditionne;
                grille.Rows[i].Cells["photo"].Value = j.Photo;
                grille.Rows[i].Cells["retro"].Value = j is JeuRetro ? true : false;
                grille.Rows[i].Cells["etat"].Value = j is JeuRetro ? (j as JeuRetro).Etat : "";
                grille.Rows[i].Cells["notice"].Value = j is JeuRetro ? true : false;
                grille.Rows[i].Cells["genre"].Value = j.Genre.ToString();
                i++;
            }

            isUpdating = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grille_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           if (!isUpdating)
            {
                int ligne = e.RowIndex;
                int colonne = e.ColumnIndex;

                DataGridViewCell cell = grille.Rows[ligne].Cells[colonne];

                Jeu j = cat.GetLesJeux().GetAll()[ligne];
                switch (colonne)
                {
                    case 0:
                        j.Nom = (string)cell.Value;

                        break;
                    case 1:
                        j.Description = (string)cell.Value;

                        break;
                    case 2:
                        j.Editeur = (string)cell.Value;

                        break;
                    case 3:
                        j.Plateforme = (string)cell.Value;

                        break;
                    case 4:
                        j.Genre = (Genre)Enum.Parse(typeof(Genre), cell.Value.ToString());
                        break;

                    case 5:
                        j.Prix = Double.Parse(cell.Value.ToString());

                        break;
                    case 6:
                        j.Sortie = DateTime.Parse(cell.Value.ToString());

                        break;
                    case 9:
                        j.Reconditionne = Boolean.Parse(cell.Value.ToString());

                        break;
                    case 10:
                        if (j is JeuRetro)
                        {
                            (j as JeuRetro).Etat = (string)cell.Value;
                        }
                        break;
                    case 11:
                        if (j is JeuRetro)
                        {
                            (j as JeuRetro).Notice = Boolean.Parse(cell.Value.ToString());
                        }
                        break;

                }
            }
           
        }
    }
}
