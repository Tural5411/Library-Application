namespace Kitabxana.UI.Kitab
{
    partial class FrmKitab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitab));
            this.Kitablar = new DevExpress.XtraEditors.LabelControl();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBagla = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitab)).BeginInit();
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
            this.Kitablar.Size = new System.Drawing.Size(1040, 55);
            this.Kitablar.TabIndex = 0;
            this.Kitablar.Text = "Kitab";
            this.Kitablar.Click += new System.EventHandler(this.Kitablar_Click);
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.btnBagla);
            this.GroupControl1.Controls.Add(this.btnUpdate);
            this.GroupControl1.Controls.Add(this.simpleButton3);
            this.GroupControl1.Controls.Add(this.simpleButton2);
            this.GroupControl1.Controls.Add(this.simpleButton1);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupControl1.Location = new System.Drawing.Point(0, 549);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1040, 100);
            this.GroupControl1.TabIndex = 1;
            this.GroupControl1.Text = "Menu";
            // 
            // btnBagla
            // 
            this.btnBagla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBagla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBagla.ImageOptions.Image")));
            this.btnBagla.Location = new System.Drawing.Point(888, 26);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(152, 74);
            this.btnBagla.TabIndex = 2;
            this.btnBagla.Text = "BAĞLA";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(474, 26);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 74);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "YENİLƏ";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(316, 26);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(152, 74);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "SİL";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(158, 26);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(152, 74);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "EDİTLƏ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(0, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(152, 74);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "ELAVE ET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControlKitab
            // 
            this.gridControlKitab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitab.Location = new System.Drawing.Point(0, 55);
            this.gridControlKitab.MainView = this.gridKitab;
            this.gridControlKitab.Name = "gridControlKitab";
            this.gridControlKitab.Size = new System.Drawing.Size(1040, 494);
            this.gridControlKitab.TabIndex = 2;
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
            this.colId});
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
            this.ColKitabAdi.FieldName = "KitabAdi";
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
            this.ColKitabKod.FieldName = "KitabKodu";
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
            this.ColKirayeVerilebiler.FieldName = "KirayeVerilebiler";
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
            this.colISBN.FieldName = "ISBN";
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
            this.colNesrili.FieldName = "Nesrili";
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
            this.colNesrsayi.FieldName = "NesrSayi";
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
            this.gridColumn1.FieldName = "CildSayi";
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
            this.colNesriyyat.FieldName = "Nesriyyat";
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
            this.colDemirbasno.FieldName = "Demirbasno";
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
            this.colAciqlama.FieldName = "Aciqlama";
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
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.Width = 94;
            // 
            // FrmKitab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 649);
            this.Controls.Add(this.gridControlKitab);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.Kitablar);
            this.Name = "FrmKitab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKitab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Kitablar;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
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
        private DevExpress.XtraEditors.SimpleButton btnBagla;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
    }
}