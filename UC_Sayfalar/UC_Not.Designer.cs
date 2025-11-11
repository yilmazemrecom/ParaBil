namespace ParaBil.UC_Sayfalar
{
    partial class UC_Notcs
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
            this.txtBaslik = new Krypton.Toolkit.KryptonTextBox();
            this.btnNotEkle = new Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNotlar = new Krypton.Toolkit.KryptonDataGridView();
            this.txtIcerik = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBaslik
            // 
            this.txtBaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBaslik.Location = new System.Drawing.Point(127, 186);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(261, 35);
            this.txtBaslik.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBaslik.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.txtBaslik.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.txtBaslik.StateCommon.Border.ColorAngle = 45F;
            this.txtBaslik.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBaslik.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBaslik.StateCommon.Border.Rounding = 18;
            this.txtBaslik.StateCommon.Border.Width = 1;
            this.txtBaslik.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtBaslik.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.TabIndex = 20;
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNotEkle.AutoSize = true;
            this.btnNotEkle.Location = new System.Drawing.Point(194, 395);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnNotEkle.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnNotEkle.OverrideDefault.Back.ColorAngle = 45F;
            this.btnNotEkle.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnNotEkle.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnNotEkle.OverrideDefault.Border.ColorAngle = 45F;
            this.btnNotEkle.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNotEkle.OverrideDefault.Border.Rounding = 18;
            this.btnNotEkle.OverrideDefault.Border.Width = 1;
            this.btnNotEkle.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnNotEkle.Size = new System.Drawing.Size(129, 38);
            this.btnNotEkle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnNotEkle.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnNotEkle.StateCommon.Back.ColorAngle = 45F;
            this.btnNotEkle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnNotEkle.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.btnNotEkle.StateCommon.Border.ColorAngle = 45F;
            this.btnNotEkle.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNotEkle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNotEkle.StateCommon.Border.Rounding = 18;
            this.btnNotEkle.StateCommon.Border.Width = 1;
            this.btnNotEkle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNotEkle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNotEkle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotEkle.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnNotEkle.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnNotEkle.StateTracking.Back.ColorAngle = 45F;
            this.btnNotEkle.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnNotEkle.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.btnNotEkle.StateTracking.Border.ColorAngle = 45F;
            this.btnNotEkle.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNotEkle.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNotEkle.StateTracking.Border.Rounding = 18;
            this.btnNotEkle.StateTracking.Border.Width = 1;
            this.btnNotEkle.TabIndex = 25;
            this.btnNotEkle.Values.Text = "Ekle";
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(136, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Başlık";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "İçerik";
            // 
            // dataGridViewNotlar
            // 
            this.dataGridViewNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNotlar.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewNotlar.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewNotlar.MultiSelect = false;
            this.dataGridViewNotlar.Name = "dataGridViewNotlar";
            this.dataGridViewNotlar.ReadOnly = true;
            this.dataGridViewNotlar.RowHeadersVisible = false;
            this.dataGridViewNotlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNotlar.Size = new System.Drawing.Size(566, 676);
            this.dataGridViewNotlar.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataGridViewNotlar.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dataGridViewNotlar.StateCommon.Background.ColorAngle = 45F;
            this.dataGridViewNotlar.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Transparent;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Transparent;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Border.Rounding = 18;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Border.Width = 1;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Black;
            this.dataGridViewNotlar.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewNotlar.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewNotlar.TabIndex = 33;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIcerik.Location = new System.Drawing.Point(127, 263);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(261, 115);
            this.txtIcerik.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtIcerik.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.txtIcerik.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.txtIcerik.StateCommon.Border.ColorAngle = 45F;
            this.txtIcerik.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIcerik.StateCommon.Border.Rounding = 18;
            this.txtIcerik.StateCommon.Border.Width = 1;
            this.txtIcerik.TabIndex = 34;
            this.txtIcerik.Text = "";
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonGroup1.Location = new System.Drawing.Point(540, 0);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(10);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.dataGridViewNotlar);
            this.kryptonGroup1.Size = new System.Drawing.Size(580, 690);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonGroup1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 18;
            this.kryptonGroup1.StateCommon.Border.Width = 1;
            this.kryptonGroup1.TabIndex = 35;
            // 
            // UC_Notcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNotEkle);
            this.Controls.Add(this.txtBaslik);
            this.Name = "UC_Notcs";
            this.Size = new System.Drawing.Size(1120, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtBaslik;
        private Krypton.Toolkit.KryptonButton btnNotEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonDataGridView dataGridViewNotlar;
        private Krypton.Toolkit.KryptonRichTextBox txtIcerik;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
    }
}
