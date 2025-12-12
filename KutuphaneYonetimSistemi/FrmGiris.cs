using KutuphaneOtomasyonu; // Namespace aynı olduğu için bu satır gerekmeyebilir ama bırakalım.
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        // ------------------------- KAYIT OL YÖNLENDİRMESİ -------------------------
        private void btnKayitGit_Click(object sender, EventArgs e)
        {
            this.Hide(); // Mevcut formu gizle

            FrmKayit frm = new FrmKayit();
            frm.ShowDialog(); // FrmGiris gizli kalırken Kayıt formu açılır

            this.Show(); // Kayıt formu kapandıktan sonra FrmGiris'i tekrar göster
        }

        // ------------------------- GİRİŞ İŞLEMİ -------------------------
        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Hata çözümü için değişkenleri metodun başında tanımlıyoruz.
            string rol = string.Empty;
            string adSoyad = string.Empty;
            int kullaniciId = 0;

            // Türkçe tablo ve sütun isimlerine göre sorgu
            string query = "SELECT * FROM Kullanicilar WHERE Eposta=@eposta AND Sifre=@sifre AND AktifMi = 1";
            SqlParameter[] p = {
                new SqlParameter("@eposta", txtEposta.Text),
                new SqlParameter("@sifre", txtSifre.Text)
            };

            DataTable dt = SqlHelper.GetData(query, p);

            if (dt.Rows.Count > 0)
            {
                // Başarılı giriş: Kullanıcı bilgilerini al
                rol = dt.Rows[0]["Rol"].ToString();
                adSoyad = dt.Rows[0]["Ad"].ToString() + " " + dt.Rows[0]["Soyad"].ToString();
                kullaniciId = Convert.ToInt32(dt.Rows[0]["KullaniciId"]);

                MessageBox.Show("Hoşgeldiniz: " + adSoyad + "\nRol: " + rol);

                this.Hide(); // Giriş formunu gizle

                // Rol Yönlendirmesi
                if (rol == "Ogrenci")
                {
                    FrmOgrenci frm = new FrmOgrenci(kullaniciId);
                    frm.Show();
                }
                else if (rol == "Yonetici")
                {
                    FrmYonetici frm = new FrmYonetici();
                    frm.Show();
                }
                else if (rol == "Personel")
                {
                    FrmPersonel frm = new FrmPersonel();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Hatalı E-posta veya Şifre! Lütfen kontrol ediniz.");
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            // Bu metot boş kalabilir.
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}