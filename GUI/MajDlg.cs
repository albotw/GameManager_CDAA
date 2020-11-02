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
    public partial class MajDlg : Form
    {
        public MajDlg()
        {
            InitializeComponent();
            InitGrid();
        }

        public void InitGrid()
        {
            dataGridView1.DataSource = MainForm.cat.GetLesJeux().GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
