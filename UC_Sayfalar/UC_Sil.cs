using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ParaBil.UC_Sayfalar
{
    public partial class UC_Sil : UserControl
    {
        private readonly SQLiteConnection connection;

        public UC_Sil()
        {
            InitializeComponent();
            // Sınıf düzeyinde tanımlı connection nesnesini başlatın
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "ParaBil");
            Directory.CreateDirectory(appFolder);
            string dbPath = Path.Combine(appFolder, "Veritabani.db");

            connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");

            DatagridYenile();
        }

        public void DatagridYenile()
        {
            // connection nesnesini sınıf düzeyinde tanımladığımız için burada tekrar tanımlamıyoruz
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Islemler", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hesap Adı sütununu ekle
                dt.Columns.Add("HesapAdi", typeof(string));

                // Kategori Adı sütununu ekle
                dt.Columns.Add("KategoriAdi", typeof(string));

                // Veri bağlama işlemi
                SilData.DataSource = dt;

                // İstenmeyen sütünleri gizle
                SilData.Columns["IslemID"].Visible = false;
                SilData.Columns["HesapID"].Visible = false;
                SilData.Columns["KategoriID"].Visible = false;

                // Hesap Adı ve Kategori Adı sütunlarını düzenle
                SilData.Columns["HesapAdi"].DisplayIndex = 1;
                SilData.Columns["KategoriAdi"].DisplayIndex = 2;

                // adları düzenle
                SilData.Columns["HesapAdi"].HeaderText = "Hesap Adı";
                SilData.Columns["KategoriAdi"].HeaderText = "Kategori Adı";
                SilData.Columns["IslemTuru"].HeaderText = "İşlem Türü";
                SilData.Columns["Miktar"].HeaderText = "Miktar";
                SilData.Columns["Tarih"].HeaderText = "Tarih";
                SilData.Columns["Aciklama"].HeaderText = "Açıklama";



                for (int i = 0; i < SilData.Rows.Count; i++)
                {
                    int hesapId = Convert.ToInt32(SilData.Rows[i].Cells["HesapID"].Value);

                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT HesapAdi FROM Hesaplar WHERE HesapID = @id", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", hesapId);

                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Hesap Adı sütununu güncelle
                                SilData.Rows[i].Cells["HesapAdi"].Value = dr["HesapAdi"].ToString();
                            }
                        }
                    }
                }

                for (int i = 0; i < SilData.Rows.Count; i++)
                {
                    int kategoriId = Convert.ToInt32(SilData.Rows[i].Cells["KategoriID"].Value);

                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT KategoriAdi FROM Kategoriler WHERE KategoriID = @kid", connection))
                    {
                        cmd.Parameters.AddWithValue("@kid", kategoriId);

                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Kategori Adı sütununu güncelle
                                SilData.Rows[i].Cells["KategoriAdi"].Value = dr["KategoriAdi"].ToString();
                            }
                        }
                    }
                }
             // Bağlantı otomatik olarak kapatılacaktır
        }


        public void IslemDelete(object sender, EventArgs e)
        {
            IslemDelete();


        }

        public void IslemDelete()
        {
            if (SilData.SelectedRows.Count > 0)
            {
                int selectedRowIndex = SilData.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(SilData.Rows[selectedRowIndex].Cells["IslemID"].Value);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // İşlem bilgilerini al
                int hesap_id = Convert.ToInt32(SilData.Rows[selectedRowIndex].Cells["HesapID"].Value);
                int miktar = Convert.ToInt32(SilData.Rows[selectedRowIndex].Cells["Miktar"].Value);
                string islemTuru = SilData.Rows[selectedRowIndex].Cells["IslemTuru"].Value.ToString();

                // İşlemi sil
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Islemler WHERE IslemID = @IslemID", connection))
                {
                    cmd.Parameters.AddWithValue("@IslemID", id);
                    cmd.ExecuteNonQuery();
                }

                // Hesaptan miktarı ekleyecek veya çıkaracak
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = connection;

                    if (islemTuru == "Gelir")
                    {
                        // Eğer işlem gelir ise, bakiyeden çıkar
                        cmd.CommandText = "UPDATE Hesaplar SET Bakiye = Bakiye - @miktar WHERE HesapID = @id";
                        cmd.Parameters.AddWithValue("@miktar", miktar);
                    }
                    else if (islemTuru == "Gider")
                    {
                        // Eğer işlem gider ise, bakiyeye ekle
                        cmd.CommandText = "UPDATE Hesaplar SET Bakiye = Bakiye + @miktar WHERE HesapID = @id";
                        cmd.Parameters.AddWithValue("@miktar", miktar);
                    }

                    cmd.Parameters.AddWithValue("@id", hesap_id);
                    cmd.ExecuteNonQuery();
                }
            


            // Verileri güncelle
            RefreshDataGridView();
                DatagridYenile();
            }
        }



        private void RefreshDataGridView()
        {
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Islemler", connection))
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SilData.DataSource = dt;
            }
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                MenuItem deleteItem = new MenuItem("Sil");
                //deleteItem.Click += new EventHandler(islem_sil[Row]);
                // deleteitem.click += new eventhandler(islem_sil);
                // deleteitem tıklandığında islem_sil fonksiyonunu çalıştır
                deleteItem.Click += new EventHandler(IslemDelete);



                m.MenuItems.Add(deleteItem);

                int currentMouseOverRow = SilData.HitTest(e.X, e.Y).RowIndex;


                m.Show(SilData, new Point(e.X, e.Y));

            }
        }
    }
}
