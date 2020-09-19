namespace Kitabxana.UI.Sinif
{
    partial class FrmSinif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinif));
            this.Kitablar = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlSinif = new DevExpress.XtraGrid.GridControl();
            this.gridSinif = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSinifId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMektebNovu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSobe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBolum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSinifAciqlama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSinifYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSinifSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSinifEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSinifElave = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlIstifadeci = new DevExpress.XtraGrid.GridControl();
            this.layoutIstifadeci = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutVeziyyet = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutSexsiyyetNo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutMektebNo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutSoyadi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutQeydiyyatTarix = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8_5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.repositoryItemRatingControl2 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBagla = new DevExpress.XtraEditors.SimpleButton();
            this.btnIstifadeciYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnIstifadeciSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnIstifadeciEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnIstifadeciElave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSinif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIstifadeci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIstifadeci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
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
            this.Kitablar.Size = new System.Drawing.Size(1280, 53);
            this.Kitablar.TabIndex = 4;
            this.Kitablar.Text = "Sinifler";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 53);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlSinif);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlIstifadeci);
            this.splitContainerControl1.Panel2.Controls.Add(this.GroupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1280, 701);
            this.splitContainerControl1.SplitterPosition = 321;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // gridControlSinif
            // 
            this.gridControlSinif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSinif.Location = new System.Drawing.Point(0, 0);
            this.gridControlSinif.MainView = this.gridSinif;
            this.gridControlSinif.Name = "gridControlSinif";
            this.gridControlSinif.Size = new System.Drawing.Size(1280, 221);
            this.gridControlSinif.TabIndex = 6;
            this.gridControlSinif.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSinif});
            // 
            // gridSinif
            // 
            this.gridSinif.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSinifId,
            this.colMektebNovu,
            this.colSinif,
            this.colSobe,
            this.colBolum,
            this.colSinifAciqlama});
            this.gridSinif.GridControl = this.gridControlSinif;
            this.gridSinif.Name = "gridSinif";
            this.gridSinif.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridSinif_FocusedRowChanged_1);
            // 
            // colSinifId
            // 
            this.colSinifId.Caption = "Id";
            this.colSinifId.FieldName = "Id";
            this.colSinifId.MinWidth = 25;
            this.colSinifId.Name = "colSinifId";
            this.colSinifId.OptionsColumn.AllowEdit = false;
            this.colSinifId.Width = 94;
            // 
            // colMektebNovu
            // 
            this.colMektebNovu.Caption = "Mekteb Novu";
            this.colMektebNovu.FieldName = "MektebNovu";
            this.colMektebNovu.MinWidth = 25;
            this.colMektebNovu.Name = "colMektebNovu";
            this.colMektebNovu.OptionsColumn.AllowEdit = false;
            this.colMektebNovu.Visible = true;
            this.colMektebNovu.VisibleIndex = 0;
            this.colMektebNovu.Width = 250;
            // 
            // colSinif
            // 
            this.colSinif.Caption = "Sinif";
            this.colSinif.FieldName = "Sinif";
            this.colSinif.MinWidth = 25;
            this.colSinif.Name = "colSinif";
            this.colSinif.OptionsColumn.AllowEdit = false;
            this.colSinif.Visible = true;
            this.colSinif.VisibleIndex = 1;
            this.colSinif.Width = 108;
            // 
            // colSobe
            // 
            this.colSobe.Caption = "Sobe";
            this.colSobe.FieldName = "Sobe";
            this.colSobe.MinWidth = 25;
            this.colSobe.Name = "colSobe";
            this.colSobe.OptionsColumn.AllowEdit = false;
            this.colSobe.Visible = true;
            this.colSobe.VisibleIndex = 2;
            this.colSobe.Width = 261;
            // 
            // colBolum
            // 
            this.colBolum.Caption = "Bolum";
            this.colBolum.FieldName = "Bolumu";
            this.colBolum.MinWidth = 25;
            this.colBolum.Name = "colBolum";
            this.colBolum.OptionsColumn.AllowEdit = false;
            this.colBolum.Visible = true;
            this.colBolum.VisibleIndex = 3;
            this.colBolum.Width = 161;
            // 
            // colSinifAciqlama
            // 
            this.colSinifAciqlama.Caption = "Aciqlama";
            this.colSinifAciqlama.FieldName = "Aciqlama";
            this.colSinifAciqlama.MinWidth = 25;
            this.colSinifAciqlama.Name = "colSinifAciqlama";
            this.colSinifAciqlama.OptionsColumn.AllowEdit = false;
            this.colSinifAciqlama.Visible = true;
            this.colSinifAciqlama.VisibleIndex = 4;
            this.colSinifAciqlama.Width = 470;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSinifYenile);
            this.groupControl2.Controls.Add(this.btnSinifSil);
            this.groupControl2.Controls.Add(this.btnSinifEdit);
            this.groupControl2.Controls.Add(this.btnSinifElave);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 221);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1280, 100);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Menu";
            // 
            // btnSinifYenile
            // 
            this.btnSinifYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinifYenile.ImageOptions.Image")));
            this.btnSinifYenile.Location = new System.Drawing.Point(474, 26);
            this.btnSinifYenile.Name = "btnSinifYenile";
            this.btnSinifYenile.Size = new System.Drawing.Size(152, 74);
            this.btnSinifYenile.TabIndex = 1;
            this.btnSinifYenile.Text = "YENİLƏ";
            this.btnSinifYenile.Click += new System.EventHandler(this.btnSinifYenile_Click);
            // 
            // btnSinifSil
            // 
            this.btnSinifSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinifSil.ImageOptions.Image")));
            this.btnSinifSil.Location = new System.Drawing.Point(316, 26);
            this.btnSinifSil.Name = "btnSinifSil";
            this.btnSinifSil.Size = new System.Drawing.Size(152, 74);
            this.btnSinifSil.TabIndex = 0;
            this.btnSinifSil.Text = "SİL";
            this.btnSinifSil.Click += new System.EventHandler(this.btnSinifSil_Click);
            // 
            // btnSinifEdit
            // 
            this.btnSinifEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinifEdit.ImageOptions.Image")));
            this.btnSinifEdit.Location = new System.Drawing.Point(158, 26);
            this.btnSinifEdit.Name = "btnSinifEdit";
            this.btnSinifEdit.Size = new System.Drawing.Size(152, 74);
            this.btnSinifEdit.TabIndex = 0;
            this.btnSinifEdit.Text = "EDİTLƏ";
            this.btnSinifEdit.Click += new System.EventHandler(this.btnSinifEdit_Click_1);
            // 
            // btnSinifElave
            // 
            this.btnSinifElave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinifElave.ImageOptions.Image")));
            this.btnSinifElave.Location = new System.Drawing.Point(0, 26);
            this.btnSinifElave.Name = "btnSinifElave";
            this.btnSinifElave.Size = new System.Drawing.Size(152, 74);
            this.btnSinifElave.TabIndex = 0;
            this.btnSinifElave.Text = "ELAVE ET";
            this.btnSinifElave.Click += new System.EventHandler(this.btnSinifElave_Click_1);
            // 
            // gridControlIstifadeci
            // 
            this.gridControlIstifadeci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIstifadeci.Location = new System.Drawing.Point(0, 0);
            this.gridControlIstifadeci.MainView = this.layoutIstifadeci;
            this.gridControlIstifadeci.Name = "gridControlIstifadeci";
            this.gridControlIstifadeci.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRatingControl2});
            this.gridControlIstifadeci.Size = new System.Drawing.Size(1280, 268);
            this.gridControlIstifadeci.TabIndex = 6;
            this.gridControlIstifadeci.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutIstifadeci});
            // 
            // layoutIstifadeci
            // 
            this.layoutIstifadeci.CardMinSize = new System.Drawing.Size(302, 209);
            this.layoutIstifadeci.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutVeziyyet,
            this.layoutSexsiyyetNo,
            this.layoutMektebNo,
            this.layoutAdi,
            this.layoutSoyadi,
            this.layoutQeydiyyatTarix});
            this.layoutIstifadeci.GridControl = this.gridControlIstifadeci;
            this.layoutIstifadeci.Name = "layoutIstifadeci";
            this.layoutIstifadeci.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            this.layoutIstifadeci.TemplateCard = this.layoutViewCard2;
            // 
            // layoutVeziyyet
            // 
            this.layoutVeziyyet.Caption = "Veziyyeti";
            this.layoutVeziyyet.FieldName = "Veziyyeti";
            this.layoutVeziyyet.LayoutViewField = this.layoutViewField_layoutViewColumn8;
            this.layoutVeziyyet.MinWidth = 25;
            this.layoutVeziyyet.Name = "layoutVeziyyet";
            this.layoutVeziyyet.Width = 94;
            // 
            // layoutViewField_layoutViewColumn8
            // 
            this.layoutViewField_layoutViewColumn8.EditorPreferredWidth = 184;
            this.layoutViewField_layoutViewColumn8.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn8.Name = "layoutViewField_layoutViewColumn8";
            this.layoutViewField_layoutViewColumn8.Size = new System.Drawing.Size(284, 26);
            this.layoutViewField_layoutViewColumn8.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutSexsiyyetNo
            // 
            this.layoutSexsiyyetNo.Caption = "Sexsiyyet No";
            this.layoutSexsiyyetNo.FieldName = "SexsiyyetNo";
            this.layoutSexsiyyetNo.LayoutViewField = this.layoutViewField_layoutViewColumn8_1;
            this.layoutSexsiyyetNo.MinWidth = 25;
            this.layoutSexsiyyetNo.Name = "layoutSexsiyyetNo";
            this.layoutSexsiyyetNo.Width = 94;
            // 
            // layoutViewField_layoutViewColumn8_1
            // 
            this.layoutViewField_layoutViewColumn8_1.EditorPreferredWidth = 184;
            this.layoutViewField_layoutViewColumn8_1.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_layoutViewColumn8_1.Name = "layoutViewField_layoutViewColumn8_1";
            this.layoutViewField_layoutViewColumn8_1.Size = new System.Drawing.Size(284, 26);
            this.layoutViewField_layoutViewColumn8_1.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutMektebNo
            // 
            this.layoutMektebNo.Caption = "MektebNo";
            this.layoutMektebNo.FieldName = "MektebNo";
            this.layoutMektebNo.LayoutViewField = this.layoutViewField_layoutViewColumn8_2;
            this.layoutMektebNo.MinWidth = 25;
            this.layoutMektebNo.Name = "layoutMektebNo";
            this.layoutMektebNo.Width = 94;
            // 
            // layoutViewField_layoutViewColumn8_2
            // 
            this.layoutViewField_layoutViewColumn8_2.EditorPreferredWidth = 184;
            this.layoutViewField_layoutViewColumn8_2.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_layoutViewColumn8_2.Name = "layoutViewField_layoutViewColumn8_2";
            this.layoutViewField_layoutViewColumn8_2.Size = new System.Drawing.Size(284, 26);
            this.layoutViewField_layoutViewColumn8_2.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutAdi
            // 
            this.layoutAdi.Caption = "Adi";
            this.layoutAdi.FieldName = "Adi";
            this.layoutAdi.LayoutViewField = this.layoutViewField_layoutViewColumn8_3;
            this.layoutAdi.MinWidth = 25;
            this.layoutAdi.Name = "layoutAdi";
            this.layoutAdi.Width = 94;
            // 
            // layoutViewField_layoutViewColumn8_3
            // 
            this.layoutViewField_layoutViewColumn8_3.EditorPreferredWidth = 184;
            this.layoutViewField_layoutViewColumn8_3.Location = new System.Drawing.Point(0, 78);
            this.layoutViewField_layoutViewColumn8_3.Name = "layoutViewField_layoutViewColumn8_3";
            this.layoutViewField_layoutViewColumn8_3.Size = new System.Drawing.Size(284, 26);
            this.layoutViewField_layoutViewColumn8_3.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutSoyadi
            // 
            this.layoutSoyadi.Caption = "Soyadi";
            this.layoutSoyadi.FieldName = "Soyadi";
            this.layoutSoyadi.LayoutViewField = this.layoutViewField_layoutViewColumn8_4;
            this.layoutSoyadi.MinWidth = 25;
            this.layoutSoyadi.Name = "layoutSoyadi";
            this.layoutSoyadi.Width = 94;
            // 
            // layoutViewField_layoutViewColumn8_4
            // 
            this.layoutViewField_layoutViewColumn8_4.EditorPreferredWidth = 184;
            this.layoutViewField_layoutViewColumn8_4.Location = new System.Drawing.Point(0, 104);
            this.layoutViewField_layoutViewColumn8_4.Name = "layoutViewField_layoutViewColumn8_4";
            this.layoutViewField_layoutViewColumn8_4.Size = new System.Drawing.Size(284, 26);
            this.layoutViewField_layoutViewColumn8_4.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutQeydiyyatTarix
            // 
            this.layoutQeydiyyatTarix.Caption = "QeydiyyatTarix";
            this.layoutQeydiyyatTarix.FieldName = "QeydiyyatTarixi";
            this.layoutQeydiyyatTarix.LayoutViewField = this.layoutViewField_layoutViewColumn8_5;
            this.layoutQeydiyyatTarix.MinWidth = 25;
            this.layoutQeydiyyatTarix.Name = "layoutQeydiyyatTarix";
            this.layoutQeydiyyatTarix.Width = 94;
            // 
            // layoutViewField_layoutViewColumn8_5
            // 
            this.layoutViewField_layoutViewColumn8_5.EditorPreferredWidth = 184;
            this.layoutViewField_layoutViewColumn8_5.Location = new System.Drawing.Point(0, 130);
            this.layoutViewField_layoutViewColumn8_5.Name = "layoutViewField_layoutViewColumn8_5";
            this.layoutViewField_layoutViewColumn8_5.Size = new System.Drawing.Size(284, 33);
            this.layoutViewField_layoutViewColumn8_5.TextSize = new System.Drawing.Size(89, 16);
            // 
            // layoutViewCard2
            // 
            this.layoutViewCard2.CustomizationFormText = "TemplateCard";
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn8,
            this.layoutViewField_layoutViewColumn8_1,
            this.layoutViewField_layoutViewColumn8_2,
            this.layoutViewField_layoutViewColumn8_3,
            this.layoutViewField_layoutViewColumn8_4,
            this.layoutViewField_layoutViewColumn8_5});
            this.layoutViewCard2.Name = "layoutViewCard2";
            this.layoutViewCard2.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard2.Text = "TemplateCard";
            // 
            // repositoryItemRatingControl2
            // 
            this.repositoryItemRatingControl2.AutoHeight = false;
            this.repositoryItemRatingControl2.Name = "repositoryItemRatingControl2";
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.btnBagla);
            this.GroupControl1.Controls.Add(this.btnIstifadeciYenile);
            this.GroupControl1.Controls.Add(this.btnIstifadeciSil);
            this.GroupControl1.Controls.Add(this.btnIstifadeciEdit);
            this.GroupControl1.Controls.Add(this.btnIstifadeciElave);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupControl1.Location = new System.Drawing.Point(0, 268);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1280, 100);
            this.GroupControl1.TabIndex = 5;
            this.GroupControl1.Text = "Menu";
            // 
            // btnBagla
            // 
            this.btnBagla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBagla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBagla.ImageOptions.Image")));
            this.btnBagla.Location = new System.Drawing.Point(1128, 26);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(152, 74);
            this.btnBagla.TabIndex = 2;
            this.btnBagla.Text = "BAĞLA";
            this.btnBagla.Click += new System.EventHandler(this.btnBagla_Click_1);
            // 
            // btnIstifadeciYenile
            // 
            this.btnIstifadeciYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIstifadeciYenile.ImageOptions.Image")));
            this.btnIstifadeciYenile.Location = new System.Drawing.Point(474, 26);
            this.btnIstifadeciYenile.Name = "btnIstifadeciYenile";
            this.btnIstifadeciYenile.Size = new System.Drawing.Size(152, 74);
            this.btnIstifadeciYenile.TabIndex = 1;
            this.btnIstifadeciYenile.Text = "YENİLƏ";
            this.btnIstifadeciYenile.Click += new System.EventHandler(this.btnIstifadeciYenile_Click);
            // 
            // btnIstifadeciSil
            // 
            this.btnIstifadeciSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIstifadeciSil.ImageOptions.Image")));
            this.btnIstifadeciSil.Location = new System.Drawing.Point(316, 26);
            this.btnIstifadeciSil.Name = "btnIstifadeciSil";
            this.btnIstifadeciSil.Size = new System.Drawing.Size(152, 74);
            this.btnIstifadeciSil.TabIndex = 0;
            this.btnIstifadeciSil.Text = "SİL";
            this.btnIstifadeciSil.Click += new System.EventHandler(this.btnIstifadeciSil_Click);
            // 
            // btnIstifadeciEdit
            // 
            this.btnIstifadeciEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIstifadeciEdit.ImageOptions.Image")));
            this.btnIstifadeciEdit.Location = new System.Drawing.Point(158, 26);
            this.btnIstifadeciEdit.Name = "btnIstifadeciEdit";
            this.btnIstifadeciEdit.Size = new System.Drawing.Size(152, 74);
            this.btnIstifadeciEdit.TabIndex = 0;
            this.btnIstifadeciEdit.Text = "EDİTLƏ";
            this.btnIstifadeciEdit.Click += new System.EventHandler(this.btnIstifadeciEdit_Click);
            // 
            // btnIstifadeciElave
            // 
            this.btnIstifadeciElave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIstifadeciElave.ImageOptions.Image")));
            this.btnIstifadeciElave.Location = new System.Drawing.Point(0, 26);
            this.btnIstifadeciElave.Name = "btnIstifadeciElave";
            this.btnIstifadeciElave.Size = new System.Drawing.Size(152, 74);
            this.btnIstifadeciElave.TabIndex = 0;
            this.btnIstifadeciElave.Text = "ELAVE ET";
            this.btnIstifadeciElave.Click += new System.EventHandler(this.btnIstifadeciElave_Click_1);
            // 
            // FrmSinif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 754);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.Kitablar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSinif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSinif";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSinif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIstifadeci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutIstifadeci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Kitablar;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlSinif;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSinif;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSinifYenile;
        private DevExpress.XtraEditors.SimpleButton btnSinifSil;
        private DevExpress.XtraEditors.SimpleButton btnSinifEdit;
        private DevExpress.XtraEditors.SimpleButton btnSinifElave;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private DevExpress.XtraEditors.SimpleButton btnBagla;
        private DevExpress.XtraEditors.SimpleButton btnIstifadeciYenile;
        private DevExpress.XtraEditors.SimpleButton btnIstifadeciSil;
        private DevExpress.XtraEditors.SimpleButton btnIstifadeciEdit;
        private DevExpress.XtraEditors.SimpleButton btnIstifadeciElave;
        private DevExpress.XtraGrid.Columns.GridColumn colSinifId;
        private DevExpress.XtraGrid.Columns.GridColumn colMektebNovu;
        private DevExpress.XtraGrid.Columns.GridColumn colSinif;
        private DevExpress.XtraGrid.Columns.GridColumn colSobe;
        private DevExpress.XtraGrid.Columns.GridColumn colBolum;
        private DevExpress.XtraGrid.Columns.GridColumn colSinifAciqlama;
        private DevExpress.XtraGrid.GridControl gridControlIstifadeci;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutIstifadeci;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutVeziyyet;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutSexsiyyetNo;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutMektebNo;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutSoyadi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutQeydiyyatTarix;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8_5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl2;
    }
}