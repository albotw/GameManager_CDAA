namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListeJeuxPhotos = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ToStringBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PhotoPB = new System.Windows.Forms.PictureBox();
            this.TousJeuxBouton = new System.Windows.Forms.Button();
            this.JeuxRetroButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBGenre = new System.Windows.Forms.ComboBox();
            this.ListeJeux = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessoiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListeJeuxPhotos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // ListeJeuxPhotos
            // 
            this.ListeJeuxPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeJeuxPhotos.FormattingEnabled = true;
            this.ListeJeuxPhotos.Location = new System.Drawing.Point(0, 0);
            this.ListeJeuxPhotos.Margin = new System.Windows.Forms.Padding(0);
            this.ListeJeuxPhotos.Name = "ListeJeuxPhotos";
            this.ListeJeuxPhotos.Size = new System.Drawing.Size(266, 426);
            this.ListeJeuxPhotos.TabIndex = 0;
            this.ListeJeuxPhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListeJeuxPhotos_DrawItem);
            this.ListeJeuxPhotos.SelectedIndexChanged += new System.EventHandler(this.ListeJeuxPhotos_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ToStringBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(530, 426);
            this.splitContainer2.SplitterDistance = 176;
            this.splitContainer2.TabIndex = 0;
            // 
            // ToStringBox
            // 
            this.ToStringBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToStringBox.Location = new System.Drawing.Point(0, 0);
            this.ToStringBox.Name = "ToStringBox";
            this.ToStringBox.ReadOnly = true;
            this.ToStringBox.Size = new System.Drawing.Size(176, 426);
            this.ToStringBox.TabIndex = 0;
            this.ToStringBox.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PhotoPB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TousJeuxBouton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.JeuxRetroButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CBGenre, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ListeJeux, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66319F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PhotoPB
            // 
            this.PhotoPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoPB.Location = new System.Drawing.Point(3, 358);
            this.PhotoPB.Name = "PhotoPB";
            this.PhotoPB.Size = new System.Drawing.Size(344, 65);
            this.PhotoPB.TabIndex = 1;
            this.PhotoPB.TabStop = false;
            // 
            // TousJeuxBouton
            // 
            this.TousJeuxBouton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TousJeuxBouton.Location = new System.Drawing.Point(3, 3);
            this.TousJeuxBouton.Name = "TousJeuxBouton";
            this.TousJeuxBouton.Size = new System.Drawing.Size(344, 65);
            this.TousJeuxBouton.TabIndex = 0;
            this.TousJeuxBouton.Text = "Tous les jeux";
            this.TousJeuxBouton.UseVisualStyleBackColor = true;
            this.TousJeuxBouton.Click += new System.EventHandler(this.TousJeuxBouton_Click);
            // 
            // JeuxRetroButton
            // 
            this.JeuxRetroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JeuxRetroButton.Location = new System.Drawing.Point(3, 74);
            this.JeuxRetroButton.Name = "JeuxRetroButton";
            this.JeuxRetroButton.Size = new System.Drawing.Size(344, 65);
            this.JeuxRetroButton.TabIndex = 1;
            this.JeuxRetroButton.Text = "Jeux Retro";
            this.JeuxRetroButton.UseVisualStyleBackColor = true;
            this.JeuxRetroButton.Click += new System.EventHandler(this.JeuxRetroButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "Séléctionner un genre !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBGenre
            // 
            this.CBGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBGenre.FormattingEnabled = true;
            this.CBGenre.Location = new System.Drawing.Point(3, 238);
            this.CBGenre.Name = "CBGenre";
            this.CBGenre.Size = new System.Drawing.Size(344, 21);
            this.CBGenre.TabIndex = 3;
            this.CBGenre.SelectionChangeCommitted += new System.EventHandler(this.CBGenre_SelectionChangeCommitted);
            // 
            // ListeJeux
            // 
            this.ListeJeux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeJeux.FormattingEnabled = true;
            this.ListeJeux.Location = new System.Drawing.Point(3, 287);
            this.ListeJeux.Name = "ListeJeux";
            this.ListeJeux.Size = new System.Drawing.Size(344, 65);
            this.ListeJeux.TabIndex = 4;
            this.ListeJeux.SelectedIndexChanged += new System.EventHandler(this.ListeJeux_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem,
            this.visualiserToolStripMenuItem,
            this.accessoiresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuxToolStripMenuItem});
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            // 
            // jeuxToolStripMenuItem
            // 
            this.jeuxToolStripMenuItem.Name = "jeuxToolStripMenuItem";
            this.jeuxToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.jeuxToolStripMenuItem.Text = "Jeux";
            this.jeuxToolStripMenuItem.Click += new System.EventHandler(this.jeuxToolStripMenuItem_Click);
            // 
            // accessoiresToolStripMenuItem
            // 
            this.accessoiresToolStripMenuItem.Name = "accessoiresToolStripMenuItem";
            this.accessoiresToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.accessoiresToolStripMenuItem.Text = "Accessoires";
            this.accessoiresToolStripMenuItem.Click += new System.EventHandler(this.accessoiresToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox ListeJeuxPhotos;
        private System.Windows.Forms.RichTextBox ToStringBox;
        private System.Windows.Forms.PictureBox PhotoPB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button TousJeuxBouton;
        private System.Windows.Forms.Button JeuxRetroButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBGenre;
        private System.Windows.Forms.ListBox ListeJeux;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessoiresToolStripMenuItem;
    }
}

