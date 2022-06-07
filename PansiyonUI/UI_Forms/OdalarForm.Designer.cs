
namespace PansiyonUI.UI_Forms
{
    partial class OdalarForm
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
            this.dgwOdaList = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOdaId = new System.Windows.Forms.TextBox();
            this.tbxOdaNo = new System.Windows.Forms.TextBox();
            this.tbxOdaFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkMusait = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOdaList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOdaList
            // 
            this.dgwOdaList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOdaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOdaList.Location = new System.Drawing.Point(187, 12);
            this.dgwOdaList.Name = "dgwOdaList";
            this.dgwOdaList.RowHeadersWidth = 51;
            this.dgwOdaList.RowTemplate.Height = 24;
            this.dgwOdaList.Size = new System.Drawing.Size(962, 498);
            this.dgwOdaList.TabIndex = 0;
            this.dgwOdaList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOdaList_CellDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 182);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(94, 182);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 212);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(93, 211);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oda ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Oda NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat";
            // 
            // tbxOdaId
            // 
            this.tbxOdaId.Enabled = false;
            this.tbxOdaId.Location = new System.Drawing.Point(64, 63);
            this.tbxOdaId.Name = "tbxOdaId";
            this.tbxOdaId.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaId.TabIndex = 8;
            // 
            // tbxOdaNo
            // 
            this.tbxOdaNo.Location = new System.Drawing.Point(64, 90);
            this.tbxOdaNo.Name = "tbxOdaNo";
            this.tbxOdaNo.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaNo.TabIndex = 8;
            // 
            // tbxOdaFiyat
            // 
            this.tbxOdaFiyat.Location = new System.Drawing.Point(64, 116);
            this.tbxOdaFiyat.Name = "tbxOdaFiyat";
            this.tbxOdaFiyat.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaFiyat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müsaitlik";
            // 
            // checkMusait
            // 
            this.checkMusait.AutoSize = true;
            this.checkMusait.Location = new System.Drawing.Point(74, 144);
            this.checkMusait.Name = "checkMusait";
            this.checkMusait.Size = new System.Drawing.Size(71, 21);
            this.checkMusait.TabIndex = 9;
            this.checkMusait.Text = "Müsait";
            this.checkMusait.UseVisualStyleBackColor = true;
            // 
            // OdalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1162, 522);
            this.Controls.Add(this.checkMusait);
            this.Controls.Add(this.tbxOdaFiyat);
            this.Controls.Add(this.tbxOdaNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxOdaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwOdaList);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "OdalarForm";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.OdalarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOdaList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOdaId;
        private System.Windows.Forms.TextBox tbxOdaNo;
        private System.Windows.Forms.TextBox tbxOdaFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkMusait;
        private System.Windows.Forms.DataGridView dgwOdaList;
    }
}