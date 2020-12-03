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
    public partial class SupprDlg : Form
    {

        public bool Delete;
        public string DeleteName;
        public SupprDlg()
        {
            InitializeComponent();
        }



        private void Valider_Click(object sender, EventArgs e)
        {
            Delete = true;
            DeleteName = Value.Text;
            this.Dispose();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Delete = false;
            this.Dispose();
        }
    }
}
