namespace GUI
{
    partial class AddConsole
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.RichTextBox();
            this.Fabriquant = new System.Windows.Forms.RichTextBox();
            this.Generation = new System.Windows.Forms.NumericUpDown();
            this.Sortie = new System.Windows.Forms.DateTimePicker();
            this.Prix = new System.Windows.Forms.NumericUpDown();
            this.Manette = new System.Windows.Forms.NumericUpDown();
            this.CBSupport = new System.Windows.Forms.ComboBox();
            this.TypeConsole = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Generation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manette)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Nom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Fabriquant, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Generation, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Sortie, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Prix, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Manette, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBSupport, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.TypeConsole, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabriquant ?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 64);
            this.label3.TabIndex = 2;
            this.label3.Text = "Génération ?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 64);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sortie ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(345, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 64);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre de ports manette ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(345, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 64);
            this.label6.TabIndex = 5;
            this.label6.Text = "Support ?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(345, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 64);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type ?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(516, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 59);
            this.button2.TabIndex = 9;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(345, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 65);
            this.label8.TabIndex = 7;
            this.label8.Text = "Prix ?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(345, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 64);
            this.label9.TabIndex = 10;
            this.label9.Text = "Photo ?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nom
            // 
            this.Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nom.Location = new System.Drawing.Point(174, 3);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(165, 58);
            this.Nom.TabIndex = 11;
            this.Nom.Text = "";
            // 
            // Fabriquant
            // 
            this.Fabriquant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fabriquant.Location = new System.Drawing.Point(174, 67);
            this.Fabriquant.Name = "Fabriquant";
            this.Fabriquant.Size = new System.Drawing.Size(165, 58);
            this.Fabriquant.TabIndex = 12;
            this.Fabriquant.Text = "";
            // 
            // Generation
            // 
            this.Generation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Generation.Location = new System.Drawing.Point(174, 131);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(165, 20);
            this.Generation.TabIndex = 13;
            // 
            // Sortie
            // 
            this.Sortie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sortie.Location = new System.Drawing.Point(174, 195);
            this.Sortie.Name = "Sortie";
            this.Sortie.Size = new System.Drawing.Size(165, 20);
            this.Sortie.TabIndex = 14;
            // 
            // Prix
            // 
            this.Prix.DecimalPlaces = 2;
            this.Prix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prix.Location = new System.Drawing.Point(174, 259);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(165, 20);
            this.Prix.TabIndex = 15;
            // 
            // Manette
            // 
            this.Manette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Manette.Location = new System.Drawing.Point(516, 3);
            this.Manette.Name = "Manette";
            this.Manette.Size = new System.Drawing.Size(168, 20);
            this.Manette.TabIndex = 16;
            // 
            // CBSupport
            // 
            this.CBSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBSupport.FormattingEnabled = true;
            this.CBSupport.Location = new System.Drawing.Point(516, 67);
            this.CBSupport.Name = "CBSupport";
            this.CBSupport.Size = new System.Drawing.Size(168, 21);
            this.CBSupport.TabIndex = 17;
            // 
            // TypeConsole
            // 
            this.TypeConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeConsole.Location = new System.Drawing.Point(516, 131);
            this.TypeConsole.Name = "TypeConsole";
            this.TypeConsole.Size = new System.Drawing.Size(168, 58);
            this.TypeConsole.TabIndex = 18;
            this.TypeConsole.Text = "";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(516, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 58);
            this.button3.TabIndex = 19;
            this.button3.Text = "Séléctionner une photo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // AddConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddConsole";
            this.Text = "AddConsole";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Generation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manette)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Nom;
        private System.Windows.Forms.RichTextBox Fabriquant;
        private System.Windows.Forms.NumericUpDown Generation;
        private System.Windows.Forms.DateTimePicker Sortie;
        private System.Windows.Forms.NumericUpDown Prix;
        private System.Windows.Forms.NumericUpDown Manette;
        private System.Windows.Forms.ComboBox CBSupport;
        private System.Windows.Forms.RichTextBox TypeConsole;
        private System.Windows.Forms.Button button3;
    }
}