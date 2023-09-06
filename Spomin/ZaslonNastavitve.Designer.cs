namespace Spomin
{
    partial class ZaslonNastavitve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaslonNastavitve));
            this.zapri = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.temaSlicic = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zacni = new System.Windows.Forms.Button();
            this.naloziSliko = new System.Windows.Forms.PictureBox();
            this.nalozi = new System.Windows.Forms.Button();
            this.shrani = new System.Windows.Forms.Button();
            this.izberiHrbtsce = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.naloziSliko)).BeginInit();
            this.SuspendLayout();
            // 
            // zapri
            // 
            this.zapri.AutoSize = true;
            this.zapri.BackColor = System.Drawing.Color.Firebrick;
            this.zapri.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.zapri.Location = new System.Drawing.Point(228, 752);
            this.zapri.Name = "zapri";
            this.zapri.Size = new System.Drawing.Size(116, 46);
            this.zapri.TabIndex = 0;
            this.zapri.Text = "Zapri";
            this.zapri.UseVisualStyleBackColor = false;
            this.zapri.Click += new System.EventHandler(this.zapri_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3:2 ",
            "4:2 ",
            "4:3 ",
            "4:4",
            "5:4 ",
            "6:4 ",
            "6:5 ",
            "8:4 "});
            this.comboBox1.Location = new System.Drawing.Point(454, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 36);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.dimenzijeIgralnePovrsine_SelectedIndexChanged);
            // 
            // temaSlicic
            // 
            this.temaSlicic.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.temaSlicic.FormattingEnabled = true;
            this.temaSlicic.Items.AddRange(new object[] {
            "Risani junaki",
            "Smejkoti"});
            this.temaSlicic.Location = new System.Drawing.Point(353, 175);
            this.temaSlicic.Name = "temaSlicic";
            this.temaSlicic.Size = new System.Drawing.Size(423, 36);
            this.temaSlicic.Sorted = true;
            this.temaSlicic.TabIndex = 2;
            this.temaSlicic.SelectedIndexChanged += new System.EventHandler(this.temaSlicic_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(132, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dimenzija igralne površine: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(196, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tema sličic: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(132, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hrbtna stran kart:";
            // 
            // zacni
            // 
            this.zacni.AutoSize = true;
            this.zacni.BackColor = System.Drawing.Color.Firebrick;
            this.zacni.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.zacni.Location = new System.Drawing.Point(586, 752);
            this.zacni.Name = "zacni";
            this.zacni.Size = new System.Drawing.Size(116, 46);
            this.zacni.TabIndex = 6;
            this.zacni.Text = "Začni";
            this.zacni.UseVisualStyleBackColor = false;
            this.zacni.Click += new System.EventHandler(this.zacni_Click);
            // 
            // naloziSliko
            // 
            this.naloziSliko.Location = new System.Drawing.Point(342, 338);
            this.naloziSliko.Name = "naloziSliko";
            this.naloziSliko.Size = new System.Drawing.Size(250, 250);
            this.naloziSliko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.naloziSliko.TabIndex = 8;
            this.naloziSliko.TabStop = false;
            // 
            // nalozi
            // 
            this.nalozi.AutoSize = true;
            this.nalozi.BackColor = System.Drawing.Color.Firebrick;
            this.nalozi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.nalozi.Location = new System.Drawing.Point(539, 613);
            this.nalozi.Name = "nalozi";
            this.nalozi.Size = new System.Drawing.Size(200, 46);
            this.nalozi.TabIndex = 11;
            this.nalozi.Text = "Naloži";
            this.nalozi.UseVisualStyleBackColor = false;
            this.nalozi.Click += new System.EventHandler(this.nalozi_Click);
            // 
            // shrani
            // 
            this.shrani.AutoSize = true;
            this.shrani.BackColor = System.Drawing.Color.Firebrick;
            this.shrani.Enabled = false;
            this.shrani.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.shrani.Location = new System.Drawing.Point(194, 613);
            this.shrani.Name = "shrani";
            this.shrani.Size = new System.Drawing.Size(200, 46);
            this.shrani.TabIndex = 12;
            this.shrani.Text = "Shrani";
            this.shrani.UseVisualStyleBackColor = false;
            this.shrani.Click += new System.EventHandler(this.shrani_Click);
            // 
            // izberiHrbtsce
            // 
            this.izberiHrbtsce.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izberiHrbtsce.FormattingEnabled = true;
            this.izberiHrbtsce.Location = new System.Drawing.Point(353, 239);
            this.izberiHrbtsce.Name = "izberiHrbtsce";
            this.izberiHrbtsce.Size = new System.Drawing.Size(419, 36);
            this.izberiHrbtsce.Sorted = true;
            this.izberiHrbtsce.TabIndex = 13;
            this.izberiHrbtsce.SelectedIndexChanged += new System.EventHandler(this.izberiHrbtsce_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 57);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nastavitve";
            // 
            // ZaslonNastavitve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spomin.Properties.Resources.menu_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 908);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.izberiHrbtsce);
            this.Controls.Add(this.shrani);
            this.Controls.Add(this.nalozi);
            this.Controls.Add(this.naloziSliko);
            this.Controls.Add(this.zacni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.temaSlicic);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zapri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZaslonNastavitve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spomin";
            this.Load += new System.EventHandler(this.ZaslonNastavitve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.naloziSliko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zapri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox temaSlicic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zacni;
        private System.Windows.Forms.PictureBox naloziSliko;
        private System.Windows.Forms.Button nalozi;
        private System.Windows.Forms.Button shrani;
        private System.Windows.Forms.ComboBox izberiHrbtsce;
        private System.Windows.Forms.Label label4;
    }
}