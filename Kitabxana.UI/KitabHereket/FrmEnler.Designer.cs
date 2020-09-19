namespace Kitabxana.UI.KitabHereket
{
    partial class FrmEnler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnler));
            this.Kitablar = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlKitab = new DevExpress.XtraGrid.GridControl();
            this.gridKitab = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColVeziyyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKitabAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKitabKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKirayeVerilebiler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNesrili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNesrsayi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNesriyyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDemirbasno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciqlama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitabOxunmaSayi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexsiyyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMekteb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSektor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIstifadeciOxunmaSayi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kitablar
            // 
            this.Kitablar.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Kitablar.Appearance.Options.UseFont = true;
            this.Kitablar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Kitablar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kitablar.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.Kitablar.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kitablar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Kitablar.ImageOptions.Image")));
            this.Kitablar.Location = new System.Drawing.Point(0, 0);
            this.Kitablar.Margin = new System.Windows.Forms.Padding(10);
            this.Kitablar.Name = "Kitablar";
            this.Kitablar.Size = new System.Drawing.Size(1219, 53);
            this.Kitablar.TabIndex = 8;
            this.Kitablar.Text = "Alis veris";
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(510, 290);
            this.chartControl1.TabIndex = 11;
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(512, 392);
            this.chartControl2.TabIndex = 12;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 53);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1219, 694);
            this.splitContainerControl1.SplitterPosition = 290;
            this.splitContainerControl1.TabIndex = 13;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControlKitab);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.chartControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1219, 290);
            this.splitContainerControl2.SplitterPosition = 697;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // gridControlKitab
            // 
            this.gridControlKitab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitab.Location = new System.Drawing.Point(0, 0);
            this.gridControlKitab.MainView = this.gridKitab;
            this.gridControlKitab.Name = "gridControlKitab";
            this.gridControlKitab.Size = new System.Drawing.Size(697, 290);
            this.gridControlKitab.TabIndex = 3;
            this.gridControlKitab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitab});
            // 
            // gridKitab
            // 
            this.gridKitab.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColVeziyyet,
            this.ColKitabAdi,
            this.ColKitabKod,
            this.ColKirayeVerilebiler,
            this.colISBN,
            this.colNesrili,
            this.colNesrsayi,
            this.gridColumn1,
            this.colNesriyyat,
            this.colDemirbasno,
            this.colAciqlama,
            this.colId,
            this.colKitabOxunmaSayi});
            this.gridKitab.GridControl = this.gridControlKitab;
            this.gridKitab.Name = "gridKitab";
            // 
            // ColVeziyyet
            // 
            this.ColVeziyyet.Caption = "Veziyyet";
            this.ColVeziyyet.FieldName = "Veziyyet";
            this.ColVeziyyet.MinWidth = 25;
            this.ColVeziyyet.Name = "ColVeziyyet";
            this.ColVeziyyet.OptionsColumn.AllowEdit = false;
            this.ColVeziyyet.Visible = true;
            this.ColVeziyyet.VisibleIndex = 0;
            this.ColVeziyyet.Width = 94;
            // 
            // ColKitabAdi
            // 
            this.ColKitabAdi.Caption = "Kitab Adi";
            this.ColKitabAdi.FieldName = "kitap.KitabAdi";
            this.ColKitabAdi.MinWidth = 25;
            this.ColKitabAdi.Name = "ColKitabAdi";
            this.ColKitabAdi.OptionsColumn.AllowEdit = false;
            this.ColKitabAdi.Visible = true;
            this.ColKitabAdi.VisibleIndex = 1;
            this.ColKitabAdi.Width = 94;
            // 
            // ColKitabKod
            // 
            this.ColKitabKod.Caption = "KitabKodu";
            this.ColKitabKod.FieldName = "kitap.KitabKodu";
            this.ColKitabKod.MinWidth = 25;
            this.ColKitabKod.Name = "ColKitabKod";
            this.ColKitabKod.OptionsColumn.AllowEdit = false;
            this.ColKitabKod.Visible = true;
            this.ColKitabKod.VisibleIndex = 2;
            this.ColKitabKod.Width = 94;
            // 
            // ColKirayeVerilebiler
            // 
            this.ColKirayeVerilebiler.Caption = "Kiraye";
            this.ColKirayeVerilebiler.FieldName = "kitap.KirayeVerilebiler";
            this.ColKirayeVerilebiler.MinWidth = 25;
            this.ColKirayeVerilebiler.Name = "ColKirayeVerilebiler";
            this.ColKirayeVerilebiler.OptionsColumn.AllowEdit = false;
            this.ColKirayeVerilebiler.Visible = true;
            this.ColKirayeVerilebiler.VisibleIndex = 3;
            this.ColKirayeVerilebiler.Width = 94;
            // 
            // colISBN
            // 
            this.colISBN.Caption = "ISBN";
            this.colISBN.FieldName = "kitap.ISBN";
            this.colISBN.MinWidth = 25;
            this.colISBN.Name = "colISBN";
            this.colISBN.OptionsColumn.AllowEdit = false;
            this.colISBN.Visible = true;
            this.colISBN.VisibleIndex = 4;
            this.colISBN.Width = 94;
            // 
            // colNesrili
            // 
            this.colNesrili.Caption = "Nesr ili";
            this.colNesrili.FieldName = "kitap.Nesrili";
            this.colNesrili.MinWidth = 25;
            this.colNesrili.Name = "colNesrili";
            this.colNesrili.OptionsColumn.AllowEdit = false;
            this.colNesrili.Visible = true;
            this.colNesrili.VisibleIndex = 6;
            this.colNesrili.Width = 94;
            // 
            // colNesrsayi
            // 
            this.colNesrsayi.Caption = "Nesr sayi";
            this.colNesrsayi.FieldName = "kitap.NesrSayi";
            this.colNesrsayi.MinWidth = 25;
            this.colNesrsayi.Name = "colNesrsayi";
            this.colNesrsayi.OptionsColumn.AllowEdit = false;
            this.colNesrsayi.Visible = true;
            this.colNesrsayi.VisibleIndex = 7;
            this.colNesrsayi.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cild Sayi";
            this.gridColumn1.FieldName = "kitap.CildSayi";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 94;
            // 
            // colNesriyyat
            // 
            this.colNesriyyat.Caption = "Nesriyyat";
            this.colNesriyyat.FieldName = "kitap.Nesriyyat";
            this.colNesriyyat.MinWidth = 25;
            this.colNesriyyat.Name = "colNesriyyat";
            this.colNesriyyat.OptionsColumn.AllowEdit = false;
            this.colNesriyyat.Visible = true;
            this.colNesriyyat.VisibleIndex = 5;
            this.colNesriyyat.Width = 94;
            // 
            // colDemirbasno
            // 
            this.colDemirbasno.Caption = "Demirbasno";
            this.colDemirbasno.FieldName = "kitap.Demirbasno";
            this.colDemirbasno.MinWidth = 25;
            this.colDemirbasno.Name = "colDemirbasno";
            this.colDemirbasno.OptionsColumn.AllowEdit = false;
            this.colDemirbasno.Visible = true;
            this.colDemirbasno.VisibleIndex = 9;
            this.colDemirbasno.Width = 94;
            // 
            // colAciqlama
            // 
            this.colAciqlama.Caption = "Aciqlama";
            this.colAciqlama.FieldName = "kitap.Aciqlama";
            this.colAciqlama.MinWidth = 25;
            this.colAciqlama.Name = "colAciqlama";
            this.colAciqlama.OptionsColumn.AllowEdit = false;
            this.colAciqlama.Visible = true;
            this.colAciqlama.VisibleIndex = 10;
            this.colAciqlama.Width = 94;
            // 
            // colId
            // 
            this.colId.Caption = "KitabId";
            this.colId.FieldName = "kitap.Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Width = 94;
            // 
            // colKitabOxunmaSayi
            // 
            this.colKitabOxunmaSayi.Caption = "Oxunma Sayi";
            this.colKitabOxunmaSayi.FieldName = "OxunmaSayi";
            this.colKitabOxunmaSayi.MinWidth = 25;
            this.colKitabOxunmaSayi.Name = "colKitabOxunmaSayi";
            this.colKitabOxunmaSayi.Visible = true;
            this.colKitabOxunmaSayi.VisibleIndex = 11;
            this.colKitabOxunmaSayi.Width = 94;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.chartControl2);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1219, 392);
            this.splitContainerControl3.SplitterPosition = 695;
            this.splitContainerControl3.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(695, 392);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.colSexsiyyet,
            this.colMekteb,
            this.colAdi,
            this.colBarkod,
            this.colSoyadi,
            this.colSektor,
            this.colTarix,
            this.gridColumn4,
            this.colasd,
            this.colIstifadeciOxunmaSayi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "KitabId";
            this.gridColumn2.FieldName = "istfdci.Id";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ShowInCustomizationForm = false;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Vəziyyət";
            this.gridColumn3.FieldName = "istfdci.Veziyyet";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 94;
            // 
            // colSexsiyyet
            // 
            this.colSexsiyyet.Caption = "Şəxsiyyət N";
            this.colSexsiyyet.FieldName = "istfdci.SexsiyyetNo";
            this.colSexsiyyet.MinWidth = 25;
            this.colSexsiyyet.Name = "colSexsiyyet";
            this.colSexsiyyet.Visible = true;
            this.colSexsiyyet.VisibleIndex = 1;
            this.colSexsiyyet.Width = 94;
            // 
            // colMekteb
            // 
            this.colMekteb.Caption = "Məktəb N";
            this.colMekteb.FieldName = "istfdci.MektebNo";
            this.colMekteb.MinWidth = 25;
            this.colMekteb.Name = "colMekteb";
            this.colMekteb.Visible = true;
            this.colMekteb.VisibleIndex = 2;
            this.colMekteb.Width = 94;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "istfdci.Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 4;
            this.colAdi.Width = 94;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "istfdci.Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 3;
            this.colBarkod.Width = 94;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "istfdci.Soyadi";
            this.colSoyadi.MinWidth = 25;
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 5;
            this.colSoyadi.Width = 94;
            // 
            // colSektor
            // 
            this.colSektor.Caption = "Sektor";
            this.colSektor.FieldName = "istfdci.Sektor";
            this.colSektor.MinWidth = 25;
            this.colSektor.Name = "colSektor";
            this.colSektor.Visible = true;
            this.colSektor.VisibleIndex = 6;
            this.colSektor.Width = 94;
            // 
            // colTarix
            // 
            this.colTarix.Caption = "Tarix";
            this.colTarix.FieldName = "istfdci.QeydiyyatTarixi";
            this.colTarix.MinWidth = 25;
            this.colTarix.Name = "colTarix";
            this.colTarix.Visible = true;
            this.colTarix.VisibleIndex = 7;
            this.colTarix.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Açıqlama";
            this.gridColumn4.FieldName = "istfdci.Aciqlama";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 94;
            // 
            // colasd
            // 
            this.colasd.Caption = "Sektor";
            this.colasd.FieldName = "istfdci.Sinif.Sektor";
            this.colasd.MinWidth = 25;
            this.colasd.Name = "colasd";
            this.colasd.Visible = true;
            this.colasd.VisibleIndex = 9;
            this.colasd.Width = 94;
            // 
            // colIstifadeciOxunmaSayi
            // 
            this.colIstifadeciOxunmaSayi.Caption = "Oxudugu Kitab Sayi";
            this.colIstifadeciOxunmaSayi.FieldName = "OxunmaSayi";
            this.colIstifadeciOxunmaSayi.MinWidth = 25;
            this.colIstifadeciOxunmaSayi.Name = "colIstifadeciOxunmaSayi";
            this.colIstifadeciOxunmaSayi.Visible = true;
            this.colIstifadeciOxunmaSayi.VisibleIndex = 10;
            this.colIstifadeciOxunmaSayi.Width = 94;
            // 
            // FrmEnler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 747);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.Kitablar);
            this.Name = "FrmEnler";
            this.Text = "FrmEnler";
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Kitablar;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraGrid.GridControl gridControlKitab;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKitab;
        private DevExpress.XtraGrid.Columns.GridColumn ColVeziyyet;
        private DevExpress.XtraGrid.Columns.GridColumn ColKitabAdi;
        private DevExpress.XtraGrid.Columns.GridColumn ColKitabKod;
        private DevExpress.XtraGrid.Columns.GridColumn ColKirayeVerilebiler;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colNesrili;
        private DevExpress.XtraGrid.Columns.GridColumn colNesrsayi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colNesriyyat;
        private DevExpress.XtraGrid.Columns.GridColumn colDemirbasno;
        private DevExpress.XtraGrid.Columns.GridColumn colAciqlama;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKitabOxunmaSayi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colSexsiyyet;
        private DevExpress.XtraGrid.Columns.GridColumn colMekteb;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colSektor;
        private DevExpress.XtraGrid.Columns.GridColumn colTarix;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colasd;
        private DevExpress.XtraGrid.Columns.GridColumn colIstifadeciOxunmaSayi;
    }
}