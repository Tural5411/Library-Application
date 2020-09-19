namespace Kitabxana.UI.KitabHereket
{
    partial class FrmKitabHereket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitabHereket));
            this.gridControlKitabHereket = new DevExpress.XtraGrid.GridControl();
            this.gridKitabHereket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitabId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIstifadeciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilmeTarixi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerilmeMuddeti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimTarixi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHereketAciqlama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitabKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitabAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimEdilmeVaxti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIstifadeciSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIstfAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIstifadeciBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMektebNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNeceGunGecikdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVeziyyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKitabBarkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeslimOldumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBagla = new DevExpress.XtraEditors.SimpleButton();
            this.btnIstifadeciYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnIstifadeciSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnIstifadeciElave = new DevExpress.XtraEditors.SimpleButton();
            this.Kitablar = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitabHereket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitabHereket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlKitabHereket
            // 
            this.gridControlKitabHereket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKitabHereket.Location = new System.Drawing.Point(0, 53);
            this.gridControlKitabHereket.MainView = this.gridKitabHereket;
            this.gridControlKitabHereket.Name = "gridControlKitabHereket";
            this.gridControlKitabHereket.Size = new System.Drawing.Size(1329, 593);
            this.gridControlKitabHereket.TabIndex = 10;
            this.gridControlKitabHereket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKitabHereket});
            // 
            // gridKitabHereket
            // 
            this.gridKitabHereket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKitabId,
            this.colIstifadeciId,
            this.colVerilmeTarixi,
            this.colVerilmeMuddeti,
            this.colTeslimTarixi,
            this.colHereketAciqlama,
            this.colKitabKodu,
            this.colKitabAdi,
            this.colTeslimEdilmeVaxti,
            this.colIstifadeciSoyadi,
            this.colIstfAdi,
            this.colIstifadeciBarkod,
            this.colMektebNo,
            this.colNeceGunGecikdi,
            this.colVeziyyet,
            this.colKitabBarkodu,
            this.colTeslimOldumu});
            this.gridKitabHereket.GridControl = this.gridControlKitabHereket;
            this.gridKitabHereket.Name = "gridKitabHereket";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Width = 94;
            // 
            // colKitabId
            // 
            this.colKitabId.Caption = "Kitab Id";
            this.colKitabId.FieldName = "KitabId";
            this.colKitabId.MinWidth = 25;
            this.colKitabId.Name = "colKitabId";
            this.colKitabId.OptionsColumn.AllowEdit = false;
            this.colKitabId.Width = 94;
            // 
            // colIstifadeciId
            // 
            this.colIstifadeciId.Caption = "Istifadeci Id";
            this.colIstifadeciId.FieldName = "IstifadeciId";
            this.colIstifadeciId.MinWidth = 25;
            this.colIstifadeciId.Name = "colIstifadeciId";
            this.colIstifadeciId.OptionsColumn.AllowEdit = false;
            this.colIstifadeciId.Width = 94;
            // 
            // colVerilmeTarixi
            // 
            this.colVerilmeTarixi.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colVerilmeTarixi.AppearanceCell.Options.UseBackColor = true;
            this.colVerilmeTarixi.Caption = "Verilme Tarixi";
            this.colVerilmeTarixi.FieldName = "VerilmeTarixi";
            this.colVerilmeTarixi.MinWidth = 25;
            this.colVerilmeTarixi.Name = "colVerilmeTarixi";
            this.colVerilmeTarixi.OptionsColumn.AllowEdit = false;
            this.colVerilmeTarixi.Visible = true;
            this.colVerilmeTarixi.VisibleIndex = 8;
            this.colVerilmeTarixi.Width = 90;
            // 
            // colVerilmeMuddeti
            // 
            this.colVerilmeMuddeti.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colVerilmeMuddeti.AppearanceCell.Options.UseBackColor = true;
            this.colVerilmeMuddeti.Caption = "Verilme Muddeti";
            this.colVerilmeMuddeti.FieldName = "VerilmeMuddeti";
            this.colVerilmeMuddeti.MinWidth = 25;
            this.colVerilmeMuddeti.Name = "colVerilmeMuddeti";
            this.colVerilmeMuddeti.OptionsColumn.AllowEdit = false;
            this.colVerilmeMuddeti.Visible = true;
            this.colVerilmeMuddeti.VisibleIndex = 9;
            this.colVerilmeMuddeti.Width = 90;
            // 
            // colTeslimTarixi
            // 
            this.colTeslimTarixi.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colTeslimTarixi.AppearanceCell.Options.UseBackColor = true;
            this.colTeslimTarixi.Caption = "Teslim Tarixi";
            this.colTeslimTarixi.FieldName = "TeslimTarixi";
            this.colTeslimTarixi.MinWidth = 25;
            this.colTeslimTarixi.Name = "colTeslimTarixi";
            this.colTeslimTarixi.OptionsColumn.AllowEdit = false;
            this.colTeslimTarixi.Visible = true;
            this.colTeslimTarixi.VisibleIndex = 10;
            this.colTeslimTarixi.Width = 90;
            // 
            // colHereketAciqlama
            // 
            this.colHereketAciqlama.Caption = "Aciqlama";
            this.colHereketAciqlama.FieldName = "Aciqlama";
            this.colHereketAciqlama.MinWidth = 25;
            this.colHereketAciqlama.Name = "colHereketAciqlama";
            this.colHereketAciqlama.OptionsColumn.AllowEdit = false;
            this.colHereketAciqlama.Visible = true;
            this.colHereketAciqlama.VisibleIndex = 12;
            this.colHereketAciqlama.Width = 123;
            // 
            // colKitabKodu
            // 
            this.colKitabKodu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colKitabKodu.AppearanceCell.Options.UseBackColor = true;
            this.colKitabKodu.Caption = "Kitab Kodu";
            this.colKitabKodu.FieldName = "Kitab.KitabKodu";
            this.colKitabKodu.MinWidth = 25;
            this.colKitabKodu.Name = "colKitabKodu";
            this.colKitabKodu.OptionsColumn.AllowEdit = false;
            this.colKitabKodu.Visible = true;
            this.colKitabKodu.VisibleIndex = 1;
            this.colKitabKodu.Width = 93;
            // 
            // colKitabAdi
            // 
            this.colKitabAdi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colKitabAdi.AppearanceCell.Options.UseBackColor = true;
            this.colKitabAdi.Caption = "Kitab adi";
            this.colKitabAdi.FieldName = "Kitab.KitabAdi";
            this.colKitabAdi.MinWidth = 25;
            this.colKitabAdi.Name = "colKitabAdi";
            this.colKitabAdi.OptionsColumn.AllowEdit = false;
            this.colKitabAdi.Visible = true;
            this.colKitabAdi.VisibleIndex = 3;
            this.colKitabAdi.Width = 139;
            // 
            // colTeslimEdilmeVaxti
            // 
            this.colTeslimEdilmeVaxti.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colTeslimEdilmeVaxti.AppearanceCell.Options.UseBackColor = true;
            this.colTeslimEdilmeVaxti.Caption = "Teslim edilmesi lazim olan tarix";
            this.colTeslimEdilmeVaxti.FieldName = "colTeslimEdilmeVaxti";
            this.colTeslimEdilmeVaxti.MinWidth = 25;
            this.colTeslimEdilmeVaxti.Name = "colTeslimEdilmeVaxti";
            this.colTeslimEdilmeVaxti.OptionsColumn.AllowEdit = false;
            this.colTeslimEdilmeVaxti.UnboundExpression = "AddDays([VerilmeTarixi], [VerilmeMuddeti])";
            this.colTeslimEdilmeVaxti.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colTeslimEdilmeVaxti.Visible = true;
            this.colTeslimEdilmeVaxti.VisibleIndex = 11;
            this.colTeslimEdilmeVaxti.Width = 100;
            // 
            // colIstifadeciSoyadi
            // 
            this.colIstifadeciSoyadi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colIstifadeciSoyadi.AppearanceCell.Options.UseBackColor = true;
            this.colIstifadeciSoyadi.Caption = "Istifadeci Soyadi";
            this.colIstifadeciSoyadi.FieldName = "Istifadeci.Soyadi";
            this.colIstifadeciSoyadi.MinWidth = 25;
            this.colIstifadeciSoyadi.Name = "colIstifadeciSoyadi";
            this.colIstifadeciSoyadi.OptionsColumn.AllowEdit = false;
            this.colIstifadeciSoyadi.Visible = true;
            this.colIstifadeciSoyadi.VisibleIndex = 6;
            this.colIstifadeciSoyadi.Width = 101;
            // 
            // colIstfAdi
            // 
            this.colIstfAdi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colIstfAdi.AppearanceCell.Options.UseBackColor = true;
            this.colIstfAdi.Caption = "Istifadeci Adi";
            this.colIstfAdi.FieldName = "Istifadeci.Adi";
            this.colIstfAdi.MinWidth = 25;
            this.colIstfAdi.Name = "colIstfAdi";
            this.colIstfAdi.OptionsColumn.AllowEdit = false;
            this.colIstfAdi.Visible = true;
            this.colIstfAdi.VisibleIndex = 5;
            this.colIstfAdi.Width = 91;
            // 
            // colIstifadeciBarkod
            // 
            this.colIstifadeciBarkod.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colIstifadeciBarkod.AppearanceCell.Options.UseBackColor = true;
            this.colIstifadeciBarkod.Caption = "Istfd Barkod";
            this.colIstifadeciBarkod.FieldName = "Istifadeci.Barkod";
            this.colIstifadeciBarkod.MinWidth = 25;
            this.colIstifadeciBarkod.Name = "colIstifadeciBarkod";
            this.colIstifadeciBarkod.OptionsColumn.AllowEdit = false;
            this.colIstifadeciBarkod.Visible = true;
            this.colIstifadeciBarkod.VisibleIndex = 4;
            this.colIstifadeciBarkod.Width = 87;
            // 
            // colMektebNo
            // 
            this.colMektebNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colMektebNo.AppearanceCell.Options.UseBackColor = true;
            this.colMektebNo.Caption = "Mekteb No";
            this.colMektebNo.FieldName = "Istifadeci.MektebNo";
            this.colMektebNo.MinWidth = 25;
            this.colMektebNo.Name = "colMektebNo";
            this.colMektebNo.OptionsColumn.AllowEdit = false;
            this.colMektebNo.Visible = true;
            this.colMektebNo.VisibleIndex = 7;
            this.colMektebNo.Width = 64;
            // 
            // colNeceGunGecikdi
            // 
            this.colNeceGunGecikdi.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colNeceGunGecikdi.AppearanceCell.Options.UseBackColor = true;
            this.colNeceGunGecikdi.Caption = "Gecikme";
            this.colNeceGunGecikdi.FieldName = "colNeceGunGecikdi";
            this.colNeceGunGecikdi.MinWidth = 25;
            this.colNeceGunGecikdi.Name = "colNeceGunGecikdi";
            this.colNeceGunGecikdi.OptionsColumn.AllowEdit = false;
            this.colNeceGunGecikdi.UnboundExpression = "DateDiffDay([colTeslimEdilmeVaxti], Today())";
            this.colNeceGunGecikdi.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNeceGunGecikdi.Width = 79;
            // 
            // colVeziyyet
            // 
            this.colVeziyyet.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colVeziyyet.AppearanceCell.Options.UseBackColor = true;
            this.colVeziyyet.Caption = "Veziyyet";
            this.colVeziyyet.FieldName = "colVeziyyet";
            this.colVeziyyet.MinWidth = 25;
            this.colVeziyyet.Name = "colVeziyyet";
            this.colVeziyyet.OptionsColumn.AllowEdit = false;
            this.colVeziyyet.UnboundExpression = resources.GetString("colVeziyyet.UnboundExpression");
            this.colVeziyyet.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colVeziyyet.Visible = true;
            this.colVeziyyet.VisibleIndex = 0;
            this.colVeziyyet.Width = 89;
            // 
            // colKitabBarkodu
            // 
            this.colKitabBarkodu.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.colKitabBarkodu.AppearanceCell.Options.UseBackColor = true;
            this.colKitabBarkodu.Caption = "Kitab Barkod";
            this.colKitabBarkodu.FieldName = "Barkod.Barkodu";
            this.colKitabBarkodu.MinWidth = 25;
            this.colKitabBarkodu.Name = "colKitabBarkodu";
            this.colKitabBarkodu.OptionsColumn.AllowEdit = false;
            this.colKitabBarkodu.Visible = true;
            this.colKitabBarkodu.VisibleIndex = 2;
            this.colKitabBarkodu.Width = 120;
            // 
            // colTeslimOldumu
            // 
            this.colTeslimOldumu.Caption = "Teslim oldumu";
            this.colTeslimOldumu.FieldName = "TeslimEdildi";
            this.colTeslimOldumu.MinWidth = 25;
            this.colTeslimOldumu.Name = "colTeslimOldumu";
            this.colTeslimOldumu.OptionsColumn.AllowEdit = false;
            this.colTeslimOldumu.Width = 94;
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.btnBagla);
            this.GroupControl1.Controls.Add(this.btnIstifadeciYenile);
            this.GroupControl1.Controls.Add(this.btnIstifadeciSil);
            this.GroupControl1.Controls.Add(this.btnIstifadeciElave);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupControl1.Location = new System.Drawing.Point(0, 646);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(1329, 100);
            this.GroupControl1.TabIndex = 9;
            this.GroupControl1.Text = "Menu";
            // 
            // btnBagla
            // 
            this.btnBagla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBagla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBagla.ImageOptions.Image")));
            this.btnBagla.Location = new System.Drawing.Point(1177, 26);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(152, 74);
            this.btnBagla.TabIndex = 2;
            this.btnBagla.Text = "BAĞLA";
            // 
            // btnIstifadeciYenile
            // 
            this.btnIstifadeciYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIstifadeciYenile.ImageOptions.Image")));
            this.btnIstifadeciYenile.Location = new System.Drawing.Point(158, 26);
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
            // 
            // btnIstifadeciElave
            // 
            this.btnIstifadeciElave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIstifadeciElave.ImageOptions.Image")));
            this.btnIstifadeciElave.Location = new System.Drawing.Point(0, 26);
            this.btnIstifadeciElave.Name = "btnIstifadeciElave";
            this.btnIstifadeciElave.Size = new System.Drawing.Size(152, 74);
            this.btnIstifadeciElave.TabIndex = 0;
            this.btnIstifadeciElave.Text = "Təslim\r\nVəziyyətini\r\nDəyişdir";
            this.btnIstifadeciElave.Click += new System.EventHandler(this.btnIstifadeciElave_Click);
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
            this.Kitablar.Size = new System.Drawing.Size(1329, 53);
            this.Kitablar.TabIndex = 8;
            this.Kitablar.Text = "Kitab Hereketleri";
            // 
            // FrmKitabHereket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 746);
            this.Controls.Add(this.gridControlKitabHereket);
            this.Controls.Add(this.GroupControl1);
            this.Controls.Add(this.Kitablar);
            this.Name = "FrmKitabHereket";
            this.Text = "Kitab Hereket";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKitabHereket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKitabHereket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKitabHereket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKitabHereket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKitabId;
        private DevExpress.XtraGrid.Columns.GridColumn colIstifadeciId;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilmeTarixi;
        private DevExpress.XtraGrid.Columns.GridColumn colVerilmeMuddeti;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimTarixi;
        private DevExpress.XtraGrid.Columns.GridColumn colHereketAciqlama;
        private DevExpress.XtraGrid.Columns.GridColumn colKitabKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colKitabAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimEdilmeVaxti;
        private DevExpress.XtraGrid.Columns.GridColumn colIstifadeciSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colIstfAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIstifadeciBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colMektebNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNeceGunGecikdi;
        private DevExpress.XtraGrid.Columns.GridColumn colVeziyyet;
        private DevExpress.XtraGrid.Columns.GridColumn colKitabBarkodu;
        private DevExpress.XtraEditors.GroupControl GroupControl1;
        private DevExpress.XtraEditors.SimpleButton btnBagla;
        private DevExpress.XtraEditors.SimpleButton btnIstifadeciYenile;
        private DevExpress.XtraEditors.SimpleButton btnIstifadeciSil;
        private DevExpress.XtraEditors.SimpleButton btnIstifadeciElave;
        private DevExpress.XtraEditors.LabelControl Kitablar;
        private DevExpress.XtraGrid.Columns.GridColumn colTeslimOldumu;
    }
}