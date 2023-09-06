namespace Spomin
{
    partial class ZacetniZaslon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZacetniZaslon));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gumbZacni = new System.Windows.Forms.Button();
            this.uporabnik = new System.Windows.Forms.TextBox();
            this.gumbNadtavitve = new System.Windows.Forms.Button();
            this.gumbNavodila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodošli v igri spomin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(174, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uporabniško ime:";
            // 
            // gumbZacni
            // 
            this.gumbZacni.AutoSize = true;
            this.gumbZacni.BackColor = System.Drawing.Color.Firebrick;
            this.gumbZacni.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.gumbZacni.ForeColor = System.Drawing.Color.Black;
            this.gumbZacni.Location = new System.Drawing.Point(287, 360);
            this.gumbZacni.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gumbZacni.Name = "gumbZacni";
            this.gumbZacni.Size = new System.Drawing.Size(138, 46);
            this.gumbZacni.TabIndex = 3;
            this.gumbZacni.Text = "Začni";
            this.gumbZacni.UseVisualStyleBackColor = false;
            this.gumbZacni.Click += new System.EventHandler(this.gumbZacni_Click);
            // 
            // uporabnik
            // 
            this.uporabnik.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.uporabnik.Location = new System.Drawing.Point(348, 231);
            this.uporabnik.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uporabnik.Name = "uporabnik";
            this.uporabnik.Size = new System.Drawing.Size(181, 36);
            this.uporabnik.TabIndex = 6;
            // 
            // gumbNadtavitve
            // 
            this.gumbNadtavitve.AutoSize = true;
            this.gumbNadtavitve.BackColor = System.Drawing.Color.Firebrick;
            this.gumbNadtavitve.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.gumbNadtavitve.ForeColor = System.Drawing.Color.Black;
            this.gumbNadtavitve.Location = new System.Drawing.Point(103, 299);
            this.gumbNadtavitve.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gumbNadtavitve.Name = "gumbNadtavitve";
            this.gumbNadtavitve.Size = new System.Drawing.Size(209, 46);
            this.gumbNadtavitve.TabIndex = 7;
            this.gumbNadtavitve.Text = "Nastavitve";
            this.gumbNadtavitve.UseVisualStyleBackColor = false;
            this.gumbNadtavitve.Click += new System.EventHandler(this.gumbNadtavitve_Click);
            // 
            // gumbNavodila
            // 
            this.gumbNavodila.AutoSize = true;
            this.gumbNavodila.BackColor = System.Drawing.Color.Firebrick;
            this.gumbNavodila.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.gumbNavodila.ForeColor = System.Drawing.Color.Black;
            this.gumbNavodila.Location = new System.Drawing.Point(408, 299);
            this.gumbNavodila.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gumbNavodila.Name = "gumbNavodila";
            this.gumbNavodila.Size = new System.Drawing.Size(209, 46);
            this.gumbNavodila.TabIndex = 8;
            this.gumbNavodila.Text = "Navodila";
            this.gumbNavodila.UseVisualStyleBackColor = false;
            this.gumbNavodila.Click += new System.EventHandler(this.gumbNavodila_Click);
            // 
            // ZacetniZaslon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Spomin.Properties.Resources.menu_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 427);
            this.Controls.Add(this.gumbNavodila);
            this.Controls.Add(this.gumbNadtavitve);
            this.Controls.Add(this.uporabnik);
            this.Controls.Add(this.gumbZacni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ZacetniZaslon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spomin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gumbZacni;
        private System.Windows.Forms.TextBox uporabnik;
        private System.Windows.Forms.Button gumbNadtavitve;
        private System.Windows.Forms.Button gumbNavodila;
    }
}