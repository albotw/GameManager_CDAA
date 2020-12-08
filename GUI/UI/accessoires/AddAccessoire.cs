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

using projet_CDAA_2020_2021.core.accessoires;

using Type = projet_CDAA_2020_2021.core.accessoires.Type;

namespace GUI
{
    public partial class AddAccessoire : Form
    {
        private object o;
        public object Out { get => o; }

        private Image photo;

        private bool grab = false;
        public bool Grab { get => grab; set => grab = value; }

        public AddAccessoire()
        {
            InitializeComponent();
            InitListeTypes();
        }

        private void InitListeTypes()
        {
            Type.Items.AddRange(Enum.GetNames(typeof(Type)));
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                photo = Image.FromFile(fdlg.FileName);
            }
            fdlg.Dispose();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            grab = false;
            this.Dispose();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            grab = true;
            o = new Accessoire()
            {
                Nom = Nom.Text,
                FabriquantPays = Fabriquant.Text,
                Plateforme = Plateforme.Text,
                Type = (Type)Enum.Parse(typeof(Type), Type.SelectedItem.ToString()),
                Photo = photo
            };

            this.Dispose();
        }
    }
}
