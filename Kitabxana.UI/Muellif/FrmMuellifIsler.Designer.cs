namespace Kitabxana.UI.Muellif
{
    partial class FrmMuellifIsler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMuellifIsler));
            this.Kitablar = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GroupMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnYaddaSaxla = new DevExpress.XtraEditors.SimpleButton();
            this.btnBagla = new DevExpress.XtraEditors.SimpleButton();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabMuellifMelumat = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabMuellifKitab = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txtMuellifAciqlama = new DevExpress.XtraEditors.MemoEdit();
            this.txtMlfDogumTarixi = new DevExpress.XtraEditors.TextEdit();
            this.txtMlfSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtMuellifAdi = new DevExpress.XtraEditors.TextEdit();
            this.gridControlMuellifKitab = new DevExpress.XtraGrid.GridControl();
            this.layoutKitab = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colKitabKodu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKitabAdi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKitabNovu = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colKitabISBN = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colNesriyyat = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1_4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.repositoryItemRatingControl2 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupMenu)).BeginInit();
            this.GroupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabMuellifMelumat.SuspendLayout();
            this.tabMuellifKitab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMuellifAciqlama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMlfDogumTarixi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMlfSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMuellifAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMuellifKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // Kitablar
            // 
            this.Kitablar.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Kitablar.Appearance.Options.UseFont = true;
            this.Kitablar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.Kitablar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kitablar.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.Kitablar.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kitablar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Kitablar.ImageOptions.Image")));
            this.Kitablar.Location = new System.Drawing.Point(0, 0);
            this.Kitablar.Margin = new System.Windows.Forms.Padding(10);
            this.Kitablar.Name = "Kitablar";
            this.Kitablar.Size = new System.Drawing.Size(641, 36);
            this.Kitablar.TabIndex = 2;
            this.Kitablar.Text = "Müəllif Əməliyyatları";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-delete-bin-128.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-add-book-96.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-create-64.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-file-delete-64.png");
            this.ımageList1.Images.SetKeyName(4, "icons8-save-close-64.png");
            this.ımageList1.Images.SetKeyName(5, "icons8-exit-48.png");
            this.ımageList1.Images.SetKeyName(6, "icons8-add-file-64.png");
            // 
            // GroupMenu
            // 
            this.GroupMenu.Controls.Add(this.btnYaddaSaxla);
            this.GroupMenu.Controls.Add(this.btnBagla);
            this.GroupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupMenu.Location = new System.Drawing.Point(0, 544);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Size = new System.Drawing.Size(641, 103);
            this.GroupMenu.TabIndex = 3;
            this.GroupMenu.Text = "Menu";
            // 
            // btnYaddaSaxla
            // 
            this.btnYaddaSaxla.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaddaSaxla.Appearance.Options.UseFont = true;
            this.btnYaddaSaxla.ImageOptions.ImageIndex = 6;
            this.btnYaddaSaxla.ImageOptions.ImageList = this.ımageList1;
            this.btnYaddaSaxla.Location = new System.Drawing.Point(329, 37);
            this.btnYaddaSaxla.Name = "btnYaddaSaxla";
            this.btnYaddaSaxla.Size = new System.Drawing.Size(147, 54);
            this.btnYaddaSaxla.TabIndex = 1;
            this.btnYaddaSaxla.Text = "Yadda Saxla";
            this.btnYaddaSaxla.Click += new System.EventHandler(this.btnYaddaSaxla_Click);
            // 
            // btnBagla
            // 
            this.btnBagla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBagla.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBagla.Appearance.Options.UseFont = true;
            this.btnBagla.ImageOptions.ImageIndex = 5;
            this.btnBagla.ImageOptions.ImageList = this.ımageList1;
            this.btnBagla.Location = new System.Drawing.Point(482, 37);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(147, 54);
            this.btnBagla.TabIndex = 0;
            this.btnBagla.Text = "Bagla";
            this.btnBagla.Click += new System.EventHandler(this.btnBagla_Click);
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabMuellifMelumat);
            this.tabPane1.Controls.Add(this.tabMuellifKitab);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 36);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabMuellifMelumat,
            this.tabMuellifKitab});
            this.tabPane1.RegularSize = new System.Drawing.Size(641, 508);
            this.tabPane1.SelectedPage = this.tabMuellifMelumat;
            this.tabPane1.Size = new System.Drawing.Size(641, 508);
            this.tabPane1.TabIndex = 4;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabMuellifMelumat
            // 
            this.tabMuellifMelumat.Caption = "Müəllif Məlumat";
            this.tabMuellifMelumat.Controls.Add(this.txtMuellifAdi);
            this.tabMuellifMelumat.Controls.Add(this.txtMuellifAciqlama);
            this.tabMuellifMelumat.Controls.Add(this.txtMlfDogumTarixi);
            this.tabMuellifMelumat.Controls.Add(this.txtMlfSoyadi);
            this.tabMuellifMelumat.Controls.Add(this.labelControl15);
            this.tabMuellifMelumat.Controls.Add(this.labelControl13);
            this.tabMuellifMelumat.Controls.Add(this.labelControl3);
            this.tabMuellifMelumat.Controls.Add(this.labelControl12);
            this.tabMuellifMelumat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabMuellifMelumat.ImageOptions.Image")));
            this.tabMuellifMelumat.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabMuellifMelumat.Name = "tabMuellifMelumat";
            this.tabMuellifMelumat.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabMuellifMelumat.Size = new System.Drawing.Size(641, 468);
            // 
            // tabMuellifKitab
            // 
            this.tabMuellifKitab.Caption = "Müəllif Kitabları";
            this.tabMuellifKitab.Controls.Add(this.gridControlMuellifKitab);
            this.tabMuellifKitab.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabMuellifKitab.ImageOptions.Image")));
            this.tabMuellifKitab.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabMuellifKitab.Name = "tabMuellifKitab";
            this.tabMuellifKitab.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabMuellifKitab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMuellifKitab.Size = new System.Drawing.Size(641, 468);
            // 
            // txtMuellifAciqlama
            // 
            this.txtMuellifAciqlama.Location = new System.Drawing.Point(140, 126);
            this.txtMuellifAciqlama.Name = "txtMuellifAciqlama";
            this.txtMuellifAciqlama.Size = new System.Drawing.Size(469, 110);
            this.txtMuellifAciqlama.TabIndex = 11;
            // 
            // txtMlfDogumTarixi
            // 
            this.txtMlfDogumTarixi.Location = new System.Drawing.Point(140, 92);
            this.txtMlfDogumTarixi.Name = "txtMlfDogumTarixi";
            this.txtMlfDogumTarixi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMlfDogumTarixi.Properties.Appearance.Options.UseFont = true;
            this.txtMlfDogumTarixi.Size = new System.Drawing.Size(173, 28);
            this.txtMlfDogumTarixi.TabIndex = 9;
            // 
            // txtMlfSoyadi
            // 
            this.txtMlfSoyadi.Location = new System.Drawing.Point(140, 54);
            this.txtMlfSoyadi.Name = "txtMlfSoyadi";
            this.txtMlfSoyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMlfSoyadi.Properties.Appearance.Options.UseFont = true;
            this.txtMlfSoyadi.Size = new System.Drawing.Size(173, 28);
            this.txtMlfSoyadi.TabIndex = 10;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl15.Location = new System.Drawing.Point(0, 95);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(137, 25);
            this.labelControl15.TabIndex = 5;
            this.labelControl15.Text = "Doğum Tarixi:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl13.Location = new System.Drawing.Point(0, 55);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(137, 25);
            this.labelControl13.TabIndex = 6;
            this.labelControl13.Text = "Soyadı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(0, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(137, 32);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Adı:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl12.Location = new System.Drawing.Point(0, 126);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(137, 110);
            this.labelControl12.TabIndex = 8;
            this.labelControl12.Text = "Açıqlama:";
            // 
            // txtMuellifAdi
            // 
            this.txtMuellifAdi.Location = new System.Drawing.Point(140, 14);
            this.txtMuellifAdi.Name = "txtMuellifAdi";
            this.txtMuellifAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMuellifAdi.Properties.Appearance.Options.UseFont = true;
            this.txtMuellifAdi.Size = new System.Drawing.Size(173, 28);
            this.txtMuellifAdi.TabIndex = 12;
            // 
            // gridControlMuellifKitab
            // 
            this.gridControlMuellifKitab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMuellifKitab.Location = new System.Drawing.Point(0, 0);
            this.gridControlMuellifKitab.MainView = this.layoutKitab;
            this.gridControlMuellifKitab.Name = "gridControlMuellifKitab";
            this.gridControlMuellifKitab.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRatingControl2});
            this.gridControlMuellifKitab.Size = new System.Drawing.Size(641, 468);
            this.gridControlMuellifKitab.TabIndex = 4;
            this.gridControlMuellifKitab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutKitab});
            // 
            // layoutKitab
            // 
            this.layoutKitab.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colKitabKodu,
            this.colKitabAdi,
            this.colKitabNovu,
            this.colKitabISBN,
            this.colNesriyyat});
            this.layoutKitab.GridControl = this.gridControlMuellifKitab;
            this.layoutKitab.Name = "layoutKitab";
            this.layoutKitab.TemplateCard = this.layoutViewCard2;
            // 
            // colKitabKodu
            // 
            this.colKitabKodu.Caption = "Kitab Kodu";
            this.colKitabKodu.FieldName = "KitabKodu";
            this.colKitabKodu.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.colKitabKodu.MinWidth = 25;
            this.colKitabKodu.Name = "colKitabKodu";
            this.colKitabKodu.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(134, 24);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(77, 16);
            // 
            // colKitabAdi
            // 
            this.colKitabAdi.Caption = "Kitab Adi";
            this.colKitabAdi.FieldName = "KitabAdi";
            this.colKitabAdi.LayoutViewField = this.layoutViewField_layoutViewColumn1_1;
            this.colKitabAdi.MinWidth = 25;
            this.colKitabAdi.Name = "colKitabAdi";
            this.colKitabAdi.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            this.layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            this.layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size(134, 24);
            this.layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size(77, 16);
            // 
            // colKitabNovu
            // 
            this.colKitabNovu.Caption = "Kitab Novu";
            this.colKitabNovu.FieldName = "Kategory";
            this.colKitabNovu.LayoutViewField = this.layoutViewField_layoutViewColumn1_2;
            this.colKitabNovu.MinWidth = 25;
            this.colKitabNovu.Name = "colKitabNovu";
            this.colKitabNovu.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_2
            // 
            this.layoutViewField_layoutViewColumn1_2.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1_2.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_layoutViewColumn1_2.Name = "layoutViewField_layoutViewColumn1_2";
            this.layoutViewField_layoutViewColumn1_2.Size = new System.Drawing.Size(134, 24);
            this.layoutViewField_layoutViewColumn1_2.TextSize = new System.Drawing.Size(77, 16);
            // 
            // colKitabISBN
            // 
            this.colKitabISBN.Caption = "Kitab ISBN";
            this.colKitabISBN.FieldName = "ISBN";
            this.colKitabISBN.LayoutViewField = this.layoutViewField_layoutViewColumn1_3;
            this.colKitabISBN.MinWidth = 25;
            this.colKitabISBN.Name = "colKitabISBN";
            this.colKitabISBN.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_3
            // 
            this.layoutViewField_layoutViewColumn1_3.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1_3.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_layoutViewColumn1_3.Name = "layoutViewField_layoutViewColumn1_3";
            this.layoutViewField_layoutViewColumn1_3.Size = new System.Drawing.Size(134, 24);
            this.layoutViewField_layoutViewColumn1_3.TextSize = new System.Drawing.Size(77, 16);
            // 
            // colNesriyyat
            // 
            this.colNesriyyat.Caption = "Nesriyyat Evi";
            this.colNesriyyat.FieldName = "Nesriyyat";
            this.colNesriyyat.LayoutViewField = this.layoutViewField_layoutViewColumn1_4;
            this.colNesriyyat.MinWidth = 25;
            this.colNesriyyat.Name = "colNesriyyat";
            this.colNesriyyat.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1_4
            // 
            this.layoutViewField_layoutViewColumn1_4.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1_4.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_layoutViewColumn1_4.Name = "layoutViewField_layoutViewColumn1_4";
            this.layoutViewField_layoutViewColumn1_4.Size = new System.Drawing.Size(134, 24);
            this.layoutViewField_layoutViewColumn1_4.TextSize = new System.Drawing.Size(77, 16);
            // 
            // layoutViewCard2
            // 
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn1_1,
            this.layoutViewField_layoutViewColumn1_2,
            this.layoutViewField_layoutViewColumn1_3,
            this.layoutViewField_layoutViewColumn1_4});
            this.layoutViewCard2.Name = "layoutViewCard1";
            // 
            // repositoryItemRatingControl2
            // 
            this.repositoryItemRatingControl2.AutoHeight = false;
            this.repositoryItemRatingControl2.Name = "repositoryItemRatingControl2";
            // 
            // FrmMuellifIsler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 647);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.GroupMenu);
            this.Controls.Add(this.Kitablar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMuellifIsler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müəllif Əməliyyatları";
            ((System.ComponentModel.ISupportInitialize)(this.GroupMenu)).EndInit();
            this.GroupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabMuellifMelumat.ResumeLayout(false);
            this.tabMuellifKitab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMuellifAciqlama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMlfDogumTarixi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMlfSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMuellifAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMuellifKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Kitablar;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl GroupMenu;
        private DevExpress.XtraEditors.SimpleButton btnYaddaSaxla;
        private DevExpress.XtraEditors.SimpleButton btnBagla;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabMuellifMelumat;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabMuellifKitab;
        private DevExpress.XtraEditors.TextEdit txtMuellifAdi;
        private DevExpress.XtraEditors.MemoEdit txtMuellifAciqlama;
        private DevExpress.XtraEditors.TextEdit txtMlfDogumTarixi;
        private DevExpress.XtraEditors.TextEdit txtMlfSoyadi;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraGrid.GridControl gridControlMuellifKitab;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutKitab;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKitabKodu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKitabAdi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKitabNovu;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colKitabISBN;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colNesriyyat;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl2;
    }
}