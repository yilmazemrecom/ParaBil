namespace ParaBil.UC_Sayfalar
{
    partial class uc_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ekle));
            this.txtAciklama = new Krypton.Toolkit.KryptonTextBox();
            this.dtTarih = new Krypton.Toolkit.KryptonDateTimePicker();
            this.txtMiktar = new Krypton.Toolkit.KryptonTextBox();
            this.cmbHesaplar = new Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIslemEkle = new Krypton.Toolkit.KryptonButton();
            this.cmbIslemTuru = new Krypton.Toolkit.KryptonComboBox();
            this.cmbKategori = new Krypton.Toolkit.KryptonComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHesaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIslemTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAciklama.Location = new System.Drawing.Point(193, 521);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(261, 34);
            this.txtAciklama.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAciklama.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.txtAciklama.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.txtAciklama.StateCommon.Border.ColorAngle = 45F;
            this.txtAciklama.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAciklama.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAciklama.StateCommon.Border.Rounding = 18F;
            this.txtAciklama.StateCommon.Border.Width = 1;
            this.txtAciklama.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtAciklama.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.TabIndex = 21;
            // 
            // dtTarih
            // 
            this.dtTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(193, 447);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(261, 33);
            this.dtTarih.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.dtTarih.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.dtTarih.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.dtTarih.StateCommon.Border.ColorAngle = 45F;
            this.dtTarih.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtTarih.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dtTarih.StateCommon.Border.Rounding = 18F;
            this.dtTarih.StateCommon.Border.Width = 1;
            this.dtTarih.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.dtTarih.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.TabIndex = 20;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiktar.Location = new System.Drawing.Point(193, 372);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(261, 34);
            this.txtMiktar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtMiktar.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.txtMiktar.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.txtMiktar.StateCommon.Border.ColorAngle = 45F;
            this.txtMiktar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMiktar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtMiktar.StateCommon.Border.Rounding = 18F;
            this.txtMiktar.StateCommon.Border.Width = 1;
            this.txtMiktar.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtMiktar.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.TabIndex = 19;
            // 
            // cmbHesaplar
            // 
            this.cmbHesaplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbHesaplar.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.cmbHesaplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHesaplar.DropDownWidth = 120;
            this.cmbHesaplar.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbHesaplar.Location = new System.Drawing.Point(193, 153);
            this.cmbHesaplar.MaxDropDownItems = 10;
            this.cmbHesaplar.Name = "cmbHesaplar";
            this.cmbHesaplar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbHesaplar.Size = new System.Drawing.Size(261, 33);
            this.cmbHesaplar.StateActive.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbHesaplar.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbHesaplar.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbHesaplar.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbHesaplar.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cmbHesaplar.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbHesaplar.StateCommon.ComboBox.Border.Rounding = 18F;
            this.cmbHesaplar.StateCommon.ComboBox.Border.Width = 1;
            this.cmbHesaplar.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbHesaplar.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHesaplar.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cmbHesaplar.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cmbHesaplar.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cmbHesaplar.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cmbHesaplar.StateCommon.Item.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbHesaplar.StateCommon.Item.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbHesaplar.StateCommon.Item.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbHesaplar.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbHesaplar.StateCommon.Item.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cmbHesaplar.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.cmbHesaplar.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cmbHesaplar.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cmbHesaplar.StateCommon.Item.Content.ShortText.ColorAngle = 45F;
            this.cmbHesaplar.StateNormal.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbHesaplar.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Transparent;
            this.cmbHesaplar.StateNormal.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbHesaplar.TabIndex = 17;
            this.cmbHesaplar.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(220, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Yeni İşlem Ekle";
            // 
            // btnIslemEkle
            // 
            this.btnIslemEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIslemEkle.AutoSize = true;
            this.btnIslemEkle.Location = new System.Drawing.Point(254, 568);
            this.btnIslemEkle.Name = "btnIslemEkle";
            this.btnIslemEkle.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnIslemEkle.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnIslemEkle.OverrideDefault.Back.ColorAngle = 45F;
            this.btnIslemEkle.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnIslemEkle.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnIslemEkle.OverrideDefault.Border.ColorAngle = 45F;
            this.btnIslemEkle.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIslemEkle.OverrideDefault.Border.Rounding = 18F;
            this.btnIslemEkle.OverrideDefault.Border.Width = 1;
            this.btnIslemEkle.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnIslemEkle.Size = new System.Drawing.Size(129, 38);
            this.btnIslemEkle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnIslemEkle.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnIslemEkle.StateCommon.Back.ColorAngle = 45F;
            this.btnIslemEkle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnIslemEkle.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnIslemEkle.StateCommon.Border.ColorAngle = 45F;
            this.btnIslemEkle.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIslemEkle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnIslemEkle.StateCommon.Border.Rounding = 18F;
            this.btnIslemEkle.StateCommon.Border.Width = 1;
            this.btnIslemEkle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnIslemEkle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnIslemEkle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemEkle.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnIslemEkle.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnIslemEkle.StateTracking.Back.ColorAngle = 45F;
            this.btnIslemEkle.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnIslemEkle.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnIslemEkle.StateTracking.Border.ColorAngle = 45F;
            this.btnIslemEkle.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIslemEkle.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnIslemEkle.StateTracking.Border.Rounding = 18F;
            this.btnIslemEkle.StateTracking.Border.Width = 1;
            this.btnIslemEkle.TabIndex = 24;
            this.btnIslemEkle.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnIslemEkle.Values.Text = "Kaydet";
            this.btnIslemEkle.Click += new System.EventHandler(this.BtnIslemEkle_Click);
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbIslemTuru.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.DropDownWidth = 120;
            this.cmbIslemTuru.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbIslemTuru.Location = new System.Drawing.Point(193, 226);
            this.cmbIslemTuru.MaxDropDownItems = 10;
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbIslemTuru.Size = new System.Drawing.Size(261, 33);
            this.cmbIslemTuru.StateActive.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbIslemTuru.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbIslemTuru.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbIslemTuru.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbIslemTuru.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cmbIslemTuru.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbIslemTuru.StateCommon.ComboBox.Border.Rounding = 18F;
            this.cmbIslemTuru.StateCommon.ComboBox.Border.Width = 1;
            this.cmbIslemTuru.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbIslemTuru.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cmbIslemTuru.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cmbIslemTuru.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cmbIslemTuru.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cmbIslemTuru.StateCommon.Item.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbIslemTuru.StateCommon.Item.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbIslemTuru.StateCommon.Item.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbIslemTuru.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbIslemTuru.StateCommon.Item.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cmbIslemTuru.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.cmbIslemTuru.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cmbIslemTuru.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cmbIslemTuru.StateCommon.Item.Content.ShortText.ColorAngle = 45F;
            this.cmbIslemTuru.StateNormal.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbIslemTuru.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Transparent;
            this.cmbIslemTuru.StateNormal.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbIslemTuru.TabIndex = 25;
            this.cmbIslemTuru.UseMnemonic = false;
            // 
            // cmbKategori
            // 
            this.cmbKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKategori.DropBackStyle = Krypton.Toolkit.PaletteBackStyle.InputControlStandalone;
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.DropDownWidth = 120;
            this.cmbKategori.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbKategori.Location = new System.Drawing.Point(193, 299);
            this.cmbKategori.MaxDropDownItems = 10;
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cmbKategori.Size = new System.Drawing.Size(261, 33);
            this.cmbKategori.StateActive.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbKategori.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cmbKategori.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbKategori.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbKategori.StateCommon.ComboBox.Border.ColorAngle = 45F;
            this.cmbKategori.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbKategori.StateCommon.ComboBox.Border.Rounding = 18F;
            this.cmbKategori.StateCommon.ComboBox.Border.Width = 1;
            this.cmbKategori.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cmbKategori.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cmbKategori.StateCommon.DropBack.Color1 = System.Drawing.Color.White;
            this.cmbKategori.StateCommon.DropBack.Color2 = System.Drawing.Color.White;
            this.cmbKategori.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.cmbKategori.StateCommon.Item.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbKategori.StateCommon.Item.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.cmbKategori.StateCommon.Item.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.cmbKategori.StateCommon.Item.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbKategori.StateCommon.Item.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            this.cmbKategori.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(5);
            this.cmbKategori.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.cmbKategori.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.cmbKategori.StateCommon.Item.Content.ShortText.ColorAngle = 45F;
            this.cmbKategori.StateNormal.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbKategori.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.Transparent;
            this.cmbKategori.StateNormal.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbKategori.TabIndex = 26;
            this.cmbKategori.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(588, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Hesap";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(202, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "İşlem Türü";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(202, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(202, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Miktar";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(202, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tarih";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(202, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Açıklama";
            // 
            // uc_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbIslemTuru);
            this.Controls.Add(this.btnIslemEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.cmbHesaplar);
            this.Controls.Add(this.label2);
            this.Name = "uc_ekle";
            this.Size = new System.Drawing.Size(1120, 690);
            ((System.ComponentModel.ISupportInitialize)(this.cmbHesaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIslemTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtAciklama;
        private Krypton.Toolkit.KryptonDateTimePicker dtTarih;
        private Krypton.Toolkit.KryptonTextBox txtMiktar;
        private Krypton.Toolkit.KryptonComboBox cmbHesaplar;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonButton btnIslemEkle;
        private Krypton.Toolkit.KryptonComboBox cmbIslemTuru;
        private Krypton.Toolkit.KryptonComboBox cmbKategori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
