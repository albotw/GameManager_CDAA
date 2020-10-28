namespace GUI
{
    partial class SaisieJeuDlg
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.PlateformeTB = new System.Windows.Forms.TextBox();
            this.EditeurTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NonRecontidionneRB = new System.Windows.Forms.RadioButton();
            this.reconditionneRB = new System.Windows.Forms.RadioButton();
            this.DirTB = new System.Windows.Forms.TextBox();
            this.CBGenre = new System.Windows.Forms.ComboBox();
            this.PrixTB = new System.Windows.Forms.TextBox();
            this.SortieDTP = new System.Windows.Forms.DateTimePicker();
            this.ParcourirButton = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.ApercuPB = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApercuPB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(716, 437);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(708, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jeu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NomTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlateformeTB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EditeurTB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DirTB, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.CBGenre, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrixTB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.SortieDTP, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ParcourirButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Annuler, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Valider, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ApercuPB, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description ?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 67);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plateforme ?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 67);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editeur ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomTB
            // 
            this.NomTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NomTB.Location = new System.Drawing.Point(178, 2);
            this.NomTB.Margin = new System.Windows.Forms.Padding(2);
            this.NomTB.Multiline = true;
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(172, 63);
            this.NomTB.TabIndex = 4;
            this.NomTB.TabStop = false;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionTB.Location = new System.Drawing.Point(178, 69);
            this.DescriptionTB.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(172, 63);
            this.DescriptionTB.TabIndex = 5;
            // 
            // PlateformeTB
            // 
            this.PlateformeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlateformeTB.Location = new System.Drawing.Point(178, 136);
            this.PlateformeTB.Margin = new System.Windows.Forms.Padding(2);
            this.PlateformeTB.Multiline = true;
            this.PlateformeTB.Name = "PlateformeTB";
            this.PlateformeTB.Size = new System.Drawing.Size(172, 63);
            this.PlateformeTB.TabIndex = 6;
            // 
            // EditeurTB
            // 
            this.EditeurTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditeurTB.Location = new System.Drawing.Point(178, 203);
            this.EditeurTB.Margin = new System.Windows.Forms.Padding(2);
            this.EditeurTB.Multiline = true;
            this.EditeurTB.Name = "EditeurTB";
            this.EditeurTB.Size = new System.Drawing.Size(172, 63);
            this.EditeurTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(354, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 67);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(354, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 67);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prix ?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(354, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 67);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date de parution ?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(354, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 67);
            this.label8.TabIndex = 11;
            this.label8.Text = "Photo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NonRecontidionneRB);
            this.groupBox1.Controls.Add(this.reconditionneRB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(178, 270);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(172, 63);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // NonRecontidionneRB
            // 
            this.NonRecontidionneRB.AutoSize = true;
            this.NonRecontidionneRB.Location = new System.Drawing.Point(25, 36);
            this.NonRecontidionneRB.Margin = new System.Windows.Forms.Padding(2);
            this.NonRecontidionneRB.Name = "NonRecontidionneRB";
            this.NonRecontidionneRB.Size = new System.Drawing.Size(129, 19);
            this.NonRecontidionneRB.TabIndex = 1;
            this.NonRecontidionneRB.TabStop = true;
            this.NonRecontidionneRB.Text = "Non reconditionné";
            this.NonRecontidionneRB.UseVisualStyleBackColor = true;
            // 
            // reconditionneRB
            // 
            this.reconditionneRB.AutoSize = true;
            this.reconditionneRB.Location = new System.Drawing.Point(25, 16);
            this.reconditionneRB.Margin = new System.Windows.Forms.Padding(2);
            this.reconditionneRB.Name = "reconditionneRB";
            this.reconditionneRB.Size = new System.Drawing.Size(108, 19);
            this.reconditionneRB.TabIndex = 0;
            this.reconditionneRB.TabStop = true;
            this.reconditionneRB.Text = "Reconditionné";
            this.reconditionneRB.UseVisualStyleBackColor = true;
            // 
            // DirTB
            // 
            this.DirTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirTB.Location = new System.Drawing.Point(354, 270);
            this.DirTB.Margin = new System.Windows.Forms.Padding(2);
            this.DirTB.Multiline = true;
            this.DirTB.Name = "DirTB";
            this.DirTB.Size = new System.Drawing.Size(172, 63);
            this.DirTB.TabIndex = 13;
            // 
            // CBGenre
            // 
            this.CBGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBGenre.FormattingEnabled = true;
            this.CBGenre.Location = new System.Drawing.Point(530, 2);
            this.CBGenre.Margin = new System.Windows.Forms.Padding(2);
            this.CBGenre.Name = "CBGenre";
            this.CBGenre.Size = new System.Drawing.Size(172, 21);
            this.CBGenre.TabIndex = 14;
            // 
            // PrixTB
            // 
            this.PrixTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrixTB.Location = new System.Drawing.Point(530, 69);
            this.PrixTB.Margin = new System.Windows.Forms.Padding(2);
            this.PrixTB.Multiline = true;
            this.PrixTB.Name = "PrixTB";
            this.PrixTB.Size = new System.Drawing.Size(172, 63);
            this.PrixTB.TabIndex = 15;
            // 
            // SortieDTP
            // 
            this.SortieDTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortieDTP.Location = new System.Drawing.Point(530, 136);
            this.SortieDTP.Margin = new System.Windows.Forms.Padding(2);
            this.SortieDTP.Name = "SortieDTP";
            this.SortieDTP.Size = new System.Drawing.Size(172, 20);
            this.SortieDTP.TabIndex = 16;
            // 
            // ParcourirButton
            // 
            this.ParcourirButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParcourirButton.Location = new System.Drawing.Point(530, 203);
            this.ParcourirButton.Margin = new System.Windows.Forms.Padding(2);
            this.ParcourirButton.Name = "ParcourirButton";
            this.ParcourirButton.Size = new System.Drawing.Size(172, 63);
            this.ParcourirButton.TabIndex = 17;
            this.ParcourirButton.Text = "Parcourir";
            this.ParcourirButton.UseVisualStyleBackColor = true;
            this.ParcourirButton.Click += new System.EventHandler(this.ParcourirPB_Click);
            // 
            // Annuler
            // 
            this.Annuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annuler.Location = new System.Drawing.Point(178, 337);
            this.Annuler.Margin = new System.Windows.Forms.Padding(2);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(172, 68);
            this.Annuler.TabIndex = 18;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider
            // 
            this.Valider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider.Location = new System.Drawing.Point(354, 337);
            this.Valider.Margin = new System.Windows.Forms.Padding(2);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(172, 68);
            this.Valider.TabIndex = 19;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // ApercuPB
            // 
            this.ApercuPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApercuPB.Location = new System.Drawing.Point(531, 271);
            this.ApercuPB.Name = "ApercuPB";
            this.ApercuPB.Size = new System.Drawing.Size(170, 61);
            this.ApercuPB.TabIndex = 20;
            this.ApercuPB.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(708, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jeu Retro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SaisieJeuDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 437);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaisieJeuDlg";
            this.Text = "Ajouter un Jeu";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApercuPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.TextBox PlateformeTB;
        private System.Windows.Forms.TextBox EditeurTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NonRecontidionneRB;
        private System.Windows.Forms.RadioButton reconditionneRB;
        private System.Windows.Forms.TextBox DirTB;
        private System.Windows.Forms.ComboBox CBGenre;
        private System.Windows.Forms.TextBox PrixTB;
        private System.Windows.Forms.DateTimePicker SortieDTP;
        private System.Windows.Forms.Button ParcourirButton;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.PictureBox ApercuPB;
    }
}