using projet_CDAA_2020_2021.core;
using projet_CDAA_2020_2021.core.consoles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Console = projet_CDAA_2020_2021.core.consoles.Console;

namespace GUI
{
    public partial class EditConsoles : Form
    {
        private readonly Catalogue cat = Main.cat;
        private bool isUpdating = false;
        public EditConsoles()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            isUpdating = true;
            /*
             * string       nom
             * string       fabriquant
             * int          generation
             * DateTime     sortie
             * int          ports
             * Support      support
             * string       type
             * double       prix
             * image        photo
             */

            DataGridViewTextBoxColumn nom = new DataGridViewTextBoxColumn
            {
                HeaderText = "nom",
                Name = "nom",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn fabriquant = new DataGridViewTextBoxColumn
            {
                HeaderText = "fabriquant",
                Name = "fabriquant",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn generation = new DataGridViewTextBoxColumn
            {
                HeaderText = "generation",
                Name = "generation",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn sortie = new DataGridViewTextBoxColumn
            {
                HeaderText = "sortie",
                Name = "sortie",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn ports = new DataGridViewTextBoxColumn
            {
                HeaderText = "ports",
                Name = "ports",
                ReadOnly = false
            };

            DataGridViewComboBoxColumn support = new DataGridViewComboBoxColumn
            {
                HeaderText = "support",
                Name = "support",
                ReadOnly = false,
                DataSource = Enum.GetNames((typeof(Support)))
            };

            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn
            {
                HeaderText = "type",
                Name = "type",
                ReadOnly = false
            };

            DataGridViewTextBoxColumn prix = new DataGridViewTextBoxColumn
            {
                HeaderText = "prix",
                Name = "prix",
                ReadOnly = false
            };

            DataGridViewImageColumn photo = new DataGridViewImageColumn
            {
                HeaderText = "photo",
                Name = "photo",
                ReadOnly = true
            };

            grid.Columns.AddRange(new DataGridViewColumn[] { nom, fabriquant, generation, sortie, ports, support, type, prix, photo });

            grid.Rows.Add(cat.GetLesConsoles().GetAll().Count - 1);
            int i = 0;
            foreach(Console c in cat.GetLesConsoles().GetAll())
            {
                grid.Rows[i].Cells["nom"].Value = c.Nom;
                grid.Rows[i].Cells["fabriquant"].Value = c.Fabriquant;
                grid.Rows[i].Cells["generation"].Value = c.Generation;
                grid.Rows[i].Cells["sortie"].Value = c.Sortie;
                grid.Rows[i].Cells["ports"].Value = c.Ports;
                grid.Rows[i].Cells["support"].Value = c.Support.ToString();
                grid.Rows[i].Cells["type"].Value = c.Type;
                grid.Rows[i].Cells["prix"].Value = c.Prix;
                grid.Rows[i].Cells["photo"].Value = c.Photo;
                i++;
            }

            isUpdating = false;
        }

        private void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!isUpdating)
            {
                int ligne = e.RowIndex;
                int colonne = e.ColumnIndex;

                DataGridViewCell cell = grid.Rows[ligne].Cells[colonne];

                Console c = cat.GetLesConsoles().GetAll()[ligne];

                switch(colonne)
                {
                    case 0:
                        c.Nom = (string)cell.Value;
                        break;
                    case 1:
                        c.Fabriquant = (string)cell.Value;
                        break;
                    case 2:
                        c.Generation = Int32.Parse(cell.Value.ToString());
                        break;
                    case 3:
                        c.Sortie = DateTime.Parse(cell.Value.ToString());
                        break;
                    case 4:
                        c.Ports = Int32.Parse(cell.Value.ToString());
                        break;
                    case 5:
                        c.Support = (Support)Enum.Parse(typeof(Support), cell.Value.ToString());
                        break;
                    case 6:
                        c.Type = (string)cell.Value;
                        break;
                    case 7:
                        c.Prix = Double.Parse(cell.Value.ToString());
                        break;
                }
            }
        }
    }
}
