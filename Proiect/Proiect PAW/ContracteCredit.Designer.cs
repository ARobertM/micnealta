namespace Proiect_PAW
{
    partial class frmCalculatorCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculatorCredit));
            this.btnRataLunara = new System.Windows.Forms.Button();
            this.mnuOptiuniCreditDurata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniCreditRataLunara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptiuniCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNouaCalculatie = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.txtRataLunara = new System.Windows.Forms.TextBox();
            this.txtRataDobanda = new System.Windows.Forms.TextBox();
            this.txtNumarPlati = new System.Windows.Forms.TextBox();
            this.txtSumaImprumutata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsEtichetaOptiuni = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRataLunara
            // 
            this.btnRataLunara.Location = new System.Drawing.Point(45, 50);
            this.btnRataLunara.Name = "btnRataLunara";
            this.btnRataLunara.Size = new System.Drawing.Size(201, 81);
            this.btnRataLunara.TabIndex = 0;
            this.btnRataLunara.Text = "Rata lunara";
            this.btnRataLunara.UseVisualStyleBackColor = true;
            this.btnRataLunara.Click += new System.EventHandler(this.btnRataLunara_Click);
            // 
            // mnuOptiuniCreditDurata
            // 
            this.mnuOptiuniCreditDurata.Name = "mnuOptiuniCreditDurata";
            this.mnuOptiuniCreditDurata.Size = new System.Drawing.Size(198, 30);
            this.mnuOptiuniCreditDurata.Text = "&Durata";
            // 
            // mnuOptiuniCreditRataLunara
            // 
            this.mnuOptiuniCreditRataLunara.Name = "mnuOptiuniCreditRataLunara";
            this.mnuOptiuniCreditRataLunara.Size = new System.Drawing.Size(198, 30);
            this.mnuOptiuniCreditRataLunara.Text = "&Rata Lunara";
            // 
            // mnuOptiuniCredit
            // 
            this.mnuOptiuniCredit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuniCreditRataLunara,
            this.mnuOptiuniCreditDurata});
            this.mnuOptiuniCredit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuOptiuniCredit.Name = "mnuOptiuniCredit";
            this.mnuOptiuniCredit.Size = new System.Drawing.Size(89, 29);
            this.mnuOptiuniCredit.Text = "&Optiuni";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptiuniCredit,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Proiect_PAW.Properties.Resources.desktop_wallpaper_minimalist_light_minimalist;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnExit1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 594);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_PAW.Properties.Resources.succes_;
            this.pictureBox1.Location = new System.Drawing.Point(579, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ion Popescu",
            "Maria Gherasim",
            "Tiberiu Mihaila",
            "Oana Savulescu",
            "Rares Bop",
            "Andrei Serban",
            "Robert Ufes",
            "Flavian Ariton",
            "Stefania Comet",
            "Catalina Porumboiu",
            "Florin Ravanelli"});
            this.comboBox1.Location = new System.Drawing.Point(558, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnExit1
            // 
            this.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit1.Location = new System.Drawing.Point(1007, 463);
            this.btnExit1.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(65, 36);
            this.btnExit1.TabIndex = 7;
            this.btnExit1.Text = "EXIT";
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(573, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Alege clientul:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lstAfisare);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(839, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(352, 336);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amortizare";
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 24;
            this.lstAfisare.Location = new System.Drawing.Point(8, 43);
            this.lstAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(330, 268);
            this.lstAfisare.TabIndex = 10;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnNouaCalculatie);
            this.groupBox1.Controls.Add(this.btnCalculeaza);
            this.groupBox1.Controls.Add(this.txtRataLunara);
            this.groupBox1.Controls.Add(this.txtRataDobanda);
            this.groupBox1.Controls.Add(this.txtNumarPlati);
            this.groupBox1.Controls.Add(this.txtSumaImprumutata);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(420, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "lei";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "lei";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "luni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "%";
            // 
            // btnNouaCalculatie
            // 
            this.btnNouaCalculatie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNouaCalculatie.Location = new System.Drawing.Point(119, 268);
            this.btnNouaCalculatie.Margin = new System.Windows.Forms.Padding(4);
            this.btnNouaCalculatie.Name = "btnNouaCalculatie";
            this.btnNouaCalculatie.Size = new System.Drawing.Size(256, 38);
            this.btnNouaCalculatie.TabIndex = 5;
            this.btnNouaCalculatie.Text = "Golire formular";
            this.btnNouaCalculatie.UseVisualStyleBackColor = true;
            this.btnNouaCalculatie.Click += new System.EventHandler(this.btnNouaCalculatie_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculeaza.Location = new System.Drawing.Point(119, 222);
            this.btnCalculeaza.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(256, 39);
            this.btnCalculeaza.TabIndex = 4;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // txtRataLunara
            // 
            this.txtRataLunara.Location = new System.Drawing.Point(201, 161);
            this.txtRataLunara.Margin = new System.Windows.Forms.Padding(4);
            this.txtRataLunara.Name = "txtRataLunara";
            this.txtRataLunara.Size = new System.Drawing.Size(146, 31);
            this.txtRataLunara.TabIndex = 3;
            this.txtRataLunara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRataDobanda
            // 
            this.txtRataDobanda.Location = new System.Drawing.Point(201, 124);
            this.txtRataDobanda.Margin = new System.Windows.Forms.Padding(4);
            this.txtRataDobanda.Name = "txtRataDobanda";
            this.txtRataDobanda.Size = new System.Drawing.Size(146, 31);
            this.txtRataDobanda.TabIndex = 2;
            this.txtRataDobanda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumarPlati
            // 
            this.txtNumarPlati.Location = new System.Drawing.Point(201, 84);
            this.txtNumarPlati.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumarPlati.Name = "txtNumarPlati";
            this.txtNumarPlati.Size = new System.Drawing.Size(146, 31);
            this.txtNumarPlati.TabIndex = 1;
            this.txtNumarPlati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSumaImprumutata
            // 
            this.txtSumaImprumutata.Location = new System.Drawing.Point(201, 43);
            this.txtSumaImprumutata.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumaImprumutata.Name = "txtSumaImprumutata";
            this.txtSumaImprumutata.Size = new System.Drawing.Size(146, 31);
            this.txtSumaImprumutata.TabIndex = 0;
            this.txtSumaImprumutata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSumaImprumutata.TextChanged += new System.EventHandler(this.txtSumaImprumutata_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rata lunara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rata de dobanda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Durata creditului:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suma imprumutata:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEtichetaOptiuni});
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1204, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsEtichetaOptiuni
            // 
            this.tlsEtichetaOptiuni.BackColor = System.Drawing.Color.White;
            this.tlsEtichetaOptiuni.Name = "tlsEtichetaOptiuni";
            this.tlsEtichetaOptiuni.Size = new System.Drawing.Size(58, 20);
            this.tlsEtichetaOptiuni.Text = "Optiuni";
            this.tlsEtichetaOptiuni.Click += new System.EventHandler(this.tlsEtichetaOptiuni_Click);
            // 
            // frmCalculatorCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 594);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRataLunara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalculatorCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contracte Credit";
            this.Load += new System.EventHandler(this.frmCalculatorCredit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRataLunara;
        internal System.Windows.Forms.ToolStripStatusLabel tlsEtichetaOptiuni;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnExit1;
        internal System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnNouaCalculatie;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCreditDurata;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCreditRataLunara;
        private System.Windows.Forms.ToolStripMenuItem mnuOptiuniCredit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.Button btnCalculeaza;
        internal System.Windows.Forms.TextBox txtRataLunara;
        internal System.Windows.Forms.TextBox txtRataDobanda;
        internal System.Windows.Forms.TextBox txtNumarPlati;
        internal System.Windows.Forms.TextBox txtSumaImprumutata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}