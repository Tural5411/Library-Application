namespace Kitabxana.UI.Istifadeci
{
    partial class FrmIstifadeci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIstifadeci));
            this.gridControlKitab = new DevExpress.XtraGrid.GridControl();
            this.gridKitab = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeziyyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexsiyyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMekteb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSektor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciqlama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBagla = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Kitablar = new DevExpress.XtraEditors.LabelControl();
            this.colasd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlKitab
            // 
            this.gridControlKitab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitab.Location = new System.Drawing.Point(0, 53);
            this.gridControlKitab.MainView = this.gridKitab;
            this.gridControlKitab.Name = "gridControlKitab";
            this.gridControlKitab.Size = new System.Drawing.Size(1040, 496);
            this.gridControlKitab.TabIndex = 5;
            this.gridControlKitab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitab});
            // 
            // gridKitab
            // 
            this.gridKitab.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colVeziyyet,
            this.colSexsiyyet,
            this.colMekteb,
            this.colAdi,
            this.colBarkod,
            this.colSoyadi,
            this.colSektor,
            this.colTarix,
            this.colAciqlama,
            this.colasd});
            this.gridKitab.GridControl = this.gridControlKitab;
            this.gridKitab.Name = "gridKitab";
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
            // colVeziyyet
            // 
            this.colVeziyyet.Caption = "Vəziyyət";
            this.colVeziyyet.FieldName = "Veziyyet";
            this.colVeziyyet.MinWidth = 25;
            this.colVeziyyet.Name = "colVeziyyet";
            this.colVeziyyet.Visible = true;
            this.colVeziyyet.VisibleIndex = 0;
            this.colVeziyyet.Width = 94;
            // 
            // colSexsiyyet
            // 
            this.colSexsiyyet.Caption = "Şəxsiyyət N";
            this.colSexsiyyet.FieldName = "SexsiyyetNo";
            this.colSexsiyyet.MinWidth = 25;
            this.colSexsiyyet.Name = "colSexsiyyet";
            this.colSexsiyyet.Visible = true;
            this.colSexsiyyet.VisibleIndex = 1;
            this.colSexsiyyet.Width = 94;
            // 
            // colMekteb
            // 
            this.colMekteb.Caption = "Məktəb N";
            this.colMekteb.FieldName = "MektebNo";
            this.colMekteb.MinWidth = 25;
            this.colMekteb.Name = "colMekteb";
            this.colMekteb.Visible = true;
            this.colMekteb.VisibleIndex = 2;
            this.colMekteb.Width = 94;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 4;
            this.colAdi.Width = 94;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "Barkod";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.MinWidth = 25;
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 3;
            this.colBarkod.Width = 94;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.MinWidth = 25;
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 5;
            this.colSoyadi.Width = 94;
            // 
            // colSektor
            // 
            this.colSektor.Caption = "Sektor";
            this.colSektor.FieldName = "Sektor";
            this.colSektor.MinWidth = 25;
            this.colSektor.Name = "colSektor";
            this.colSektor.Visible = true;
            this.colSektor.VisibleIndex = 6;
            this.colSektor.Width = 94;
            // 
            // colTarix
            // 
            this.colTarix.Caption = "Tarix";
            this.colTarix.FieldName = "QeydiyyatTarixi";
            this.colTarix.MinWidth = 25;
            this.colTarix.Name = "colTarix";
            this.colTarix.Visible = true;
            this.colTarix.VisibleIndex = 7;
            this.colTarix.Width = 94;
            // 
            // colAciqlama
            // 
            this.colAciqlama.Caption = "Açıqlama";
            this.colAciqlama.FieldName = "Aciqlama";
            this.colAciqlama.MinWidth = 25;
            this.colAciqlama.Name = "colAciqlama";
            this.colAciqlama.Visible = true;
            this.colAciqlama.VisibleIndex = 8;
            this.colAciqlama.Width = 94;
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
            this.GroupControl1.TabIndex = 4;
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
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(316, 26);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(152, 74);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "SİL";
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
            this.Kitablar.Size = new System.Drawing.Size(1040, 53);
            this.Kitablar.TabIndex = 3;
            this.Kitablar.Text = "İstifadəçilər";
            // 
            // colasd
            // 
            this.colasd.Caption = "Sektor";
            this.colasd.FieldName = "Sinif.Sektor";
            this.colasd.MinWidth = 25;
            this.colasd.Name = "colasd";
            this.colasd.Visible = true;
            this.colasd.VisibleIndex = 9;
            this.colasd.Width = 94;
            // 
            // FrmIstifadeci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 649);
            this.Controls.Add(this.gridControlKitab);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.Kitablar);
            this.Name = "FrmIstifadeci";
            this.Text = "İstifadəçi List";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKitab;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKitab;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private DevExpress.XtraEditors.SimpleButton btnBagla;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl Kitablar;
        private DevExpress.XtraGrid.Columns.GridColumn colVeziyyet;
        private DevExpress.XtraGrid.Columns.GridColumn colSexsiyyet;
        private DevExpress.XtraGrid.Columns.GridColumn colMekteb;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colSektor;
        private DevExpress.XtraGrid.Columns.GridColumn colTarix;
        private DevExpress.XtraGrid.Columns.GridColumn colAciqlama;
        private DevExpress.XtraGrid.Columns.GridColumn colasd;
    }
}