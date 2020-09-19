namespace Kitabxana.UI.Istifadeci
{
    partial class FrmIstifadeciSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIstifadeciSec));
            this.lblBasliq = new DevExpress.XtraEditors.LabelControl();
            this.GroupMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnBagla = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlIstifadeci = new DevExpress.XtraGrid.GridControl();
            this.gridIstifadeci = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colasd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GroupMenu)).BeginInit();
            this.GroupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIstifadeci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstifadeci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBasliq
            // 
            this.lblBasliq.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblBasliq.Appearance.Options.UseFont = true;
            this.lblBasliq.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBasliq.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBasliq.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblBasliq.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBasliq.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblBasliq.ImageOptions.SvgImage")));
            this.lblBasliq.Location = new System.Drawing.Point(0, 0);
            this.lblBasliq.Margin = new System.Windows.Forms.Padding(10);
            this.lblBasliq.Name = "lblBasliq";
            this.lblBasliq.Size = new System.Drawing.Size(768, 63);
            this.lblBasliq.TabIndex = 4;
            this.lblBasliq.Text = "Zəhmət Olmasa İstifadəçi Seçin";
            // 
            // GroupMenu
            // 
            this.GroupMenu.Controls.Add(this.btnGeri);
            this.GroupMenu.Controls.Add(this.btnSec);
            this.GroupMenu.Controls.Add(this.btnBagla);
            this.GroupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupMenu.Location = new System.Drawing.Point(0, 597);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Size = new System.Drawing.Size(768, 100);
            this.GroupMenu.TabIndex = 5;
            this.GroupMenu.Text = "Menu";
            // 
            // btnGeri
            // 
            this.btnGeri.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Appearance.Options.UseFont = true;
            this.btnGeri.ImageOptions.ImageIndex = 6;
            this.btnGeri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btnGeri.Location = new System.Drawing.Point(315, 34);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(135, 54);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            // 
            // btnSec
            // 
            this.btnSec.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Appearance.Options.UseFont = true;
            this.btnSec.ImageOptions.ImageIndex = 6;
            this.btnSec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnSec.Location = new System.Drawing.Point(470, 34);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(135, 54);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
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
            // gridControlIstifadeci
            // 
            this.gridControlIstifadeci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIstifadeci.Location = new System.Drawing.Point(0, 63);
            this.gridControlIstifadeci.MainView = this.gridIstifadeci;
            this.gridControlIstifadeci.Name = "gridControlIstifadeci";
            this.gridControlIstifadeci.Size = new System.Drawing.Size(768, 534);
            this.gridControlIstifadeci.TabIndex = 6;
            this.gridControlIstifadeci.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridIstifadeci});
            // 
            // gridIstifadeci
            // 
            this.gridIstifadeci.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridIstifadeci.GridControl = this.gridControlIstifadeci;
            this.gridIstifadeci.Name = "gridIstifadeci";
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
            // FrmIstifadeciSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 697);
            this.Controls.Add(this.gridControlIstifadeci);
            this.Controls.Add(this.GroupMenu);
            this.Controls.Add(this.lblBasliq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIstifadeciSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIstifadeciSec";
            ((System.ComponentModel.ISupportInitialize)(this.GroupMenu)).EndInit();
            this.GroupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIstifadeci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIstifadeci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBasliq;
        private DevExpress.XtraEditors.GroupControl GroupMenu;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnBagla;
        private DevExpress.XtraGrid.GridControl gridControlIstifadeci;
        private DevExpress.XtraGrid.Views.Grid.GridView gridIstifadeci;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
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