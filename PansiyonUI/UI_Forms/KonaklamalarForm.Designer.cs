
namespace PansiyonUI.UI_Forms
{
    partial class KonaklamalarForm
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
            this.tbxKonaklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMusteriAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOdaNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxOdaId = new System.Windows.Forms.TextBox();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxGunSayisi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxAktifmi = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgwKonaklama = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbxOdalar = new System.Windows.Forms.GroupBox();
            this.lblmusteriid = new System.Windows.Forms.Label();
            this.tbxToplamFiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxOdaFiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKonaklama)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konaklama";
            // 
            // tbxKonaklama
            // 
            this.tbxKonaklama.Location = new System.Drawing.Point(129, 13);
            this.tbxKonaklama.Name = "tbxKonaklama";
            this.tbxKonaklama.Size = new System.Drawing.Size(100, 22);
            this.tbxKonaklama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Adı";
            // 
            // tbxMusteriAdi
            // 
            this.tbxMusteriAdi.Location = new System.Drawing.Point(129, 41);
            this.tbxMusteriAdi.Name = "tbxMusteriAdi";
            this.tbxMusteriAdi.Size = new System.Drawing.Size(100, 22);
            this.tbxMusteriAdi.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(44, 261);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Oda No";
            // 
            // tbxOdaNo
            // 
            this.tbxOdaNo.Location = new System.Drawing.Point(38, 86);
            this.tbxOdaNo.Name = "tbxOdaNo";
            this.tbxOdaNo.ReadOnly = true;
            this.tbxOdaNo.Size = new System.Drawing.Size(51, 22);
            this.tbxOdaNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(104, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oda ID";
            // 
            // tbxOdaId
            // 
            this.tbxOdaId.Enabled = false;
            this.tbxOdaId.Location = new System.Drawing.Point(107, 86);
            this.tbxOdaId.Name = "tbxOdaId";
            this.tbxOdaId.ReadOnly = true;
            this.tbxOdaId.Size = new System.Drawing.Size(51, 22);
            this.tbxOdaId.TabIndex = 1;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(136, 128);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpGirisTarihi.TabIndex = 3;
            this.dtpGirisTarihi.ValueChanged += new System.EventHandler(this.dtpGirisTarihi_ValueChanged);
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(136, 156);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpCikisTarihi.TabIndex = 3;
            this.dtpCikisTarihi.ValueChanged += new System.EventHandler(this.dtpCikisTarihi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giriş Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(41, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Çıkış Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gün Sayısı";
            // 
            // tbxGunSayisi
            // 
            this.tbxGunSayisi.Location = new System.Drawing.Point(146, 188);
            this.tbxGunSayisi.Name = "tbxGunSayisi";
            this.tbxGunSayisi.Size = new System.Drawing.Size(100, 22);
            this.tbxGunSayisi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(41, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Toplam Fiyat";
            // 
            // cbxAktifmi
            // 
            this.cbxAktifmi.AutoSize = true;
            this.cbxAktifmi.Location = new System.Drawing.Point(188, 241);
            this.cbxAktifmi.Name = "cbxAktifmi";
            this.cbxAktifmi.Size = new System.Drawing.Size(18, 17);
            this.cbxAktifmi.TabIndex = 4;
            this.cbxAktifmi.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Konaklama Durumu";
            // 
            // dgwKonaklama
            // 
            this.dgwKonaklama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKonaklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKonaklama.Location = new System.Drawing.Point(64, 293);
            this.dgwKonaklama.Name = "dgwKonaklama";
            this.dgwKonaklama.RowHeadersWidth = 51;
            this.dgwKonaklama.RowTemplate.Height = 24;
            this.dgwKonaklama.Size = new System.Drawing.Size(1261, 359);
            this.dgwKonaklama.TabIndex = 6;
            this.dgwKonaklama.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKonaklama_CellContentClick);
            this.dgwKonaklama.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKonaklama_CellDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(129, 261);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gbxOdalar
            // 
            this.gbxOdalar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbxOdalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxOdalar.Location = new System.Drawing.Point(355, 19);
            this.gbxOdalar.Name = "gbxOdalar";
            this.gbxOdalar.Size = new System.Drawing.Size(970, 256);
            this.gbxOdalar.TabIndex = 7;
            this.gbxOdalar.TabStop = false;
            this.gbxOdalar.Text = "ODALAR";
            // 
            // lblmusteriid
            // 
            this.lblmusteriid.AutoSize = true;
            this.lblmusteriid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmusteriid.Location = new System.Drawing.Point(235, 41);
            this.lblmusteriid.Name = "lblmusteriid";
            this.lblmusteriid.Size = new System.Drawing.Size(0, 17);
            this.lblmusteriid.TabIndex = 0;
            // 
            // tbxToplamFiyat
            // 
            this.tbxToplamFiyat.Location = new System.Drawing.Point(146, 216);
            this.tbxToplamFiyat.Name = "tbxToplamFiyat";
            this.tbxToplamFiyat.Size = new System.Drawing.Size(100, 22);
            this.tbxToplamFiyat.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(177, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Oda Fiyat";
            // 
            // tbxOdaFiyat
            // 
            this.tbxOdaFiyat.Enabled = false;
            this.tbxOdaFiyat.Location = new System.Drawing.Point(180, 86);
            this.tbxOdaFiyat.Name = "tbxOdaFiyat";
            this.tbxOdaFiyat.ReadOnly = true;
            this.tbxOdaFiyat.Size = new System.Drawing.Size(75, 22);
            this.tbxOdaFiyat.TabIndex = 1;
            // 
            // KonaklamalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 664);
            this.Controls.Add(this.tbxToplamFiyat);
            this.Controls.Add(this.gbxOdalar);
            this.Controls.Add(this.dgwKonaklama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxAktifmi);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbxOdaFiyat);
            this.Controls.Add(this.tbxOdaId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxOdaNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxGunSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxMusteriAdi);
            this.Controls.Add(this.lblmusteriid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKonaklama);
            this.Controls.Add(this.label1);
            this.Name = "KonaklamalarForm";
            this.Text = "Konaklamalar";
            this.Load += new System.EventHandler(this.KonaklamalarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKonaklama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKonaklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMusteriAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOdaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxOdaId;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxGunSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxAktifmi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgwKonaklama;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox gbxOdalar;
        private System.Windows.Forms.Label lblmusteriid;
        private System.Windows.Forms.TextBox tbxToplamFiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxOdaFiyat;
    }
}