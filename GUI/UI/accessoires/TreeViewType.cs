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
    public partial class TreeViewType : Form
    {
        private readonly Catalogue cat = MainForm.cat;
        public TreeViewType()
        {
            InitializeComponent();
            InitTree();
        }

        public void InitTree()
        {
            treeView1.BeginUpdate();

            int i = 0;
            foreach(Type t in Enum.GetValues(typeof(Type)))
            {
                treeView1.Nodes.Add(t.ToString());
                foreach (Accessoire a in cat.GetEnsembleAccessoires().Search("type", t))
                {
                    treeView1.Nodes[i].Nodes.Add(a.Nom);
                }

                i++;
            }

            treeView1.EndUpdate();
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tv = (TreeView)sender;
            TreeNode tn = tv.SelectedNode;

            if (tn.Nodes.Count == 0 && tn.Parent != null)
            {
                InfoTB.Text = cat.GetEnsembleAccessoires().Search("nom", tn.Text)[0].ToString();
                PhotoPB.Image = cat.GetEnsembleAccessoires().Search("nom", tn.Text)[0].Photo;
            }
        }
    }
}
