namespace GUI
{
    partial class AddAccessoire
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.RichTextBox();
            this.Fabriquant = new System.Windows.Forms.RichTextBox();
            this.Plateforme = new System.Windows.Forms.RichTextBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.SelectImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Annuler, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Valider, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Nom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Fabriquant, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Plateforme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Type, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SelectImage, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 351);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabriquant ?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 58);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plateforme ?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 58);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 58);
            this.label5.TabIndex = 4;
            this.label5.Text = "Photo ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Annuler
            // 
            this.Annuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annuler.Location = new System.Drawing.Point(3, 293);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(363, 55);
            this.Annuler.TabIndex = 5;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider
            // 
            this.Valider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Valider.Location = new System.Drawing.Point(372, 293);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(364, 55);
            this.Valider.TabIndex = 6;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Nom
            // 
            this.Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nom.Location = new System.Drawing.Point(372, 3);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(364, 52);
            this.Nom.TabIndex = 7;
            this.Nom.Text = "";
            // 
            // Fabriquant
            // 
            this.Fabriquant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fabriquant.Location = new System.Drawing.Point(372, 61);
            this.Fabriquant.Name = "Fabriquant";
            this.Fabriquant.Size = new System.Drawing.Size(364, 52);
            this.Fabriquant.TabIndex = 8;
            this.Fabriquant.Text = "";
            // 
            // Plateforme
            // 
            this.Plateforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plateforme.Location = new System.Drawing.Point(372, 119);
            this.Plateforme.Name = "Plateforme";
            this.Plateforme.Size = new System.Drawing.Size(364, 52);
            this.Plateforme.TabIndex = 9;
            this.Plateforme.Text = "";
            // 
            // Type
            // 
            this.Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(372, 177);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(364, 21);
            this.Type.TabIndex = 10;
            // 
            // SelectImage
            // 
            this.SelectImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectImage.Location = new System.Drawing.Point(372, 235);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(364, 52);
            this.SelectImage.TabIndex = 11;
            this.SelectImage.Text = "Séléctionner";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // AddAccessoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 351);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddAccessoire";
            this.Text = "Ajouter un Jeu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.RichTextBox Nom;
        private System.Windows.Forms.RichTextBox Fabriquant;
        private System.Windows.Forms.RichTextBox Plateforme;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button SelectImage;
    }
}