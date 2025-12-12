using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic; // List<SqlParameter> kullanmak için eklendi

namespace KutuphaneOtomasyonu
{
    public partial class FrmOgrenci : Form
    {
        // Öğrencinin ID'sini saklayacak değişken
        private int _kullaniciId;

        // Yapıcı metot (Constructor): Giriş ekranından gelen kullanıcı ID'sini alır
        public FrmOgrenci(int kullaniciId)
        {
            InitializeComponent();
            _kullaniciId = kullaniciId;
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            KitaplariListele();
            OduncDurumuTakip(); // Ödünç takip listesini de yükle

            // Kullanılabilirlik için ayarlamalar
            dgvKitapListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Tüm satırı seç
            dgvKitapListesi.MultiSelect = false; // Tek bir kitap seçilebilsin

            // Kategori ComboBox'ı için eklenen olay (Sadece txtFiltreKategori bir ComboBox ise)
            if (txtFiltreKategori is ComboBox cmb)
            {
                // Eğer kategorileri veritabanından çekmek istersen buraya metot çağırabilirsin.
                // cmb.Items.AddRange(new string[] { "Roman", "Tarih", "Bilim Kurgu" });
            }

            // Eğer formda tabControl1 varsa, sekme değişim olayını burada bağlayalım (Manuel olarak bağlandıysa gerek yok)
            // this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
        }

        // ------------------------- KİTAP LİSTELEME VE FİLTRELEME -------------------------

        private void KitaplariListele(string aramaKelimesi = "", string kategori = "")
        {
            // Silinmemiş ve stokta bulunan kitapları listele
            string query = @"
                SELECT KitapId, KitapAdi, Yazar, Yayinevi, YayinYili, Kategori, Stok, Ozet 
                FROM Kitaplar 
                WHERE SilindiMi = 0 
                AND Stok > 0";

            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(aramaKelimesi))
            {
                query += " AND (KitapAdi LIKE @arama OR Yazar LIKE @arama)";
                parameters.Add(new SqlParameter("@arama", "%" + aramaKelimesi + "%"));
            }
            if (!string.IsNullOrWhiteSpace(kategori))
            {
                query += " AND Kategori = @kategori";
                parameters.Add(new SqlParameter("@kategori", kategori));
            }

            try
            {
                DataTable dt = SqlHelper.GetData(query, parameters.ToArray());
                dgvKitapListesi.DataSource = dt;

                dgvKitapListesi.Columns["KitapId"].Visible = false;
                dgvKitapListesi.Columns["Ozet"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            KitaplariListele(txtHizliAra.Text, txtFiltreKategori.Text);
        }

        private void dgvKitapListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKitapListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKitapListesi.SelectedRows[0];

                // Design dosyanızdaki Label isimlerine göre güncellendi.
                lblOzet.Text = "Özet: " + row.Cells["Ozet"].Value.ToString();
                lblYazar.Text = "Yazar: " + row.Cells["Yazar"].Value.ToString();

                int stokAdedi = Convert.ToInt32(row.Cells["Stok"].Value);
                lblStok.Text = "Stok: " + stokAdedi.ToString();

                btnOduncTalep.Enabled = (stokAdedi > 0);
                // Opsiyonel: Stok Yokken butonu görsel olarak da ayarla
                btnOduncTalep.Text = (stokAdedi > 0) ? "Ödünç Talep Et" : "Stok Yok";
            }
        }

        // ------------------------- ÖDÜNÇ TALEBİ GÖNDERME -------------------------
        private void btnOduncTalep_Click(object sender, EventArgs e)
        {
            if (dgvKitapListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen ödünç almak istediğiniz kitabı seçin.", "Uyarı");
                return;
            }

            DataGridViewRow row = dgvKitapListesi.SelectedRows[0];
            int kitapId = Convert.ToInt32(row.Cells["KitapId"].Value);
            int stokAdedi = Convert.ToInt32(row.Cells["Stok"].Value);
            string kitapAdi = row.Cells["KitapAdi"].Value.ToString();

            // 1. Stok Kontrolü
            if (stokAdedi <= 0)
            {
                MessageBox.Show("Bu kitap şu anda ödünç verilemez. Stokta bulunmamaktadır.", "Stok Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // OPTIMAL: Aynı kitabın Beklemede veya Teslim Edildi durumunda olup olmadığını kontrol et (İleri seviye kural)

            try
            {
                // 2. Ödünç Talebi Oluşturma (Durum: Beklemede)
                string query = "INSERT INTO OduncIslemleri (KullaniciId, KitapId, TalepTarihi, Durum) VALUES (@kid, @bid, GETDATE(), 'Beklemede')";

                SqlParameter[] p = {
                    new SqlParameter("@kid", _kullaniciId),
                    new SqlParameter("@bid", kitapId)
                };

                SqlHelper.ExecuteQuery(query, p);

                MessageBox.Show(kitapAdi + " için ödünç talebiniz başarıyla oluşturuldu. Personel onayını bekleyiniz.", "Başarılı Talep");

                // Listeleri güncelle
                KitaplariListele(txtHizliAra.Text, txtFiltreKategori.Text);
                OduncDurumuTakip(); // Talep oluşturulduktan sonra takip listesini de yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Talep gönderilirken hata oluştu: " + ex.Message);
            }
        }

        // ------------------------- ÖDÜNÇ DURUMU VE GEÇMİŞ TAKİBİ -------------------------
        // Öğrencinin kendi geçmiş ödünç alma listesini ve talep durumunu görebilme
        private void OduncDurumuTakip()
        {
            string query = @"
                SELECT 
                    O.OduncId, T.KitapAdi AS Kitap, O.TalepTarihi, 
                    O.Durum, O.TeslimTarihi, O.IadeTarihi
                FROM OduncIslemleri O
                INNER JOIN Kitaplar T ON O.KitapId = T.KitapId
                WHERE O.KullaniciId = @kid
                ORDER BY O.TalepTarihi DESC";

            SqlParameter[] p = { new SqlParameter("@kid", _kullaniciId) };

            try
            {
                DataTable dt = SqlHelper.GetData(query, p);
                // Kontrol adını dgvOduncTakip olarak varsayıyoruz
                dgvOduncTakip.DataSource = dt;

                dgvOduncTakip.Columns["OduncId"].Visible = false;
                dgvOduncTakip.Columns["Durum"].HeaderText = "Talep Durumu";
                dgvOduncTakip.Columns["TeslimTarihi"].HeaderText = "Teslim Edilme Tarihi";
                dgvOduncTakip.Columns["IadeTarihi"].HeaderText = "İade Tarihi";
            }
            catch (Exception ex)
            {
                // Eğer dgvOduncTakip kontrolü yoksa, bu catch bloğu çalışabilir.
                // Kontrol adını doğru ayarladığınızdan emin olun.
                MessageBox.Show("Ödünç takibi yapılırken hata oluştu: " + ex.Message);
            }
        }

        // TabControl kullanıyorsanız ve sekmeler arasında geçiş yapıldığında listeyi yenilemek isterseniz:
        // Bu metodu formunuzdaki tabControl1'in SelectedIndexChanged olayına bağlamanız gerekir.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eğer ikinci sekmeye (Odunc Takip) geçilmişse, listeyi güncelle
            if (tabControl1.SelectedTab.Name == "tpOduncTakip")
            {
                OduncDurumuTakip();
            }
        }

        private void lblStok_Click(object sender, EventArgs e)
        {

        }

        private void txtHizliAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFiltreKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}