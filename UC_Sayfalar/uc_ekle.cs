using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParaBil.UC_Sayfalar
{
    public partial class uc_ekle : UserControl
    {
        private readonly veritabani myDatabase;
        public uc_ekle()
        {
            InitializeComponent();

            
            // veritabani sınıfını oluştur
            myDatabase = new veritabani();
            myDatabase.veritabaniolustur();



            txtMiktar.KeyPress += new KeyPressEventHandler(TxtMiktar_KeyPress);
            cmbIslemTuru.SelectedIndexChanged += CmbIslemTuru_SelectedIndexChanged;

        }


        public void LoadComboBoxes()
        {
            // Hesapları ComboBox'a yükle
            cmbHesaplar.DataSource = myDatabase.LoadHesaplar();
            cmbHesaplar.DisplayMember = "HesapAdi";
            cmbHesaplar.ValueMember = "HesapID";
            
            cmbIslemTuru.Items.Clear();
            // İşlem türlerini ComboBox'a yükle
            cmbIslemTuru.Items.Add("Gelir");
            cmbIslemTuru.Items.Add("Gider");

            // cmbIslemTuru otomatik olarak "Gelir" seçili olsun
            // cmbIslemTuru.SelectedIndex = 0;



            // Kategorileri ComboBox'a yükle

            /*
            cmbKategori.DataSource = myDatabase.LoadKategoriler();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
            // kategori işlem türü gider olanları yükle
            cmbKategori.DataSource = myDatabase.LoadKategorilerByIslemTuru("Gider");
            */


        }

        private void BtnIslemEkle_Click(object sender, EventArgs e)
        {
            int hesapID = Convert.ToInt32(cmbHesaplar.SelectedValue);
            int kategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
            string islemTuru = cmbIslemTuru.Text;
            double miktar;
            DateTime tarih = dtTarih.Value;
            if (!double.TryParse(txtMiktar.Text, out miktar))
            {
                MessageBox.Show("Geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // veritabani sınıfını kullanarak işlem ekle
            myDatabase.IslemEkle(hesapID, kategoriID, islemTuru, miktar, tarih, txtAciklama.Text);

            MessageBox.Show("İşlem başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();


            // içerikleri temizle
            txtAciklama.Text = "";
            txtMiktar.Text = "";
            // comboboxları temizle
            cmbHesaplar.SelectedIndex = 0;
            cmbIslemTuru.SelectedIndex = 0;
            cmbKategori.SelectedIndex = 0;

        }

        
        // txtMiktar TextBox kontrolü için KeyPress olayı
        private void TxtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // txtMiktar'ı başlatmadan önce kontrol et
            if (txtMiktar != null)
            {
                // Sadece sayılar, kontrol tuşları ve ondalık ayırıcı (nokta) kabul edilsin
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                {
                    e.Handled = true;

                    // Hata mesajını kullanıcıya göster
                    MessageBox.Show("Lütfen sadece sayısal değerler giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Eğer nokta veya virgül kullanıcının birinci karakterse, engelle
                if ((e.KeyChar == '.' || e.KeyChar == ',') && txtMiktar.Text.IndexOf('.') > -1)
                {
                    e.Handled = true;

                    // Hata mesajını kullanıcıya göster
                    MessageBox.Show("Lütfen sadece bir ondalık ayırıcı kullanınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Temizle()
        {
            cmbHesaplar.SelectedIndex = 0; // veya cmbHesaplar.SelectedItem = null; veya cmbHesaplar.Text = "";
            cmbIslemTuru.SelectedIndex = 0; // veya cmbIslemTuru.SelectedItem = null; veya cmbIslemTuru.Text = "";
            cmbKategori.SelectedIndex = 0; // veya cmbKategori.SelectedItem = null; veya cmbKategori.Text = "";
            txtMiktar.Clear();
            txtAciklama.Clear();
        }

        private void CmbIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmbIslemTuru'nun SelectedIndexChanged olayı tetiklendiğinde çağrılır.
            // Bu olay, işlem türü seçildiğinde otomatik olarak çağrılacaktır.

            string islemTuru = cmbIslemTuru.Text;

            // Kategori türünü belirle ve ComboBox'ı güncelle
            if (islemTuru == "Gelir")
            {
                cmbKategori.DataSource = myDatabase.LoadKategorilerByIslemTuru("Gelir");
            }
            else if (islemTuru == "Gider")
            {
                cmbKategori.DataSource = myDatabase.LoadKategorilerByIslemTuru("Gider");
            }

            // ComboBox'ın görüntülenen ve değer özelliklerini belirle
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
        }



    }
}
