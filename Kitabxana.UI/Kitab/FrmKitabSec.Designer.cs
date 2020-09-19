namespace Kitabxana.UI.Kitab
{
    partial class FrmKitabSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitabSec));
            this.GroupMenu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBagla = new DevExpress.XtraEditors.SimpleButton();
            this.lblBasliq = new DevExpress.XtraEditors.LabelControl();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
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
            this.gridControlBarkod = new DevExpress.XtraGrid.GridControl();
            this.repositoryItemRatingControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
            this.gridBarkod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeyerlendirme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtaq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiyirme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkodAciqlama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupMenu)).BeginInit();
            this.GroupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupMenu
            // 
            this.GroupMenu.Controls.Add(this.simpleButton2);
            this.GroupMenu.Controls.Add(this.simpleButton1);
            this.GroupMenu.Controls.Add(this.btnBagla);
            this.GroupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupMenu.Location = new System.Drawing.Point(0, 597);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Size = new System.Drawing.Size(768, 100);
            this.GroupMenu.TabIndex = 4;
            this.GroupMenu.Text = "Menu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageIndex = 6;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(470, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 54);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Seç";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnBagla
            // 
            this.btnBagla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBagla.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBagla.Appearance.Options.UseFont = true;
            this.btnBagla.ImageOptions.ImageIndex = 5;
            this.btnBagla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBagla.ImageOptions.SvgImage")));
            this.btnBagla.Location = new System.Drawing.Point(621, 34);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(135, 54);
            this.btnBagla.TabIndex = 0;
            this.btnBagla.Text = "Bağla";
            this.btnBagla.Click += new System.EventHandler(this.btnBagla_Click);
            // 
            // lblBasliq
            // 
            this.lblBasliq.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblBasliq.Appearance.Options.UseFont = true;
            this.lblBasliq.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBasliq.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBasliq.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblBasliq.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBasliq.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Kitablar.ImageOptions.SvgImage")));
            this.lblBasliq.Location = new System.Drawing.Point(0, 0);
            this.lblBasliq.Margin = new System.Windows.Forms.Padding(10);
            this.lblBasliq.Name = "lblBasliq";
            this.lblBasliq.Size = new System.Drawing.Size(768, 63);
            this.lblBasliq.TabIndex = 3;
            this.lblBasliq.Text = "Zəhmət Olmasa Kitab Seçin";
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 63);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage1;
            this.navigationFrame1.Size = new System.Drawing.Size(768, 534);
            this.navigationFrame1.TabIndex = 6;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.gridControlKitab);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(768, 534);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Controls.Add(this.gridControlBarkod);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(768, 534);
            // 
            // gridControlKitab
            // 
            this.gridControlKitab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitab.Location = new System.Drawing.Point(0, 0);
            this.gridControlKitab.MainView = this.gridKitab;
            this.gridControlKitab.Name = "gridControlKitab";
            this.gridControlKitab.Size = new System.Drawing.Size(768, 534);
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
            // gridControlBarkod
            // 
            this.gridControlBarkod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBarkod.Location = new System.Drawing.Point(0, 0);
            this.gridControlBarkod.MainView = this.gridBarkod;
            this.gridControlBarkod.Name = "gridControlBarkod";
            this.gridControlBarkod.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRatingControl1});
            this.gridControlBarkod.Size = new System.Drawing.Size(768, 534);
            this.gridControlBarkod.TabIndex = 2;
            this.gridControlBarkod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBarkod});
            // 
            // repositoryItemRatingControl1
            // 
            this.repositoryItemRatingControl1.AutoHeight = false;
            this.repositoryItemRatingControl1.Name = "repositoryItemRatingControl1";
            // 
            // gridBarkod
            // 
            this.gridBarkod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarkodu,
            this.colDeyerlendirme,
            this.colOtaq,
            this.colSira,
            this.colRef,
            this.colSiyirme,
            this.colBarkodAciqlama});
            this.gridBarkod.GridControl = this.gridControlBarkod;
            this.gridBarkod.Name = "gridBarkod";
            // 
            // colBarkodu
            // 
            this.colBarkodu.Caption = "Barkodu";
            this.colBarkodu.FieldName = "Barkodu";
            this.colBarkodu.MinWidth = 25;
            this.colBarkodu.Name = "colBarkodu";
            this.colBarkodu.Visible = true;
            this.colBarkodu.VisibleIndex = 0;
            this.colBarkodu.Width = 94;
            // 
            // colDeyerlendirme
            // 
            this.colDeyerlendirme.Caption = "Dəyərləndirmə";
            this.colDeyerlendirme.ColumnEdit = this.repositoryItemRatingControl1;
            this.colDeyerlendirme.FieldName = "Deyerlendirme";
            this.colDeyerlendirme.MinWidth = 25;
            this.colDeyerlendirme.Name = "colDeyerlendirme";
            this.colDeyerlendirme.Visible = true;
            this.colDeyerlendirme.VisibleIndex = 1;
            this.colDeyerlendirme.Width = 94;
            // 
            // colOtaq
            // 
            this.colOtaq.Caption = "Otaq";
            this.colOtaq.FieldName = "Otaq";
            this.colOtaq.MinWidth = 25;
            this.colOtaq.Name = "colOtaq";
            this.colOtaq.Visible = true;
            this.colOtaq.VisibleIndex = 2;
            this.colOtaq.Width = 94;
            // 
            // colSira
            // 
            this.colSira.Caption = "Sıra";
            this.colSira.FieldName = "Sira";
            this.colSira.MinWidth = 25;
            this.colSira.Name = "colSira";
            this.colSira.Visible = true;
            this.colSira.VisibleIndex = 3;
            this.colSira.Width = 94;
            // 
            // colRef
            // 
            this.colRef.Caption = "Rəf";
            this.colRef.FieldName = "Ref";
            this.colRef.MinWidth = 25;
            this.colRef.Name = "colRef";
            this.colRef.Visible = true;
            this.colRef.VisibleIndex = 4;
            this.colRef.Width = 94;
            // 
            // colSiyirme
            // 
            this.colSiyirme.Caption = "Siyirmə";
            this.colSiyirme.FieldName = "Siyirme";
            this.colSiyirme.MinWidth = 25;
            this.colSiyirme.Name = "colSiyirme";
            this.colSiyirme.Visible = true;
            this.colSiyirme.VisibleIndex = 5;
            this.colSiyirme.Width = 94;
            // 
            // colBarkodAciqlama
            // 
            this.colBarkodAciqlama.Caption = "Açıqlama";
            this.colBarkodAciqlama.FieldName = "Aciqlama";
            this.colBarkodAciqlama.MinWidth = 25;
            this.colBarkodAciqlama.Name = "colBarkodAciqlama";
            this.colBarkodAciqlama.Visible = true;
            this.colBarkodAciqlama.VisibleIndex = 6;
            this.colBarkodAciqlama.Width = 94;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.ImageIndex = 6;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(315, 34);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(135, 54);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Geri";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmKitabSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 697);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.GroupMenu);
            this.Controls.Add(this.lblBasliq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmKitabSec.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKitabSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitabSec";
            this.Load += new System.EventHandler(this.FrmKitabSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupMenu)).EndInit();
            this.GroupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarkod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnBagla;
        private DevExpress.XtraEditors.LabelControl lblBasliq;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
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
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControlBarkod;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDeyerlendirme;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colOtaq;
        private DevExpress.XtraGrid.Columns.GridColumn colSira;
        private DevExpress.XtraGrid.Columns.GridColumn colRef;
        private DevExpress.XtraGrid.Columns.GridColumn colSiyirme;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkodAciqlama;
    }
}