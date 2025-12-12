using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KutuphaneOtomasyonu; // Düzeltildi

namespace KutuphaneOtomasyonu // DÜZELTİLDİ
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Zorunlu Alan Kontrolü 
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Ad, Soyad, E-posta ve Şifre alanları boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Parola Güçlülüğü Kontrolü 
            string sifreDeseni = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            if (!Regex.IsMatch(txtSifre.Text, sifreDeseni))
            {
                MessageBox.Show("Parola en az 8 karakter olmalı ve bir büyük harf, bir küçük harf ile bir sayı içermelidir.", "Güvenlik Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "INSERT INTO Kullanicilar (Ad, Soyad, Eposta, Sifre, OkulNo, Telefon, Rol) VALUES (@ad, @soyad, @eposta, @sifre, @okulno, @tel, 'Ogrenci')";

                SqlParameter[] p = {
                    new SqlParameter("@ad", txtAd.Text),
                    new SqlParameter("@soyad", txtSoyad.Text),
                    new SqlParameter("@eposta", txtEposta.Text),
                    new SqlParameter("@sifre", txtSifre.Text),
                    new SqlParameter("@okulno", txtOkulNo.Text),
                    new SqlParameter("@tel", txtTelefon.Text)
                };

                SqlHelper.ExecuteQuery(query, p);
                MessageBox.Show("Kayıt Başarılı! Giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Sadece kayıt formunu kapatır
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}