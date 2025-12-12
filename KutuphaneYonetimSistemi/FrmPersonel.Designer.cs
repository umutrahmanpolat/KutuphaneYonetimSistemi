namespace KutuphaneOtomasyonu
{
    partial class FrmPersonel
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
            this.dgvOduncTalepleri = new System.Windows.Forms.DataGridView();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.OgrenciAdi = new System.Windows.Forms.Label();
            this.KitapAdi = new System.Windows.Forms.Label();
            this.TalepTarihi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVerilenSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIadeSayi = new System.Windows.Forms.Label();
            this.dgvGecikenler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncTalepleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOduncTalepleri
            // 
            this.dgvOduncTalepleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncTalepleri.Location = new System.Drawing.Point(26, 32);
            this.dgvOduncTalepleri.Name = "dgvOduncTalepleri";
            this.dgvOduncTalepleri.RowHeadersWidth = 51;
            this.dgvOduncTalepleri.RowTemplate.Height = 24;
            this.dgvOduncTalepleri.Size = new System.Drawing.Size(572, 175);
            this.dgvOduncTalepleri.TabIndex = 0;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.Location = new System.Drawing.Point(662, 240);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(133, 23);
            this.btnDurumGuncelle.TabIndex = 1;
            this.btnDurumGuncelle.Text = "btnDurumGuncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(674, 148);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 24);
            this.cmbDurum.TabIndex = 2;
            // 
            // OgrenciAdi
            // 
            this.OgrenciAdi.AutoSize = true;
            this.OgrenciAdi.Location = new System.Drawing.Point(698, 32);
            this.OgrenciAdi.Name = "OgrenciAdi";
            this.OgrenciAdi.Size = new System.Drawing.Size(74, 16);
            this.OgrenciAdi.TabIndex = 3;
            this.OgrenciAdi.Text = "OgrenciAdi";
            // 
            // KitapAdi
            // 
            this.KitapAdi.AutoSize = true;
            this.KitapAdi.Location = new System.Drawing.Point(710, 73);
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.Size = new System.Drawing.Size(57, 16);
            this.KitapAdi.TabIndex = 3;
            this.KitapAdi.Text = "KitapAdi";
            // 
            // TalepTarihi
            // 
            this.TalepTarihi.AutoSize = true;
            this.TalepTarihi.Location = new System.Drawing.Point(695, 114);
            this.TalepTarihi.Name = "TalepTarihi";
            this.TalepTarihi.Size = new System.Drawing.Size(77, 16);
            this.TalepTarihi.TabIndex = 3;
            this.TalepTarihi.Text = "TalepTarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "OgrenciAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "OgrenciAdi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "KitapAdi";
            // 
            // lblVerilenSayi
            // 
            this.lblVerilenSayi.AutoSize = true;
            this.lblVerilenSayi.Location = new System.Drawing.Point(698, 347);
            this.lblVerilenSayi.Name = "lblVerilenSayi";
            this.lblVerilenSayi.Size = new System.Drawing.Size(90, 16);
            this.lblVerilenSayi.TabIndex = 3;
            this.lblVerilenSayi.Text = "lblVerilenSayi";
            this.lblVerilenSayi.Click += new System.EventHandler(this.GunlukKitapSayisi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "KitapAdi";
            // 
            // lblIadeSayi
            // 
            this.lblIadeSayi.AutoSize = true;
            this.lblIadeSayi.Location = new System.Drawing.Point(698, 388);
            this.lblIadeSayi.Name = "lblIadeSayi";
            this.lblIadeSayi.Size = new System.Drawing.Size(75, 16);
            this.lblIadeSayi.TabIndex = 3;
            this.lblIadeSayi.Text = "lblIadeSayi";
            // 
            // dgvGecikenler
            // 
            this.dgvGecikenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecikenler.Location = new System.Drawing.Point(26, 240);
            this.dgvGecikenler.Name = "dgvGecikenler";
            this.dgvGecikenler.RowHeadersWidth = 51;
            this.dgvGecikenler.RowTemplate.Height = 24;
            this.dgvGecikenler.Size = new System.Drawing.Size(572, 181);
            this.dgvGecikenler.TabIndex = 0;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TalepTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KitapAdi);
            this.Controls.Add(this.lblIadeSayi);
            this.Controls.Add(this.lblVerilenSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OgrenciAdi);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.dgvGecikenler);
            this.Controls.Add(this.dgvOduncTalepleri);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncTalepleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecikenler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOduncTalepleri;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label OgrenciAdi;
        private System.Windows.Forms.Label KitapAdi;
        private System.Windows.Forms.Label TalepTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVerilenSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIadeSayi;
        private System.Windows.Forms.DataGridView dgvGecikenler;
    }
}