using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Rol Atama için InputBox'ı destekler
using System.Linq;

namespace KutuphaneOtomasyonu
{
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }

        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            KitaplariListele();
            KullanicilariListele(); // Kullanıcı listesini yükle
            RaporTuruDoldur(); // Rapor ComboBox'ını doldur
        }

        // ------------------------- KİTAP LİSTELEME VE YÖNETİMİ -------------------------
        private void KitaplariListele()
        {
            string query = "SELECT KitapId, KitapAdi, Yazar, Yayinevi, YayinYili, Kategori, Stok, Ozet FROM Kitaplar WHERE SilindiMi = 0";
            try
            {
                DataTable dt = SqlHelper.GetData(query);
                dgvKitaplar.DataSource = dt;

                dgvKitaplar.Columns["KitapId"].Visible = false;
                dgvKitaplar.Columns["Ozet"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKitapAdi.Text) || string.IsNullOrWhiteSpace(txtYazar.Text) || string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Kitap Adı, Yazar ve Stok zorunlu alanlardır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO Kitaplar (KitapAdi, Yazar, Yayinevi, YayinYili, Kategori, SayfaSayisi, Stok, Ozet) " +
                               "VALUES (@ad, @yazar, @yayinevi, @yil, @kategori, @sayfa, @stok, @ozet)";

                SqlParameter[] p = {
                    new SqlParameter("@ad", txtKitapAdi.Text),
                    new SqlParameter("@yazar", txtYazar.Text),
                    new SqlParameter("@yayinevi", txtYayinevi.Text),
                    new SqlParameter("@yil", string.IsNullOrWhiteSpace(txtYayinYili.Text) ? (object)DBNull.Value : Convert.ToInt32(txtYayinYili.Text)),
                    new SqlParameter("@kategori", txtKategori.Text),
                    new SqlParameter("@sayfa", string.IsNullOrWhiteSpace(txtSayfaSayisi.Text) ? (object)DBNull.Value : Convert.ToInt32(txtSayfaSayisi.Text)),
                    new SqlParameter("@stok", Convert.ToInt32(txtStok.Text)),
                    new SqlParameter("@ozet", txtOzet.Text)
                };

                SqlHelper.ExecuteQuery(query, p);
                MessageBox.Show("Kitap Başarıyla Eklendi.");
                KitaplariListele();

                // Textbox'ları temizleme
                foreach (Control item in tpEkle.Controls)
                {
                    if (item is TextBox) item.Text = string.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Yayın Yılı, Sayfa Sayısı ve Stok alanlarına sadece sayı girilebilir.", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir kitap seçin.", "Uyarı");
                return;
            }

            int secilenKitapId = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells["KitapId"].Value);

            if (MessageBox.Show("Seçili kitabı pasife almak istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE Kitaplar SET SilindiMi = 1 WHERE KitapId = @id";
                    SqlParameter[] p = { new SqlParameter("@id", secilenKitapId) };

                    SqlHelper.ExecuteQuery(query, p);
                    MessageBox.Show("Kitap başarıyla pasife alındı.");
                    KitaplariListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pasife alma hatası: " + ex.Message);
                }
            }
        }

        // ------------------------- KULLANICI YÖNETİMİ -------------------------

        private void KullanicilariListele()
        {
            string query = "SELECT KullaniciId, Ad, Soyad, Eposta, Rol, OkulNo, Telefon FROM Kullanicilar WHERE AktifMi = 1";
            try
            {
                DataTable dt = SqlHelper.GetData(query);
                dgvKullanicilar.DataSource = dt;
                dgvKullanicilar.Columns["KullaniciId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcılar listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnRolAta_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen rol atamak istediğiniz bir kullanıcı seçin.", "Uyarı");
                return;
            }

            int secilenKullaniciId = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["KullaniciId"].Value);
            string yeniRol = Interaction.InputBox("Yeni Rolü Girin (Ogrenci, Personel, Yonetici):", "Rol Atama", "", -1, -1);

            if (string.IsNullOrWhiteSpace(yeniRol) ||
                (yeniRol.ToLower() != "ogrenci" && yeniRol.ToLower() != "personel" && yeniRol.ToLower() != "yonetici"))
            {
                MessageBox.Show("Geçerli bir rol girmediniz.", "Hata");
                return;
            }

            try
            {
                string query = "UPDATE Kullanicilar SET Rol = @rol WHERE KullaniciId = @id";
                SqlParameter[] p = {
                    new SqlParameter("@rol", yeniRol),
                    new SqlParameter("@id", secilenKullaniciId)
                };

                SqlHelper.ExecuteQuery(query, p);
                MessageBox.Show(yeniRol + " rolü başarıyla atandı.");
                KullanicilariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rol atarken hata oluştu: " + ex.Message);
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen pasife alınacak bir kullanıcı seçin.", "Uyarı");
                return;
            }

            int secilenKullaniciId = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["KullaniciId"].Value);

            if (MessageBox.Show("Seçili kullanıcıyı pasife (sistemden kaldırmaya) almak istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE Kullanicilar SET AktifMi = 0 WHERE KullaniciId = @id";
                    SqlParameter[] p = { new SqlParameter("@id", secilenKullaniciId) };

                    SqlHelper.ExecuteQuery(query, p);
                    MessageBox.Show("Kullanıcı başarıyla pasife alındı.");
                    KullanicilariListele(); // Listeyi güncelle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Pasife alma hatası: " + ex.Message);
                }
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personel eklemek için, lütfen öncelikle FrmKayit ekranından yeni bir kullanıcı kaydedin ve ardından rolünü Personel olarak güncelleyin.", "Bilgi");
        }

        // ------------------------- RAPORLAR VE ANALİZLER -------------------------

        private void RaporTuruDoldur()
        {
            cmbRaporTuru.Items.Clear();
            cmbRaporTuru.Items.Add("Günlük Ödünç İstatistikleri");
            cmbRaporTuru.Items.Add("Haftalık Ödünç İstatistikleri");
            cmbRaporTuru.Items.Add("Aylık Ödünç İstatistikleri");
            cmbRaporTuru.Items.Add("En Çok Ödünç Alınan Kitaplar");
            cmbRaporTuru.SelectedIndex = 0;
        }

        private void btnRaporGoster_Click(object sender, EventArgs e)
        {
            string secilenRapor = cmbRaporTuru.SelectedItem.ToString();
            DataTable dtRapor;

            switch (secilenRapor)
            {
                case "Günlük Ödünç İstatistikleri":
                    dtRapor = OduncIstatistikleriCek("day");
                    dgvRaporSonucu.DataSource = dtRapor;
                    break;
                case "Haftalık Ödünç İstatistikleri":
                    dtRapor = OduncIstatistikleriCek("week");
                    dgvRaporSonucu.DataSource = dtRapor;
                    break;
                case "Aylık Ödünç İstatistikleri":
                    dtRapor = OduncIstatistikleriCek("month");
                    dgvRaporSonucu.DataSource = dtRapor;
                    break;
                case "En Çok Ödünç Alınan Kitaplar":
                    dtRapor = EnCokOduncAlinanlariCek();
                    dgvRaporSonucu.DataSource = dtRapor;
                    break;
            }
        }

        // --- Rapor Çekme Yardımcı Metotları ---

        private DataTable OduncIstatistikleriCek(string periyot)
        {
            string formatString;
            string sorguBasligi;

            if (periyot == "day")
            {
                formatString = "CONVERT(DATE, TeslimTarihi)";
                sorguBasligi = "Tarih";
            }
            else if (periyot == "week")
            {
                formatString = "DATENAME(wk, TeslimTarihi)";
                sorguBasligi = "Hafta";
            }
            else if (periyot == "month")
            {
                formatString = "DATENAME(month, TeslimTarihi) + ' ' + DATENAME(yy, TeslimTarihi)";
                sorguBasligi = "Ay";
            }
            else
            {
                return new DataTable();
            }

            string query = $@"
                SELECT 
                    {formatString} AS {sorguBasligi},
                    COUNT(OduncId) AS TeslimEdilenKitapSayisi
                FROM OduncIslemleri
                WHERE Durum = 'TeslimEdildi'
                GROUP BY {formatString}
                ORDER BY TeslimEdilenKitapSayisi DESC";

            try
            {
                return SqlHelper.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistik raporu alınırken hata oluştu: " + ex.Message);
                return new DataTable();
            }
        }

        private DataTable EnCokOduncAlinanlariCek()
        {
            string query = @"
                SELECT TOP 10
                    T.KitapAdi,
                    T.Yazar,
                    COUNT(O.OduncId) AS ToplamOduncSayisi
                FROM OduncIslemleri O
                INNER JOIN Kitaplar T ON O.KitapId = T.KitapId
                GROUP BY T.KitapAdi, T.Yazar
                ORDER BY ToplamOduncSayisi DESC";

            try
            {
                return SqlHelper.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("En çok ödünç alınanlar raporu alınırken hata oluştu: " + ex.Message);
                return new DataTable();
            }
        }
    }
}