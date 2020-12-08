namespace GUI
{
    partial class EditJeux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grille = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grille)).BeginInit();
            this.SuspendLayout();
            // 
            // grille
            // 
            this.grille.AllowUserToOrderColumns = true;
            this.grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grille.Location = new System.Drawing.Point(0, 0);
            this.grille.Name = "grille";
            this.grille.Size = new System.Drawing.Size(1208, 347);
            this.grille.TabIndex = 0;
            this.grille.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.grille.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grille_CellValueChanged);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 347);
            this.Controls.Add(this.grille);
            this.Name = "Edit";
            this.Text = "MajDlg";
            ((System.ComponentModel.ISupportInitialize)(this.grille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grille;
    }
}