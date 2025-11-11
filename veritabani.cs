using iText.Commons.Bouncycastle.Cert.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;

namespace ParaBil
{
    internal class veritabani
    {
        public SQLiteConnection connection;



        public void veritabaniolustur()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appFolder = Path.Combine(appDataPath, "ParaBil");
            Directory.CreateDirectory(appFolder);
            string dbPath = Path.Combine(appFolder, "Veritabani.db");

            connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            connection.Open();

            CreateTable("CREATE TABLE IF NOT EXISTS Hesaplar (" +
                        "HesapID INTEGER PRIMARY KEY," +
                        "HesapAdi TEXT NOT NULL," +
                        "Bakiye REAL NOT NULL);");

            CreateTable("CREATE TABLE IF NOT EXISTS Kategoriler (" +
                        "KategoriID INTEGER PRIMARY KEY," +
                        "KategoriAdi TEXT NOT NULL," +
                        "KategoriTuru TEXT NOT NULL);");

            CreateTable("CREATE TABLE IF NOT EXISTS Islemler (" +
                        "IslemID INTEGER PRIMARY KEY," +
                        "HesapID INTEGER," +
                        "KategoriID INTEGER," +
                        "IslemTuru TEXT NOT NULL," +
                        "Miktar REAL NOT NULL," +
                        "Tarih DATE NOT NULL," +
                        "Aciklama TEXT," +
                        "FOREIGN KEY (HesapID) REFERENCES Hesaplar(HesapID)," +
                        "FOREIGN KEY (KategoriID) REFERENCES Kategoriler(KategoriID));");
            
            CreateTable("CREATE TABLE IF NOT EXISTS Notlar (" +
                "NotID INTEGER PRIMARY KEY," +
                "Baslik TEXT NOT NULL," +
                "Icerik TEXT NOT NULL," +
                "Tarih DATE NOT NULL);");


