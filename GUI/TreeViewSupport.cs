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
    public partial class TreeViewSupport : Form
    {
        private Catalogue cat = Main.cat;
        public TreeViewSupport()
        {
            InitializeComponent();
            InitTree();
        }

        public void InitTree()
        {
            treeView1.BeginUpdate();

            int i = 0;
            foreach(Support s in Enum.GetValues(typeof(Support)))
            {
                treeView1.Nodes.Add(s.ToString());
                foreach(Console c in cat.GetLesConsoles().Search(FieldConsole.Support, s.ToString()))
                {
                    treeView1.Nodes[i].Nodes.Add(c.Nom);
                }
                i++;
            }

            treeView1.EndUpdate();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tv = (TreeView)sender;
            TreeNode tn = tv.SelectedNode;

            if (tn.Nodes.Count == 0 && tn.Parent != null)
            {
                InfoTB.Text = cat.GetLesConsoles().SearchSingle(FieldConsole.Nom, tn.Text).ToString();
                PhotoPB.Image = cat.GetLesConsoles().SearchSingle(FieldConsole.Nom, tn.Text).Photo;
            }
        }
    }
}
