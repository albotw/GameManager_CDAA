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
    public partial class EditAccessoire : Form
    {
        private readonly Catalogue cat = MainForm.cat;

        private bool isUpdating = false;
        public EditAccessoire()
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


            DataGridViewTextBoxColumn fabriquant = new DataGridViewTextBoxColumn
            {
                HeaderText = "fabriquant",
                Name = "fabriquant",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn plateforme = new DataGridViewTextBoxColumn
            {
                HeaderText = "plateforme",
                Name = "plateforme",
                ReadOnly = false
            };

            DataGridViewComboBoxColumn type = new DataGridViewComboBoxColumn
            {
                Name = "type",
                HeaderText = "type",
                ReadOnly = false,
                DataSource = Enum.GetNames(typeof(Type))
            };


            DataGridViewImageColumn photo = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "photo",
                ReadOnly = true
            };


            grille.Columns.AddRange(new DataGridViewColumn[] { nom,fabriquant,  plateforme, type, photo });

            grille.Rows.Add(cat.GetEnsembleAccessoires().GetAll().Count -1);
            int i = 0;
            foreach(Accessoire a in cat.GetEnsembleAccessoires().GetAll())
            {
                grille.Rows[i].Cells["nom"].Value = a.Nom;
                grille.Rows[i].Cells["fabriquant"].Value = a.FabriquantPays;
                grille.Rows[i].Cells["plateforme"].Value = a.Plateforme;
                grille.Rows[i].Cells["type"].Value = a.Type.ToString();
                grille.Rows[i].Cells["photo"].Value = a.Photo;
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

                Accessoire a = cat.GetEnsembleAccessoires().GetAll()[ligne];
                switch(colonne)
                {
                    case 0:
                        a.Nom = (string)cell.Value;
                        break;
                    case 1:
                        a.FabriquantPays = (string)cell.Value;
                        break;
                    case 2:
                        a.Plateforme = (string)cell.Value;
                        break;
                    case 3:
                        a.Type = (Type)Enum.Parse(typeof(Type), cell.Value.ToString());
                        break;
                }
            }  
        }
    }
}
