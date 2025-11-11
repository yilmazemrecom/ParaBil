namespace ParaBil.UC_Sayfalar
{
    partial class UC_Profil
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Profil));
            this.txtBakiye = new Krypton.Toolkit.KryptonTextBox();
            this.txtHesapAdi = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapEkle = new Krypton.Toolkit.KryptonButton();
            this.btnKategoriEkle = new Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKategoriTuru = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategoriTuru)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBakiye
            // 
            this.txtBakiye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBakiye.Location = new System.Drawing.Point(172, 219);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(261, 35);
            this.txtBakiye.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBakiye.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.txtBakiye.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.txtBakiye.StateCommon.Border.ColorAngle = 45F;
            this.txtBakiye.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBakiye.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBakiye.StateCommon.Border.Rounding = 18;
            this.txtBakiye.StateCommon.Border.Width = 1;
            this.txtBakiye.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBakiye.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakiye.TabIndex = 17;
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHesapAdi.Location = new System.Drawing.Point(169, 153);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(261, 35);
            this.txtHesapAdi.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtHesapAdi.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.txtHesapAdi.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.txtHesapAdi.StateCommon.Border.ColorAngle = 45F;
            this.txtHesapAdi.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHesapAdi.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtHesapAdi.StateCommon.Border.Rounding = 18;
            this.txtHesapAdi.StateCommon.Border.Width = 1;
            this.txtHesapAdi.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtHesapAdi.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapAdi.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(193, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Yeni Hesap Ekle";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKategoriAdi.Location = new System.Drawing.Point(169, 434);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(261, 35);
            this.txtKategoriAdi.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtKategoriAdi.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.txtKategoriAdi.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.txtKategoriAdi.StateCommon.Border.ColorAngle = 45F;
            this.txtKategoriAdi.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtKategoriAdi.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtKategoriAdi.StateCommon.Border.Rounding = 18;
            this.txtKategoriAdi.StateCommon.Border.Width = 1;
            this.txtKategoriAdi.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtKategoriAdi.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAdi.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(193, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yeni Kategori Ekle";
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHesapEkle.AutoSize = true;
            this.btnHesapEkle.Location = new System.Drawing.Point(225, 260);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnHesapEkle.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnHesapEkle.OverrideDefault.Back.ColorAngle = 45F;
            this.btnHesapEkle.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnHesapEkle.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnHesapEkle.OverrideDefault.Border.ColorAngle = 45F;
            this.btnHesapEkle.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHesapEkle.OverrideDefault.Border.Rounding = 18;
            this.btnHesapEkle.OverrideDefault.Border.Width = 1;
            this.btnHesapEkle.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnHesapEkle.Size = new System.Drawing.Size(129, 36);
            this.btnHesapEkle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnHesapEkle.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnHesapEkle.StateCommon.Back.ColorAngle = 45F;
            this.btnHesapEkle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnHesapEkle.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnHesapEkle.StateCommon.Border.ColorAngle = 45F;
            this.btnHesapEkle.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHesapEkle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHesapEkle.StateCommon.Border.Rounding = 18;
            this.btnHesapEkle.StateCommon.Border.Width = 1;
            this.btnHesapEkle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHesapEkle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHesapEkle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapEkle.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnHesapEkle.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnHesapEkle.StateTracking.Back.ColorAngle = 45F;
            this.btnHesapEkle.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnHesapEkle.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnHesapEkle.StateTracking.Border.ColorAngle = 45F;
            this.btnHesapEkle.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHesapEkle.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnHesapEkle.StateTracking.Border.Rounding = 18;
            this.btnHesapEkle.StateTracking.Border.Width = 1;
            this.btnHesapEkle.TabIndex = 25;
            this.btnHesapEkle.Values.Text = "Hesap Ekle";
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKategoriEkle.AutoSize = true;
            this.btnKategoriEkle.Location = new System.Drawing.Point(225, 538);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnKategoriEkle.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnKategoriEkle.OverrideDefault.Back.ColorAngle = 45F;
            this.btnKategoriEkle.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnKategoriEkle.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnKategoriEkle.OverrideDefault.Border.ColorAngle = 45F;
            this.btnKategoriEkle.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKategoriEkle.OverrideDefault.Border.Rounding = 18;
            this.btnKategoriEkle.OverrideDefault.Border.Width = 1;
            this.btnKategoriEkle.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnKategoriEkle.Size = new System.Drawing.Size(129, 36);
            this.btnKategoriEkle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnKategoriEkle.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnKategoriEkle.StateCommon.Back.ColorAngle = 45F;
            this.btnKategoriEkle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnKategoriEkle.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnKategoriEkle.StateCommon.Border.ColorAngle = 45F;
            this.btnKategoriEkle.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKategoriEkle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnKategoriEkle.StateCommon.Border.Rounding = 18;
            this.btnKategoriEkle.StateCommon.Border.Width = 1;
            this.btnKategoriEkle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnKategoriEkle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnKategoriEkle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnKategoriEkle.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnKategoriEkle.StateTracking.Back.ColorAngle = 45F;
            this.btnKategoriEkle.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnKategoriEkle.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnKategoriEkle.StateTracking.Border.ColorAngle = 45F;
            this.btnKategoriEkle.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKategoriEkle.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnKategoriEkle.StateTracking.Border.Rounding = 18;
            this.btnKategoriEkle.StateTracking.Border.Width = 1;
            this.btnKategoriEkle.TabIndex = 26;
            this.btnKategoriEkle.Values.Text = "Kategori Ekle";
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hesap Adı";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(172, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mevcut Bakiye";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(169, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kategori Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(617, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 687);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(172, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Kategori Türü";
            // 
            // cmbKategoriTuru
            // 
            this.cmbKategoriTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKategoriTuru.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.cmbKategoriTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriTuru.DropDownWidth = 120;
            this.cmbKategoriTuru.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbKategoriTuru.Location = new System.Drawing.Point(172, 499);
            this.cmbKategoriTuru.MaxDropDownItems = 10;
            this.cmbKategoriTuru.Name = "cmbKategoriTuru";
            this.cmbKategoriTuru.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbKategoriTuru.Size = new System.Drawing.Size(261, 33);
            this.cmbKategoriTuru.StateActive.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbKategoriTuru.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbKategoriTuru.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbKategoriTuru.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbKategoriTuru.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cmbKategoriTuru.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbKategoriTuru.StateCommon.ComboBox.Border.Rounding = 18;
            this.cmbKategoriTuru.StateCommon.ComboBox.Border.Width = 1;
            this.cmbKategoriTuru.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbKategoriTuru.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriTuru.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cmbKategoriTuru.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cmbKategoriTuru.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cmbKategoriTuru.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cmbKategoriTuru.StateCommon.Item.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbKategoriTuru.StateCommon.Item.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbKategoriTuru.StateCommon.Item.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbKategoriTuru.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbKategoriTuru.StateCommon.Item.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cmbKategoriTuru.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.cmbKategoriTuru.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cmbKategoriTuru.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cmbKategoriTuru.StateCommon.Item.Content.ShortText.ColorAngle = 45F;
            this.cmbKategoriTuru.StateNormal.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbKategoriTuru.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Transparent;
            this.cmbKategoriTuru.StateNormal.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbKategoriTuru.TabIndex = 33;
            this.cmbKategoriTuru.UseMnemonic = false;
            // 
            // UC_Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbKategoriTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnHesapEkle);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtHesapAdi);
            this.Controls.Add(this.label1);
            this.Name = "UC_Profil";
            this.Size = new System.Drawing.Size(1120, 690);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategoriTuru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtBakiye;
        private Krypton.Toolkit.KryptonTextBox txtHesapAdi;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtKategoriAdi;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonButton btnHesapEkle;
        private Krypton.Toolkit.KryptonButton btnKategoriEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonComboBox cmbKategoriTuru;
    }
}
