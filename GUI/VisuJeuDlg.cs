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
    public partial class VisuJeuDlg : Form
    {
        private Catalogue cat = MainForm.cat;
        public VisuJeuDlg()
        {
            InitializeComponent();
            InitTree();
        }

        public void InitTree()
        {
            treeView1.BeginUpdate();

            int i = 0;
            foreach(Genre g in Enum.GetValues(typeof(Genre)))
            {
                treeView1.Nodes.Add(g.ToString());
                foreach (Jeu j in cat.GetLesJeux().Search(FieldJeu.Genre, g))
                {
                    treeView1.Nodes[i].Nodes.Add(j.Nom);
                    Console.WriteLine("\t" + j.Nom);
                }

                i++;
            }

            treeView1.EndUpdate();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tv = (TreeView)sender;
            TreeNode tn = tv.SelectedNode;

            if (tn.Nodes.Count == 0 && tn.Parent != null)
            {
                InfoTB.Text = cat.GetLesJeux().SearchSingle("nom", tn.Text).ToString();
                PhotoPB.Image = cat.GetLesJeux().SearchSingle("nom", tn.Text).Photo;
            }
        }
    }
}
