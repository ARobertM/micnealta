namespace Tutoring_PAW___SISC_2022__codul_meu_
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.cbSpecializare = new System.Windows.Forms.ComboBox();
            this.tbPctTeorie = new System.Windows.Forms.TextBox();
            this.tbPctPractic = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data interviu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume persoana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specializare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Punctaj teorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Punctaj practic";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(212, 36);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(237, 22);
            this.dtpData.TabIndex = 5;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(212, 80);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(237, 22);
            this.tbNume.TabIndex = 6;
            // 
            // cbSpecializare
            // 
            this.cbSpecializare.FormattingEnabled = true;
            this.cbSpecializare.Items.AddRange(new object[] {
            "Administrator BD",
            "Analist programator",
            "Dezvoltare web"});
            this.cbSpecializare.Location = new System.Drawing.Point(212, 130);
            this.cbSpecializare.Name = "cbSpecializare";
            this.cbSpecializare.Size = new System.Drawing.Size(237, 24);
            this.cbSpecializare.TabIndex = 7;
            // 
            // tbPctTeorie
            // 
            this.tbPctTeorie.Location = new System.Drawing.Point(212, 183);
            this.tbPctTeorie.Name = "tbPctTeorie";
            this.tbPctTeorie.Size = new System.Drawing.Size(237, 22);
            this.tbPctTeorie.TabIndex = 8;
            // 
            // tbPctPractic
            // 
            this.tbPctPractic.Location = new System.Drawing.Point(212, 239);
            this.tbPctPractic.Name = "tbPctPractic";
            this.tbPctPractic.Size = new System.Drawing.Size(237, 22);
            this.tbPctPractic.TabIndex = 9;
            // 
            // btnAdauga
            // 
            this.btnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdauga.Location = new System.Drawing.Point(137, 330);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(211, 63);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga interviu";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 434);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbPctPractic);
            this.Controls.Add(this.tbPctTeorie);
            this.Controls.Add(this.cbSpecializare);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker dtpData;
        public System.Windows.Forms.TextBox tbNume;
        public System.Windows.Forms.ComboBox cbSpecializare;
        public System.Windows.Forms.TextBox tbPctTeorie;
        public System.Windows.Forms.Button btnAdauga;
        public System.Windows.Forms.TextBox tbPctPractic;
    }
}