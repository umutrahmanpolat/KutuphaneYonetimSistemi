namespace KutuphaneOtomasyonu
{
    partial class FrmOgrenci
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpKitapArama = new System.Windows.Forms.TabPage();
            this.lblOzet = new System.Windows.Forms.Label();
            this.dgvKitapListesi = new System.Windows.Forms.DataGridView();
            this.lblStok = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnOduncTalep = new System.Windows.Forms.Button();
            this.txtFiltreKategori = new System.Windows.Forms.ComboBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.txtHizliAra = new System.Windows.Forms.TextBox();
            this.tpOduncTakip = new System.Windows.Forms.TabPage();
            this.dgvOduncTakip = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpKitapArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapListesi)).BeginInit();
            this.tpOduncTakip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncTakip)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpKitapArama);
            this.tabControl1.Controls.Add(this.tpOduncTakip);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 426);
            this.tabControl1.TabIndex = 7;
            // 
            // tpKitapArama
            // 
            this.tpKitapArama.Controls.Add(this.lblOzet);
            this.tpKitapArama.Controls.Add(this.dgvKitapListesi);
            this.tpKitapArama.Controls.Add(this.lblStok);
            this.tpKitapArama.Controls.Add(this.btnListele);
            this.tpKitapArama.Controls.Add(this.btnOduncTalep);
            this.tpKitapArama.Controls.Add(this.txtFiltreKategori);
            this.tpKitapArama.Controls.Add(this.lblYazar);
            this.tpKitapArama.Controls.Add(this.txtHizliAra);
            this.tpKitapArama.Location = new System.Drawing.Point(4, 25);
            this.tpKitapArama.Name = "tpKitapArama";
            this.tpKitapArama.Padding = new System.Windows.Forms.Padding(3);
            this.tpKitapArama.Size = new System.Drawing.Size(758, 397);
            this.tpKitapArama.TabIndex = 0;
            this.tpKitapArama.Text = "tpKitapArama";
            this.tpKitapArama.UseVisualStyleBackColor = true;
            // 
            // lblOzet
            // 
            this.lblOzet.AutoSize = true;
            this.lblOzet.Location = new System.Drawing.Point(692, 125);
            this.lblOzet.Name = "lblOzet";
            this.lblOzet.Size = new System.Drawing.Size(32, 16);
            this.lblOzet.TabIndex = 25;
            this.lblOzet.Text = "özet";
            // 
            // dgvKitapListesi
            // 
            this.dgvKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapListesi.Location = new System.Drawing.Point(163, 17);
            this.dgvKitapListesi.Name = "dgvKitapListesi";
            this.dgvKitapListesi.RowHeadersWidth = 51;
            this.dgvKitapListesi.RowTemplate.Height = 24;
            this.dgvKitapListesi.Size = new System.Drawing.Size(493, 304);
            this.dgvKitapListesi.TabIndex = 21;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(690, 50);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(34, 16);
            this.lblStok.TabIndex = 24;
            this.lblStok.Text = "Stok";
            this.lblStok.Click += new System.EventHandler(this.lblStok_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(399, 350);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 19;
            this.btnListele.Text = "btnListele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click_1);
            // 
            // btnOduncTalep
            // 
            this.btnOduncTalep.Location = new System.Drawing.Point(26, 135);
            this.btnOduncTalep.Name = "btnOduncTalep";
            this.btnOduncTalep.Size = new System.Drawing.Size(113, 25);
            this.btnOduncTalep.TabIndex = 22;
            this.btnOduncTalep.Text = "btnOduncTalep";
            this.btnOduncTalep.UseVisualStyleBackColor = true;
            this.btnOduncTalep.Click += new System.EventHandler(this.btnOduncTalep_Click);
            // 
            // txtFiltreKategori
            // 
            this.txtFiltreKategori.FormattingEnabled = true;
            this.txtFiltreKategori.Location = new System.Drawing.Point(26, 88);
            this.txtFiltreKategori.Name = "txtFiltreKategori";
            this.txtFiltreKategori.Size = new System.Drawing.Size(121, 24);
            this.txtFiltreKategori.TabIndex = 18;
            this.txtFiltreKategori.SelectedIndexChanged += new System.EventHandler(this.txtFiltreKategori_SelectedIndexChanged);
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(690, 87);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(42, 16);
            this.lblYazar.TabIndex = 23;
            this.lblYazar.Text = "Yazar";
            // 
            // txtHizliAra
            // 
            this.txtHizliAra.Location = new System.Drawing.Point(26, 47);
            this.txtHizliAra.Name = "txtHizliAra";
            this.txtHizliAra.Size = new System.Drawing.Size(100, 22);
            this.txtHizliAra.TabIndex = 17;
            this.txtHizliAra.TextChanged += new System.EventHandler(this.txtHizliAra_TextChanged);
            // 
            // tpOduncTakip
            // 
            this.tpOduncTakip.Controls.Add(this.dgvOduncTakip);
            this.tpOduncTakip.Location = new System.Drawing.Point(4, 25);
            this.tpOduncTakip.Name = "tpOduncTakip";
            this.tpOduncTakip.Padding = new System.Windows.Forms.Padding(3);
            this.tpOduncTakip.Size = new System.Drawing.Size(758, 397);
            this.tpOduncTakip.TabIndex = 1;
            this.tpOduncTakip.Text = "tpOduncTakip";
            this.tpOduncTakip.UseVisualStyleBackColor = true;
            // 
            // dgvOduncTakip
            // 
            this.dgvOduncTakip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduncTakip.Location = new System.Drawing.Point(54, 18);
            this.dgvOduncTakip.Name = "dgvOduncTakip";
            this.dgvOduncTakip.RowHeadersWidth = 51;
            this.dgvOduncTakip.RowTemplate.Height = 24;
            this.dgvOduncTakip.Size = new System.Drawing.Size(651, 350);
            this.dgvOduncTakip.TabIndex = 20;
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpKitapArama.ResumeLayout(false);
            this.tpKitapArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapListesi)).EndInit();
            this.tpOduncTakip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduncTakip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpOduncTakip;
        private System.Windows.Forms.TabPage tpKitapArama;
        private System.Windows.Forms.Label lblOzet;
        private System.Windows.Forms.DataGridView dgvOduncTakip;
        private System.Windows.Forms.DataGridView dgvKitapListesi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Button btnOduncTalep;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ComboBox txtFiltreKategori;
        private System.Windows.Forms.TextBox txtHizliAra;
    }
}