namespace KutuphaneOtomasyonu
{
    partial class FrmKayit
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtOkulNo = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(235, 166);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(138, 22);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "Ad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(420, 166);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(138, 22);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "Soyad:";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(235, 207);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(138, 22);
            this.txtEposta.TabIndex = 0;
            this.txtEposta.Text = "Email:";
            // 
            // txtOkulNo
            // 
            this.txtOkulNo.Location = new System.Drawing.Point(235, 252);
            this.txtOkulNo.Name = "txtOkulNo";
            this.txtOkulNo.Size = new System.Drawing.Size(138, 22);
            this.txtOkulNo.TabIndex = 0;
            this.txtOkulNo.Text = "OkulNo:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(420, 207);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(138, 22);
            this.txtTelefon.TabIndex = 0;
            this.txtTelefon.Text = "Telefon:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(420, 252);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(138, 22);
            this.txtSifre.TabIndex = 0;
            this.txtSifre.Text = "Şifre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "kayıt ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtOkulNo);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtAd);
            this.Name = "FrmKayit";
            this.Text = "FrmKayit";
            this.Load += new System.EventHandler(this.FrmKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtOkulNo;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button button1;
    }
}