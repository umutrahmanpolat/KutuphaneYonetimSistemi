using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            OduncTalepleriniListele();
            // Durum ComboBox'ını doldur
            cmbDurum.Items.AddRange(new string[] { "Onaylandi", "TeslimEdildi", "IadeEdildi" });
            cmbDurum.SelectedIndex = 0;
            // Günlük özeti göster
            GunlukOzetiGoster();
        }

        // ------------------------- ÖDÜNÇ TALEPLERİNİ LİSTELEME -------------------------
        private void OduncTalepleriniListele()
        {
            // Beklemede, Onaylandı ve Teslim Edildi durumundaki talepleri listele
            string query = @"
                SELECT 
                    O.OduncId, K.Ad + ' ' + K.Soyad AS Ogrenci, T.KitapAdi AS Kitap, 
                    O.TalepTarihi, O.Durum 
                FROM OduncIslemleri O
                INNER JOIN Kullanicilar K ON O.KullaniciId = K.KullaniciId
                INNER JOIN Kitaplar T ON O.KitapId = T.KitapId
                WHERE O.Durum IN ('Beklemede', 'Onaylandi', 'TeslimEdildi')
                ORDER BY O.TalepTarihi DESC";

            try
            {
                DataTable dt = SqlHelper.GetData(query);
                dgvOduncTalepleri.DataSource = dt;
                dgvOduncTalepleri.Columns["OduncId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Talep listesi yüklenirken hata oluştu: " + ex.Message);
            }
        }

        // ------------------------- TALEP DURUMUNU GÜNCELLEME -------------------------
        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOduncTalepleri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir talep seçin.", "Uyarı");
                return;
            }

            int oduncId = Convert.ToInt32(dgvOduncTalepleri.SelectedRows[0].Cells["OduncId"].Value);
            string yeniDurum = cmbDurum.SelectedItem.ToString();
            string mevcutDurum = dgvOduncTalepleri.SelectedRows[0].Cells["Durum"].Value.ToString();
            string tarihSutunu = ""; // Güncellenecek tarih sütunu

            if (yeniDurum == mevcutDurum)
            {
                MessageBox.Show("Durum zaten seçtiğiniz değerde.", "Uyarı");
                return;
            }

            
            if (yeniDurum == "Onaylandi")
            {
                tarihSutunu = "OnayTarihi";
            }
            else if (yeniDurum == "TeslimEdildi")
            {
                tarihSutunu = "TeslimTarihi";
            }
            else if (yeniDurum == "IadeEdildi")
            {
                tarihSutunu = "IadeTarihi";
            }

            // Eğer yeniDurum 'IadeEdildi' ise, ilgili kitabın stoğunu artırmamız gerekir.
            if (yeniDurum == "IadeEdildi")
            {
                StoguArtir(oduncId); // Stok artırma metodunu çağır
            }

            try
            {
                string updateQuery;

                // Eğer durum IadeEdildi ise gecikme kontrolü de yapılabilir (ileri düzey)

                if (!string.IsNullOrEmpty(tarihSutunu))
                {
                    updateQuery = $"UPDATE OduncIslemleri SET Durum = @durum, {tarihSutunu} = GETDATE() WHERE OduncId = @id";
                }
                else
                {
                    updateQuery = "UPDATE OduncIslemleri SET Durum = @durum WHERE OduncId = @id";
                }

                SqlParameter[] p = {
                    new SqlParameter("@durum", yeniDurum),
                    new SqlParameter("@id", oduncId)
                };

                SqlHelper.ExecuteQuery(updateQuery, p);
                MessageBox.Show("Talep durumu başarıyla güncellendi: " + yeniDurum);
                OduncTalepleriniListele(); // Listeyi güncelle
                GunlukOzetiGoster(); // Özeti güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Durum güncellenirken hata oluştu: " + ex.Message);
            }
        }

        // ------------------------- İADE EDİLİNCE STOĞU ARTIRMA -------------------------
        private void StoguArtir(int oduncId)
        {
            // Bu taleple ilişkili kitabın ID'sini bul ve stoğu 1 artır
            string query = @"
                UPDATE Kitaplar 
                SET Stok = Stok + 1 
                WHERE KitapId = (SELECT KitapId FROM OduncIslemleri WHERE OduncId = @oid)";

            SqlParameter[] p = { new SqlParameter("@oid", oduncId) };
            SqlHelper.ExecuteQuery(query, p);
        }

        // ------------------------- GÜNLÜK ÖDÜNÇ ÖZETİ -------------------------
        private void GunlukOzetiGoster()
        {
            DateTime bugun = DateTime.Today;
            // Günlük verilen kitap sayısı
            string verilenQuery = "SELECT COUNT(*) FROM OduncIslemleri WHERE Durum = 'TeslimEdildi' AND CAST(TeslimTarihi AS DATE) = @bugun";
            // Günlük iade edilen kitap sayısı
            string iadeQuery = "SELECT COUNT(*) FROM OduncIslemleri WHERE Durum = 'IadeEdildi' AND CAST(IadeTarihi AS DATE) = @bugun";

            SqlParameter[] p = { new SqlParameter("@bugun", bugun) };

            try
            {
                // ExecuteScalar ile tek bir değer çekme
                DataTable dtVerilen = SqlHelper.GetData(verilenQuery, p);
                DataTable dtIade = SqlHelper.GetData(iadeQuery, p);

                int verilenSayi = dtVerilen.Rows.Count > 0 ? Convert.ToInt32(dtVerilen.Rows[0][0]) : 0;
                int iadeSayi = dtIade.Rows.Count > 0 ? Convert.ToInt32(dtIade.Rows[0][0]) : 0;

                // Label'lara değerleri yazdır (Kontrol isimlerini tasarımına göre ayarla: lblVerilenSayi, lblIadeSayi)
                // lblVerilenSayi.Text = verilenSayi.ToString();
                // lblIadeSayi.Text = iadeSayi.ToString();

                // Geciken kitapları listele
                GecikenKitaplariListele();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Günlük özet alınırken hata oluştu: " + ex.Message);
            }
        }

        // ------------------------- GECİKEN KİTAPLAR LİSTESİ -------------------------
        private void GecikenKitaplariListele()
        {
            // Teslim edilmesi gereken süreyi (Örn: 15 gün) aşmış olan ve henüz iade edilmemiş kitapları listele.
            // Bu örnekte kütüphane kuralını 15 gün olarak kabul edelim.
            string gecikenQuery = @"
                SELECT 
                    O.OduncId, K.Ad + ' ' + K.Soyad AS Ogrenci, T.KitapAdi AS Kitap, 
                    O.TeslimTarihi, DATEDIFF(day, O.TeslimTarihi, GETDATE()) AS GecikmeSuresiGun
                FROM OduncIslemleri O
                INNER JOIN Kullanicilar K ON O.KullaniciId = K.KullaniciId
                INNER JOIN Kitaplar T ON O.KitapId = T.KitapId
                WHERE O.Durum = 'TeslimEdildi' 
                AND DATEDIFF(day, O.TeslimTarihi, GETDATE()) > 15 
                ORDER BY GecikmeSuresiGun DESC";

            try
            {
                DataTable dtGecikenler = SqlHelper.GetData(gecikenQuery);
                dgvGecikenler.DataSource = dtGecikenler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geciken kitaplar listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void GunlukKitapSayisi_Click(object sender, EventArgs e)
        {

        }
    }
}