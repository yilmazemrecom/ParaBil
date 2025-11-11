namespace ParaBil.UC_Sayfalar
{
    partial class UC_Sil
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
            this.SilData = new Krypton.Toolkit.KryptonDataGridView();
            this.islem_sil = new Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.SilData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SilData
            // 
            this.SilData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SilData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SilData.Location = new System.Drawing.Point(0, 0);
            this.SilData.MultiSelect = false;
            this.SilData.Name = "SilData";
            this.SilData.ReadOnly = true;
            this.SilData.RowHeadersVisible = false;
            this.SilData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SilData.Size = new System.Drawing.Size(1086, 518);
            this.SilData.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.SilData.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.SilData.StateCommon.Background.ColorAngle = 45F;
            this.SilData.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.SilData.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.SilData.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.SilData.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Transparent;
            this.SilData.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Transparent;
            this.SilData.StateCommon.HeaderColumn.Border.ColorAngle = 45F;
            this.SilData.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SilData.StateCommon.HeaderColumn.Border.Rounding = 18;
            this.SilData.StateCommon.HeaderColumn.Border.Width = 1;
            this.SilData.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.SilData.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Black;
            this.SilData.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilData.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilData.TabIndex = 0;
            this.SilData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // islem_sil
            // 
            this.islem_sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.islem_sil.AutoSize = true;
            this.islem_sil.Location = new System.Drawing.Point(456, 32);
            this.islem_sil.Name = "islem_sil";
            this.islem_sil.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.islem_sil.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.islem_sil.OverrideDefault.Back.ColorAngle = 45F;
            this.islem_sil.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.islem_sil.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.islem_sil.OverrideDefault.Border.ColorAngle = 45F;
            this.islem_sil.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.islem_sil.OverrideDefault.Border.Rounding = 18;
            this.islem_sil.OverrideDefault.Border.Width = 1;
            this.islem_sil.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.islem_sil.Size = new System.Drawing.Size(188, 54);
            this.islem_sil.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.islem_sil.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.islem_sil.StateCommon.Back.ColorAngle = 45F;
            this.islem_sil.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.islem_sil.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(52)))), ((int)(((byte)(134)))));
            this.islem_sil.StateCommon.Border.ColorAngle = 45F;
            this.islem_sil.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.islem_sil.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.islem_sil.StateCommon.Border.Rounding = 18;
            this.islem_sil.StateCommon.Border.Width = 1;
            this.islem_sil.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.islem_sil.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.islem_sil.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem_sil.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.islem_sil.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.islem_sil.StateTracking.Back.ColorAngle = 45F;
            this.islem_sil.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.islem_sil.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(44)))));
            this.islem_sil.StateTracking.Border.ColorAngle = 45F;
            this.islem_sil.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.islem_sil.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.islem_sil.StateTracking.Border.Rounding = 18;
            this.islem_sil.StateTracking.Border.Width = 1;
            this.islem_sil.TabIndex = 10;
            this.islem_sil.Values.Text = "Seçili İşlemi Sil";
            this.islem_sil.Click += new System.EventHandler(this.IslemDelete);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonGroup2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonGroup1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 690);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup2.Location = new System.Drawing.Point(10, 10);
            this.kryptonGroup2.Margin = new System.Windows.Forms.Padding(10);
            this.kryptonGroup2.Name = "kryptonGroup2";
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.SilData);
            this.kryptonGroup2.Size = new System.Drawing.Size(1100, 532);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroup2.StateCommon.Back.ColorAngle = 45F;
            this.kryptonGroup2.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonGroup2.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonGroup2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonGroup2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup2.StateCommon.Border.Rounding = 18;
            this.kryptonGroup2.StateCommon.Border.Width = 1;
            this.kryptonGroup2.TabIndex = 4;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroup1.Location = new System.Drawing.Point(10, 562);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(10);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.islem_sil);
            this.kryptonGroup1.Size = new System.Drawing.Size(1100, 118);
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
            this.kryptonGroup1.TabIndex = 3;
            // 
            // UC_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Sil";
            this.Size = new System.Drawing.Size(1120, 690);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.SilData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView SilData;
        private Krypton.Toolkit.KryptonButton islem_sil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
    }
}