            // Kategorileri ekleyen SQL sorguları
            string[] kategoriSorgulari = {
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Maaş', 'Gelir' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Maaş');",
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Diğer Gelirler', 'Gelir' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Diğer Gelirler');",
             "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Kredi Kartı Ödemeleri', 'Gelir' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Kredi Kartı Ödemeleri');",

            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Kira', 'Gider' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Kira');",
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Elektrik ve Su Faturası', 'Gider' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Elektrik ve Su Faturası');",
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Yiyecek ve İçecek', 'Gider' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Yiyecek ve İçecek');",
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Ulaşım', 'Gider' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Ulaşım');",
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Giyim ve Ayakkabı', 'Gider' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Giyim ve Ayakkabı');",
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Eğlence', 'Gider' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Eğlence');",
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Sağlık ve İlaçlar', 'Gider' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Sağlık ve İlaçlar');",
            "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) SELECT 'Diğer Giderler', 'Gider' WHERE NOT EXISTS (SELECT 1 FROM Kategoriler WHERE KategoriAdi = 'Diğer Giderler');"
        };

            // Kategorileri ekleyen sorguları döngü ile çalıştırma
            foreach (var sorgu in kategoriSorgulari)
            {
                CreateTable(sorgu);
            }

            // Hesapları ekleyen SQL sorguları
            string[] hesapSorgulari =
            {
            "INSERT INTO Hesaplar (HesapAdi, Bakiye) SELECT 'Nakit', 0.0 WHERE NOT EXISTS (SELECT 1 FROM Hesaplar WHERE HesapAdi = 'Nakit');",

        };

            // Hesapları ekleyen sorguları döngü ile çalıştırma
            foreach (var sorgu in hesapSorgulari)
            {
                CreateTable(sorgu);
            }
        }

        private void CreateTable(string createTableQuery)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void HesapEkle(string hesapAdi, double bakiye)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO Hesaplar (HesapAdi, Bakiye) VALUES (@HesapAdi, @Bakiye);", connection))
            {
                command.Parameters.AddWithValue("@HesapAdi", hesapAdi);
                command.Parameters.AddWithValue("@Bakiye", bakiye);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void KategoriEkle(string kategoriAdi, string kategoriTuru)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO Kategoriler (KategoriAdi, KategoriTuru) VALUES (@KategoriAdi, @KategoriTuru);", connection))
            {
                command.Parameters.AddWithValue("@KategoriAdi", kategoriAdi);
                command.Parameters.AddWithValue("@KategoriTuru", kategoriTuru);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void IslemEkle(int hesapID, int kategoriID, string islemTuru, double miktar, DateTime tarih, string aciklama)
        {
            // İlgili hesabın bakiyesini al
            double hesapBakiye = GetHesapBakiye(hesapID);

            // Gelir veya gider işlemine bağlı olarak bakiyeyi güncelle
            if (islemTuru == "Gelir")
            {
                hesapBakiye += miktar;
            }
            else if (islemTuru == "Gider")
            {
                hesapBakiye -= miktar;
            }

            // Hesap bakiyesini güncelle
            UpdateHesapBakiye(hesapID, hesapBakiye);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            // İşlemi ekle
            using (SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO Islemler (HesapID, KategoriID, IslemTuru, Miktar, Tarih, Aciklama) " +
                "VALUES (@HesapID, @KategoriID, @IslemTuru, @Miktar, @Tarih, @Aciklama);", connection))
            {
                command.Parameters.AddWithValue("@HesapID", hesapID);
                command.Parameters.AddWithValue("@KategoriID", kategoriID);
                command.Parameters.AddWithValue("@IslemTuru", islemTuru);
                command.Parameters.AddWithValue("@Miktar", miktar);
                command.Parameters.AddWithValue("@Tarih", tarih);
                command.Parameters.AddWithValue("@Aciklama", aciklama);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public double GetHesapBakiye(int hesapID)
        {
            // İlgili hesabın bakiyesini al
            double bakiye = 0.0;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT Bakiye FROM Hesaplar WHERE HesapID = @HesapID;", connection))
            {
                command.Parameters.AddWithValue("@HesapID", hesapID);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bakiye = Convert.ToDouble(reader["Bakiye"]);
                    }
                }
            }
            connection.Close();
            return bakiye;
        }

        public void UpdateHesapBakiye(int hesapID, double yeniBakiye)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            // Hesap bakiyesini güncelle
            using (SQLiteCommand command = new SQLiteCommand(
                "UPDATE Hesaplar SET Bakiye = @YeniBakiye WHERE HesapID = @HesapID;", connection))
            {
                command.Parameters.AddWithValue("@HesapID", hesapID);
                command.Parameters.AddWithValue("@YeniBakiye", yeniBakiye);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public List<Hesap> LoadHesaplar()
        {
            List<Hesap> hesaplar = new List<Hesap>();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT HesapID, HesapAdi FROM Hesaplar", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Hesap hesap = new Hesap
                        {
                            HesapID = Convert.ToInt32(reader["HesapID"]),
                            HesapAdi = reader["HesapAdi"].ToString()
                        };

                        hesaplar.Add(hesap);
                    }
                }
            }
            connection.Close();
            return hesaplar;
        }

        public List<Kategori> LoadKategoriler()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT KategoriID, KategoriAdi FROM Kategoriler", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kategori kategori = new Kategori
                        {
                            KategoriID = Convert.ToInt32(reader["KategoriID"]),
                            KategoriAdi = reader["KategoriAdi"].ToString()
                        };

                        kategoriler.Add(kategori);
                    }
                }
            }
            connection.Close();
            return kategoriler;
        }



        // tüm hesapların toplamını al
        public double GetToplamBakiye()
        {


            double toplamBakiye = 0;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT Bakiye FROM Hesaplar", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        toplamBakiye += Convert.ToDouble(reader["Bakiye"]);
                    }
                }
            }
            connection.Close();
            return toplamBakiye;
        }


        // bu ayki toplam geliri al
        public double GetBuAykiToplamGelir()
        {
            double toplamGelir = 0;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT Miktar FROM Islemler WHERE IslemTuru = 'Gelir' AND strftime('%m', Tarih) = strftime('%m', 'now')", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        toplamGelir += Convert.ToDouble(reader["Miktar"]);
                    }
                }
            }
            connection.Close();
            return toplamGelir;
        }

        // bu ayki toplam gideri al
        public double GetBuAykiToplamGider()
        {
            double toplamGider = 0;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT Miktar FROM Islemler WHERE IslemTuru = 'Gider' AND strftime('%m', Tarih) = strftime('%m', 'now')", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        toplamGider += Convert.ToDouble(reader["Miktar"]);
                    }
                }
            }
            connection.Close();
            return toplamGider;
        }


        public List<GelirBilgisi> GetSonBesGelir()
        {
            List<GelirBilgisi> sonBesGelir = new List<GelirBilgisi>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT Hesaplar.HesapAdi, Kategoriler.KategoriAdi, Islemler.Miktar, Islemler.Tarih " +
                "FROM Islemler " +
                "JOIN Kategoriler ON Islemler.KategoriID = Kategoriler.KategoriID " +
                "JOIN Hesaplar ON Islemler.HesapID = Hesaplar.HesapID " +
                "WHERE Islemler.IslemTuru = 'Gelir' " +
                "ORDER BY Islemler.Tarih DESC " +
                "LIMIT 10", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GelirBilgisi gelir = new GelirBilgisi
                        {
                            HesapAdi = reader["HesapAdi"].ToString(),
                            KategoriAdi = reader["KategoriAdi"].ToString(),
                            Miktar = Convert.ToDouble(reader["Miktar"]),
                            Tarih = Convert.ToDateTime(reader["Tarih"])
                        };

                        sonBesGelir.Add(gelir);
                    }
                }
            }

            // Bağlantıyı kapat
            connection.Close();

            return sonBesGelir;
        }


        public List<GelirBilgisi> GetSonBesGider()
        {
            List<GelirBilgisi> sonBesGider = new List<GelirBilgisi>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT Hesaplar.HesapAdi, Kategoriler.KategoriAdi, Islemler.Miktar, Islemler.Tarih " +
                "FROM Islemler " +
                "INNER JOIN Hesaplar ON Islemler.HesapID = Hesaplar.HesapID " +
                "INNER JOIN Kategoriler ON Islemler.KategoriID = Kategoriler.KategoriID " +
                "WHERE Islemler.IslemTuru = 'Gider' " +
                "ORDER BY Islemler.Tarih DESC " +
                "LIMIT 10;", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GelirBilgisi gider = new GelirBilgisi
                        {
                            HesapAdi = reader["HesapAdi"].ToString(),
                            KategoriAdi = reader["KategoriAdi"].ToString(),
                            Miktar = Convert.ToDouble(reader["Miktar"]),
                            Tarih = Convert.ToDateTime(reader["Tarih"])
                        };

                        sonBesGider.Add(gider);
                    }
                }
            }
            // Bağlantıyı kapat
            connection.Close();
            return sonBesGider;
        }


        // hesapların adını ve bakıyesini al
        public List<Hesap> GetHesapBilgileri()
        {
            List<Hesap> hesaplar = new List<Hesap>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT HesapID, HesapAdi, Bakiye FROM Hesaplar", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Hesap hesap = new Hesap
                        {

                            HesapAdi = reader["HesapAdi"].ToString(),
                            Bakiye = Convert.ToDouble(reader["Bakiye"])
                        };

                        hesaplar.Add(hesap);
                    }
                }
            }

            return hesaplar;
        }


        // ayların gelirlerini al

        public List<gelirchart> GetAylikGelirler()
        {
            List<gelirchart> aylikGelirler = new List<gelirchart>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT strftime('%m', Tarih) AS Ay, SUM(Miktar) AS Miktar " +
                "FROM Islemler " +
                "WHERE IslemTuru = 'Gelir' " +
                "GROUP BY strftime('%m', Tarih) " +
                "ORDER BY strftime('%m', Tarih) ASC;", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        gelirchart gelir = new gelirchart
                        {
                            Ay = reader["Ay"].ToString(),
                            Miktar = Convert.ToDouble(reader["Miktar"]),
                            Tarih = DateTime.MinValue // Tarih bilgisini buradan alabilirsiniz, ancak veritabanınızda bu bilgi yoksa DateTime.MinValue gibi bir değer atayabilirsiniz.
                        };

                        aylikGelirler.Add(gelir);
                    }
                }
            }

            // Bağlantıyı kapat
            connection.Close();

            return aylikGelirler;
        }

        public List<giderchart> GetAylikGiderler()
        {
            List<giderchart> aylikGiderler = new List<giderchart>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT strftime('%m', Tarih) AS Ay, SUM(Miktar) AS Miktar " +
                "FROM Islemler " +
                "WHERE IslemTuru = 'Gider' " +
                "GROUP BY strftime('%m', Tarih) " +
                "ORDER BY strftime('%m', Tarih) ASC;", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        giderchart gider = new giderchart
                        {
                            // miktar ve tarihi al
                            Miktar = Convert.ToDouble(reader["Miktar"])
                        };

                        aylikGiderler.Add(gider);
                    }
                }
            }

            // Bağlantıyı kapat
            connection.Close();

            return aylikGiderler;
        }


        public List<IslemRaporu> GetIslemRaporu(string islemTuru)
        {
            List<IslemRaporu> islemRaporu = new List<IslemRaporu>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string sql = "SELECT Hesaplar.HesapAdi, Kategoriler.KategoriAdi, Islemler.Miktar, Islemler.Tarih, Islemler.IslemTuru " +
                         "FROM Islemler " +
                         "JOIN Kategoriler ON Islemler.KategoriID = Kategoriler.KategoriID " +
                         "JOIN Hesaplar ON Islemler.HesapID = Hesaplar.HesapID " +
                         $"WHERE Islemler.IslemTuru = '{islemTuru}' " +
                         "ORDER BY Islemler.Tarih DESC;";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IslemRaporu islem = new IslemRaporu
                        {
                            HesapAdi = reader["HesapAdi"].ToString(),
                            KategoriAdi = reader["KategoriAdi"].ToString(),
                            Miktar = Convert.ToDouble(reader["Miktar"]),
                            Tarih = Convert.ToDateTime(reader["Tarih"]),
                            IslemTuru = reader["IslemTuru"].ToString()
                        };

                        islemRaporu.Add(islem);
                    }
                }
            }

            connection.Close();

            return islemRaporu;
        }

        public List<ToplamHarcama> GetToplamHarcamalar()
        {
            List<ToplamHarcama> toplamHarcamalar = new List<ToplamHarcama>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (SQLiteCommand command = new SQLiteCommand(
                "SELECT Kategoriler.KategoriAdi, SUM(Islemler.Miktar) AS Miktar " +
                "FROM Islemler " +
                "JOIN Kategoriler ON Islemler.KategoriID = Kategoriler.KategoriID " +
                "GROUP BY Islemler.KategoriID", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ToplamHarcama toplamHarcama = new ToplamHarcama
                        {
                            KategoriAdi = reader["KategoriAdi"].ToString(),
                            Miktar = Convert.ToDouble(reader["Miktar"])
                        };

                        toplamHarcamalar.Add(toplamHarcama);
                    }
                }
            }

            // Bağlantıyı kapat
            connection.Close();

            return toplamHarcamalar;
        }


        // aylık işlemleri al (gelir ve gider)
        public List<IslemRaporu> GetAylikIslemlerGelir()
        {
            List<IslemRaporu> aylikIslemler = new List<IslemRaporu>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string sql = "SELECT Hesaplar.HesapAdi, Kategoriler.KategoriAdi, Islemler.Miktar, Islemler.Tarih, Islemler.IslemTuru " +
                         "FROM Islemler " +
                         "JOIN Kategoriler ON Islemler.KategoriID = Kategoriler.KategoriID " +
                         "JOIN Hesaplar ON Islemler.HesapID = Hesaplar.HesapID " +
                         $"WHERE Islemler.IslemTuru = Gelir " +
                         "ORDER BY Islemler.Tarih DESC;";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IslemRaporu islem = new IslemRaporu
                        {
                            HesapAdi = reader["HesapAdi"].ToString(),
                            KategoriAdi = reader["KategoriAdi"].ToString(),
                            Miktar = Convert.ToDouble(reader["Miktar"]),
                            Tarih = Convert.ToDateTime(reader["Tarih"]),
                            IslemTuru = reader["IslemTuru"].ToString()
                        };

                        aylikIslemler.Add(islem);
                    }
                }
            }

            connection.Close();

            return aylikIslemler;
        }



        public List<IslemRaporu> GetAylikIslemlerGider()
        {
            List<IslemRaporu> aylikIslemler = new List<IslemRaporu>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string sql = "SELECT Hesaplar.HesapAdi, Kategoriler.KategoriAdi, Islemler.Miktar, Islemler.Tarih, Islemler.IslemTuru " +
                         "FROM Islemler " +
                         "JOIN Kategoriler ON Islemler.KategoriID = Kategoriler.KategoriID " +
                         "JOIN Hesaplar ON Islemler.HesapID = Hesaplar.HesapID " +
                         $"WHERE Islemler.IslemTuru = Gider " +
                         "ORDER BY Islemler.Tarih DESC;";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IslemRaporu islem = new IslemRaporu
                        {
                            HesapAdi = reader["HesapAdi"].ToString(),
                            KategoriAdi = reader["KategoriAdi"].ToString(),
                            Miktar = Convert.ToDouble(reader["Miktar"]),
                            Tarih = Convert.ToDateTime(reader["Tarih"]),
                            IslemTuru = reader["IslemTuru"].ToString()
                        };

                        aylikIslemler.Add(islem);
                    }
                }
            }

            connection.Close();

            return aylikIslemler;
        }



        // hesaplar ve işlemler tablolarını sıfırla
        public void tumTablolariSil()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Hesaplar", connection))
            {
                command.ExecuteNonQuery();
            }

            using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Islemler", connection))
            {
                command.ExecuteNonQuery();
            }

            using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Kategoriler", connection))
            {
                command.ExecuteNonQuery();
            }
            connection.Close();
        }




        // kategori işlem türü
        public List<Kategori> LoadKategorilerByIslemTuru(string islemTuru)
        {
            List<Kategori> kategoriler = new List<Kategori>();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT KategoriID, KategoriAdi FROM Kategoriler WHERE KategoriTuru = @KategoriTuru", connection))
            {
                command.Parameters.AddWithValue("@KategoriTuru", islemTuru);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kategori kategori = new Kategori
                        {
                            KategoriID = Convert.ToInt32(reader["KategoriID"]),
                            KategoriAdi = reader["KategoriAdi"].ToString()
                        };

                        kategoriler.Add(kategori);
                    }
                }
            }
            connection.Close();
            return kategoriler;
        }


        public void NotEkle(string baslik, string icerik)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO Notlar (Baslik, Icerik, Tarih) VALUES (@Baslik, @Icerik, @Tarih);", connection))
            {
                command.Parameters.AddWithValue("@Baslik", baslik);
                command.Parameters.AddWithValue("@Icerik", icerik);
                command.Parameters.AddWithValue("@Tarih", DateTime.Now);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public List<Not> TumNotlariGetir()
        {
            List<Not> notlar = new List<Not>();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Notlar", connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Not not = new Not
                        {
                            NotID = Convert.ToInt32(reader["NotID"]),
                            Baslik = reader["Baslik"].ToString(),
                            Icerik = reader["Icerik"].ToString(),
                            Tarih = Convert.ToDateTime(reader["Tarih"])
                        };

                        notlar.Add(not);
                    }
                }
            }

            connection.Close();
            return notlar;
            
        }

        public void NotSil(int notID)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (SQLiteCommand command = new SQLiteCommand("DELETE FROM Notlar WHERE NotID = @NotID;", connection))
            {
                command.Parameters.AddWithValue("@NotID", notID);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

       


    }





    public class Hesap
    {
        public int HesapID { get; set; }
        public string HesapAdi { get; set; }

        public double Bakiye { get; set; }
    }

    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
    }


    public class GelirBilgisi
    {
        public string HesapAdi { get; set; }
        public string KategoriAdi { get; set; }
        public double Miktar { get; set; }
        public DateTime Tarih { get; set; }


    }

    public class gelirchart
    {
        public string Ay { get; set; } // Ayı sayı olarak alıyorsunuz, dilerseniz int türünde de tutabilirsiniz.
        public double Miktar { get; set; }
        public DateTime Tarih { get; set; } // Eğer tarihi kullanmak istiyorsanız, bu özelliği ekleyebilirsiniz.
    }

    public class giderchart
    {
        public string Ay { get; set; } // Ayı sayı olarak alıyorsunuz, dilerseniz int türünde de tutabilirsiniz.
        public double Miktar { get; set; }
        public DateTime Tarih { get; set; } // Eğer tarihi kullanmak istiyorsanız, bu özelliği ekleyebilirsiniz.
    }


    public class IslemRaporu
    {
        public string HesapAdi { get; set; }
        public string KategoriAdi { get; set; }
        public double Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public string IslemTuru { get; set; }
    }
    public class HarcamaKategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public object ToplamHarcama { get; internal set; }
    }

    public class ToplamHarcama
    {
        public string KategoriAdi { get; set; }
        public double Miktar { get; set; }

        // Diğer özellikler ve metotlar...
    }


    public class Not
    {
        public int NotID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
    }

}








