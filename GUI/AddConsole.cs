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
    public partial class AddConsole : Form
    {
        private Console c;
        public Console C { get => c; }

        private Image photo;

        private bool grab = false;
        public bool Grab { get => grab; set => grab = value; }
        public AddConsole()
        {
            InitializeComponent();
            InitListeSupports();
        }

        private void InitListeSupports()
        {
            CBSupport.Items.AddRange(Enum.GetNames(typeof(Support)));
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                photo = Image.FromFile(fdlg.FileName);
            }

            fdlg.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            grab = false;
            this.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            grab = true;

            c = new Console
            {
                Nom = Nom.Text,
                Fabriquant = Fabriquant.Text,
                Generation = (int)Generation.Value,
                Sortie = Sortie.Value,
                Ports = (int)Manette.Value,
                Support = (Support)Enum.Parse(typeof(Support), CBSupport.Text),
                Type = TypeConsole.Text,
                Prix = (double)Prix.Value,
                Photo = photo
            };

            this.Dispose();
        }
    }
}
