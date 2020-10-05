using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using projet_CDAA_2020_2021.core;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Catalogue cat;
        private ImageList photos;
        public Form1()
        {
            InitializeComponent();
            cat = new Catalogue();
            Jeux jeux = cat.getJeux();
            jeux.Init();
            initGenres();
            initJeux();
            //initPhotos();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void initJeux()
        {
            ListeJeux.Items.AddRange(cat.getJeux().getNames().ToArray());
        }

        public void initGenres()
        {
            CBGenre.Items.AddRange(Enum.GetNames(typeof(Genre)));
        }
    }
}
