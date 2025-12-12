namespace KutuphaneOtomasyonu
{
    partial class FrmGiris
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
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayitGit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(210, 79);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(133, 22);
            this.txtEposta.TabIndex = 0;
            this.txtEposta.Text = "e posta";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(391, 79);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(133, 22);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.Text = "şifre";
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(240, 193);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(103, 34);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "btnGiris";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayitGit
            // 
            this.btnKayitGit.Location = new System.Drawing.Point(404, 193);
            this.btnKayitGit.Name = "btnKayitGit";
            this.btnKayitGit.Size = new System.Drawing.Size(103, 34);
            this.btnKayitGit.TabIndex = 3;
            this.btnKayitGit.Text = "btnKayitGit";
            this.btnKayitGit.UseVisualStyleBackColor = true;
            this.btnKayitGit.Click += new System.EventHandler(this.btnKayitGit_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKayitGit);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEposta);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayitGit;
    }
}