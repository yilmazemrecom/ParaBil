using ParaBil.UC_Sayfalar;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ParaBil
{
    public partial class ParaBil : Form
    {

        UC_ozet uc_ozet = new UC_ozet();
        uc_ekle uc_ekle = new uc_ekle();
        UC_Durum uc_durum = new UC_Durum();
        UC_Profil uc_profil = new UC_Profil();
        UC_Sil uc_sil = new UC_Sil();
        UC_Ayarlar uc_ayarlar = new UC_Ayarlar();
        UC_Notcs UC_Notcs = new UC_Notcs();

        private bool isMaximized = false;
        private System.Drawing.Size normalSize;


        private veritabani myDatabase;

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;




        public ParaBil()
        {
            InitializeComponent();
            CheckWindowsScale();
            // veritabani sınıfını oluştur
            myDatabase = new veritabani();
            myDatabase.veritabaniolustur();


            // PanelHeader'dan sürükleme işlemi 
            header.MouseDown += PanelHeader_MouseDown;
            header.MouseMove += PanelHeader_MouseMove;
            header.MouseUp += PanelHeader_MouseUp;


            icerik.Controls.Add(uc_ozet);
            uc_ozet.Dock = DockStyle.Fill;

            normalSize = this.Size;
            zaman();

            


        }

        // timer oluştur bu timer için salisede bir güncellenerek zamanı label3'e yazdır
        private void zaman()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        // timer için event oluştur
        void timer_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        // PanelHeader'dan sürükleme işlemi 
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;

                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                // Formun maksimum boyutunu ayarla
                this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else
            {
                // Formu eski boyutuna getir
                this.WindowState = FormWindowState.Normal;
                this.Size = normalSize;
                isMaximized = false;
            }
        }

        private void icerik_Paint(object sender, PaintEventArgs e)
        {
            this.Size = new Size(icerik.Width, icerik.Height);
        }

        private void menu_ekle_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            icerik.Controls.Add(uc_ekle);
            uc_ekle.Dock = DockStyle.Fill;

            uc_ekle.LoadComboBoxes();





        }

        private void menu_ozet_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            icerik.Controls.Add(uc_ozet);
            uc_ozet.Dock = DockStyle.Fill;

            uc_ozet.ozetyazdir();

        }

        private void menu_durum_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            icerik.Controls.Add(uc_durum);
            uc_durum.Dock = DockStyle.Fill;

            uc_durum.gelirchartdurum.Series.Clear();
            uc_durum.giderchartdurum.Series.Clear();
            uc_durum.ozetyazdir();
            uc_durum.ozetgider();
            uc_durum.HarcamalariGoster();
;
        }

        private void menu_profil_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            icerik.Controls.Add(uc_profil);
            uc_profil.Dock = DockStyle.Fill;
        }

        private void menu_sil_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            icerik.Controls.Add(uc_sil);
            uc_sil.Dock = DockStyle.Fill;

            uc_sil.DatagridYenile();
        }

        // ayarlar butonu
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            icerik.Controls.Add(uc_ayarlar);
            uc_ayarlar.Dock = DockStyle.Fill;

        }

        private void emre_Click(object sender, EventArgs e)
        {
            // tıklandığında web sitesine git
            System.Diagnostics.Process.Start("https://yilmazemre.com");

        }

        private void CheckWindowsScale()
        {
            // Windows ölçekleme oranını kontrol et
            float scale = GetWindowsScaleFactor();

            // Eğer ölçek %125 ise uyarı ver
            if (Math.Abs(scale - 1.25f) < 0.01f)
            {
                DialogResult result = MessageBox.Show("Windows ölçeklendirme oranınız %125 olarak ayarlıdır. Düzgün Görüntülenemeyebilir! Önerilen ölçeklendirme %100.\n", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                
            }
        }

        private float GetWindowsScaleFactor()
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                return graphics.DpiX / 96.0f; // Ölçekleme faktörünü hesapla
            }
        }

        private void ParaBil_Load(object sender, EventArgs e)
        {
            
        }

        private void menu_not_Click(object sender, EventArgs e)
        {
            icerik.Controls.Clear();
            icerik.Controls.Add(UC_Notcs);
            UC_Notcs.Dock = DockStyle.Fill;
        }
    }


}

