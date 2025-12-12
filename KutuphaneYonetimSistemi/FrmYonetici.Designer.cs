namespace KutuphaneOtomasyonu
{
    partial class FrmYonetici
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
            this.tpEkle1 = new System.Windows.Forms.TabControl();
            this.tpEkle = new System.Windows.Forms.TabPage();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYayinYili = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.tpListele = new System.Windows.Forms.TabPage();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.btnRolAta = new System.Windows.Forms.Button();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.tpRaporlar = new System.Windows.Forms.TabPage();
            this.dgvRaporSonucu = new System.Windows.Forms.DataGridView();
            this.btnRaporGoster = new System.Windows.Forms.Button();
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.tpEkle1.SuspendLayout();
            this.tpEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.tpListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.tpRaporlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporSonucu)).BeginInit();
            this.SuspendLayout();
            // 
            // tpEkle1
            // 
            this.tpEkle1.Controls.Add(this.tpEkle);
            this.tpEkle1.Controls.Add(this.tpListele);
            this.tpEkle1.Controls.Add(this.tpRaporlar);
            this.tpEkle1.Location = new System.Drawing.Point(12, 44);
            this.tpEkle1.Name = "tpEkle1";
            this.tpEkle1.SelectedIndex = 0;
            this.tpEkle1.Size = new System.Drawing.Size(783, 364);
            this.tpEkle1.TabIndex = 0;
            // 
            // tpEkle
            // 
            this.tpEkle.Controls.Add(this.dgvKitaplar);
            this.tpEkle.Controls.Add(this.btnKitapSil);
            this.tpEkle.Controls.Add(this.btnKitapEkle);
            this.tpEkle.Controls.Add(this.txtKitapAdi);
            this.tpEkle.Controls.Add(this.txtOzet);
            this.tpEkle.Controls.Add(this.txtKategori);
            this.tpEkle.Controls.Add(this.txtStok);
            this.tpEkle.Controls.Add(this.txtYayinevi);
            this.tpEkle.Controls.Add(this.txtYayinYili);
            this.tpEkle.Controls.Add(this.txtYazar);
            this.tpEkle.Controls.Add(this.txtSayfaSayisi);
            this.tpEkle.Location = new System.Drawing.Point(4, 25);
            this.tpEkle.Name = "tpEkle";
            this.tpEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpEkle.Size = new System.Drawing.Size(775, 335);
            this.tpEkle.TabIndex = 0;
            this.tpEkle.Text = "Kitap Ekle";
            this.tpEkle.UseVisualStyleBackColor = true;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(32, 68);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.RowHeadersWidth = 51;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.Size = new System.Drawing.Size(668, 150);
            this.dgvKitaplar.TabIndex = 1;
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Location = new System.Drawing.Point(525, 276);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(100, 23);
            this.btnKitapSil.TabIndex = 4;
            this.btnKitapSil.Text = "btnKitapSil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(641, 276);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(100, 23);
            this.btnKitapEkle.TabIndex = 2;
            this.btnKitapEkle.Text = "btnKitapEkle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(15, 6);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(83, 22);
            this.txtKitapAdi.TabIndex = 1;
            this.txtKitapAdi.Text = "txtKitapAdi";
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(690, 6);
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(79, 22);
            this.txtOzet.TabIndex = 1;
            this.txtOzet.Text = "txtOzet";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(219, 6);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(84, 22);
            this.txtKategori.TabIndex = 1;
            this.txtKategori.Text = "txtKategori";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(608, 6);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(76, 22);
            this.txtStok.TabIndex = 1;
            this.txtStok.Text = "txtStok";
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(413, 6);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(84, 22);
            this.txtYayinevi.TabIndex = 1;
            this.txtYayinevi.Text = "txtYayinevi";
            // 
            // txtYayinYili
            // 
            this.txtYayinYili.Location = new System.Drawing.Point(318, 6);
            this.txtYayinYili.Name = "txtYayinYili";
            this.txtYayinYili.Size = new System.Drawing.Size(85, 22);
            this.txtYayinYili.TabIndex = 1;
            this.txtYayinYili.Text = "txtYayinYili";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(117, 6);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(86, 22);
            this.txtYazar.TabIndex = 1;
            this.txtYazar.Text = "txtYazar";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(514, 6);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(78, 22);
            this.txtSayfaSayisi.TabIndex = 1;
            this.txtSayfaSayisi.Text = "txtSayfaSayisi";
            // 
            // tpListele
            // 
            this.tpListele.Controls.Add(this.btnPersonelEkle);
            this.tpListele.Controls.Add(this.btnKullaniciSil);
            this.tpListele.Controls.Add(this.btnRolAta);
            this.tpListele.Controls.Add(this.dgvKullanicilar);
            this.tpListele.Location = new System.Drawing.Point(4, 25);
            this.tpListele.Name = "tpListele";
            this.tpListele.Padding = new System.Windows.Forms.Padding(3);
            this.tpListele.Size = new System.Drawing.Size(775, 335);
            this.tpListele.TabIndex = 1;
            this.tpListele.Text = "Kitap Listeleme / Silme";
            this.tpListele.UseVisualStyleBackColor = true;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(596, 275);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(124, 23);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "btnPersonelEkle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(453, 275);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(108, 23);
            this.btnKullaniciSil.TabIndex = 1;
            this.btnKullaniciSil.Text = "btnKullaniciSil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnRolAta
            // 
            this.btnRolAta.Location = new System.Drawing.Point(346, 275);
            this.btnRolAta.Name = "btnRolAta";
            this.btnRolAta.Size = new System.Drawing.Size(75, 23);
            this.btnRolAta.TabIndex = 1;
            this.btnRolAta.Text = "btnRolAta";
            this.btnRolAta.UseVisualStyleBackColor = true;
            this.btnRolAta.Click += new System.EventHandler(this.btnRolAta_Click);
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(19, 49);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.Size = new System.Drawing.Size(729, 150);
            this.dgvKullanicilar.TabIndex = 3;
            // 
            // tpRaporlar
            // 
            this.tpRaporlar.Controls.Add(this.dgvRaporSonucu);
            this.tpRaporlar.Controls.Add(this.btnRaporGoster);
            this.tpRaporlar.Controls.Add(this.cmbRaporTuru);
            this.tpRaporlar.Location = new System.Drawing.Point(4, 25);
            this.tpRaporlar.Name = "tpRaporlar";
            this.tpRaporlar.Padding = new System.Windows.Forms.Padding(3);
            this.tpRaporlar.Size = new System.Drawing.Size(775, 335);
            this.tpRaporlar.TabIndex = 2;
            this.tpRaporlar.Text = "tpRaporlar";
            this.tpRaporlar.UseVisualStyleBackColor = true;
            // 
            // dgvRaporSonucu
            // 
            this.dgvRaporSonucu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporSonucu.Location = new System.Drawing.Point(203, 59);
            this.dgvRaporSonucu.Name = "dgvRaporSonucu";
            this.dgvRaporSonucu.RowHeadersWidth = 51;
            this.dgvRaporSonucu.RowTemplate.Height = 24;
            this.dgvRaporSonucu.Size = new System.Drawing.Size(551, 221);
            this.dgvRaporSonucu.TabIndex = 1;
            // 
            // btnRaporGoster
            // 
            this.btnRaporGoster.Location = new System.Drawing.Point(20, 89);
            this.btnRaporGoster.Name = "btnRaporGoster";
            this.btnRaporGoster.Size = new System.Drawing.Size(132, 23);
            this.btnRaporGoster.TabIndex = 1;
            this.btnRaporGoster.Text = "btnRaporGoster";
            this.btnRaporGoster.UseVisualStyleBackColor = true;
            this.btnRaporGoster.Click += new System.EventHandler(this.btnRaporGoster_Click);
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.FormattingEnabled = true;
            this.cmbRaporTuru.Location = new System.Drawing.Point(20, 44);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbRaporTuru.TabIndex = 1;
            // 
            // FrmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tpEkle1);
            this.Name = "FrmYonetici";
            this.Text = "FrmYonetici";
            this.Load += new System.EventHandler(this.FrmYonetici_Load);
            this.tpEkle1.ResumeLayout(false);
            this.tpEkle.ResumeLayout(false);
            this.tpEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.tpListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.tpRaporlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporSonucu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpEkle1;
        private System.Windows.Forms.TabPage tpEkle;
        private System.Windows.Forms.TabPage tpListele;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYayinYili;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnRolAta;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.TabPage tpRaporlar;
        private System.Windows.Forms.DataGridView dgvRaporSonucu;
        private System.Windows.Forms.Button btnRaporGoster;
        private System.Windows.Forms.ComboBox cmbRaporTuru;
        private System.Windows.Forms.DataGridView dgvKitaplar;
    }
}