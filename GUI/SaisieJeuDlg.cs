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
        private Image photo;

        public SaisieJeuDlg()
        {
            InitializeComponent();
            initListeGenres();
        }

        private void initListeGenres()
        {
            CBGenre.Items.AddRange(Enum.GetNames(typeof(Genre)));
        }

        private void SaisieJeuDlg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                photo = Image.FromFile(fdlg.FileName);
                DirTB.Text = fdlg.FileName;
            }
            fdlg.Dispose();
        }
    }
}
