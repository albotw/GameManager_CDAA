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
        private readonly Catalogue cat = MainForm.cat;

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

            DataGridViewTextBoxColumn nom = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nom",
                Name = "nom",
                ReadOnly = false
            };


            DataGridViewTextBoxColumn description = new DataGridViewTextBoxColumn
            {
                HeaderText = "description",
                Name = "description",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn editeur = new DataGridViewTextBoxColumn
            {
                HeaderText = "editeur",
                Name = "editeur",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn plateforme = new DataGridViewTextBoxColumn
            {
                HeaderText = "plateforme",
                Name = "plateforme",
                ReadOnly = false
            };

            DataGridViewComboBoxColumn genre = new DataGridViewComboBoxColumn
            {
                Name = "genre",
                HeaderText = "genre",
                ReadOnly = false,
                DataSource = Enum.GetNames(typeof(Genre))
            };

            DataGridViewTextBoxColumn prix = new DataGridViewTextBoxColumn
            {
                HeaderText = "prix",
                Name = "prix",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn sortie = new DataGridViewTextBoxColumn
            {
                HeaderText = "sortie",
                Name = "sortie",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn reconditionne = new DataGridViewTextBoxColumn
            {
                HeaderText = "reconditionne",
                Name = "reconditionne",
                ReadOnly = false
            };

            DataGridViewImageColumn photo = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "photo",
                ReadOnly = true
            };

            DataGridViewCheckBoxColumn retro = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Jeu Retro",
                Name = "retro",
                ReadOnly = true
            };

            DataGridViewTextBoxColumn etat = new DataGridViewTextBoxColumn
            {
                HeaderText = "etat",
                Name = "etat",
                ReadOnly = false
            };

            DataGridViewCheckBoxColumn notice = new DataGridViewCheckBoxColumn
            {
                HeaderText = "notice",
                Name = "notice",
                ReadOnly = false
            };

            grille.Columns.AddRange(new DataGridViewColumn[] { nom, description, editeur, plateforme, genre, prix, sortie, reconditionne, photo, retro, etat, notice });

            grille.Rows.Add(cat.GetEnsembleJeux().GetAll().Count -1);
            int i = 0;
            foreach(Jeu j in cat.GetEnsembleJeux().GetAll())
            {
                grille.Rows[i].Cells["nom"].Value = j.Nom;
                grille.Rows[i].Cells["description"].Value = j.Description;
                grille.Rows[i].Cells["editeur"].Value = j.Editeur;
                grille.Rows[i].Cells["plateforme"].Value = j.Plateforme;
                grille.Rows[i].Cells["prix"].Value = j.Prix;
                grille.Rows[i].Cells["sortie"].Value = j.Sortie;
                grille.Rows[i].Cells["reconditionne"].Value = j.Reconditionne;
                grille.Rows[i].Cells["photo"].Value = j.Photo;
                grille.Rows[i].Cells["retro"].Value = j is JeuRetro;
                grille.Rows[i].Cells["etat"].Value = j is JeuRetro ? (j as JeuRetro).Etat : "";
                grille.Rows[i].Cells["notice"].Value = j is JeuRetro && (j as JeuRetro).Notice;
                grille.Rows[i].Cells["genre"].Value = j.Genre.ToString();
                i++;
            }

            isUpdating = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grille_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           if (!isUpdating)
            {
                int ligne = e.RowIndex;
                int colonne = e.ColumnIndex;

                DataGridViewCell cell = grille.Rows[ligne].Cells[colonne];

                Jeu j = cat.GetEnsembleJeux().GetAll()[ligne];
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
