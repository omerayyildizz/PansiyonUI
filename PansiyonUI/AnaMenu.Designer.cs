
namespace PansiyonUI
{
    partial class AnaMenu
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKonaklama = new System.Windows.Forms.Button();
            this.btnOda = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.pForms = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btnCikis);
            this.pMenu.Controls.Add(this.btnKonaklama);
            this.pMenu.Controls.Add(this.btnOda);
            this.pMenu.Controls.Add(this.btnMusteri);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(120, 670);
            this.pMenu.TabIndex = 1;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(5, 606);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(112, 52);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKonaklama
            // 
            this.btnKonaklama.Location = new System.Drawing.Point(3, 151);
            this.btnKonaklama.Name = "btnKonaklama";
            this.btnKonaklama.Size = new System.Drawing.Size(112, 52);
            this.btnKonaklama.TabIndex = 2;
            this.btnKonaklama.Text = "KONAKLAMA";
            this.btnKonaklama.UseVisualStyleBackColor = true;
            this.btnKonaklama.Click += new System.EventHandler(this.btnKonaklama_Click);
            // 
            // btnOda
            // 
            this.btnOda.Location = new System.Drawing.Point(3, 81);
            this.btnOda.Name = "btnOda";
            this.btnOda.Size = new System.Drawing.Size(112, 52);
            this.btnOda.TabIndex = 1;
            this.btnOda.Text = "ODA";
            this.btnOda.UseVisualStyleBackColor = true;
            this.btnOda.Click += new System.EventHandler(this.btnOda_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Location = new System.Drawing.Point(3, 13);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(112, 52);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "MÜŞTERİ";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // pForms
            // 
            this.pForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pForms.Location = new System.Drawing.Point(120, 0);
            this.pForms.Name = "pForms";
            this.pForms.Size = new System.Drawing.Size(1344, 670);
            this.pForms.TabIndex = 1;
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 670);
            this.Controls.Add(this.pForms);
            this.Controls.Add(this.pMenu);
            this.IsMdiContainer = true;
            this.Name = "AnaMenu";
            this.Text = "ANA MENÜ";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pForms;
        private System.Windows.Forms.Button btnKonaklama;
        private System.Windows.Forms.Button btnOda;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnCikis;
    }
}

