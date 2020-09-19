namespace Kitabxana.UI.Base
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.Kitablar = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTerifAciqlama = new DevExpress.XtraEditors.MemoEdit();
            this.labelzirt = new DevExpress.XtraEditors.LabelControl();
            this.txtTerif = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnImtina = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnElave = new DevExpress.XtraEditors.SimpleButton();
            this.btnYaddaSaxla = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciqlama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTerifAciqlama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTerif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            this.Kitablar.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.Kitablar.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kitablar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Kitablar.ImageOptions.Image")));
            this.Kitablar.Location = new System.Drawing.Point(0, 0);
            this.Kitablar.Margin = new System.Windows.Forms.Padding(10);
            this.Kitablar.Name = "Kitablar";
            this.Kitablar.Size = new System.Drawing.Size(635, 30);
            this.Kitablar.TabIndex = 2;
            this.Kitablar.Text = "Tərif Əməliyyatları";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTerifAciqlama);
            this.groupControl1.Controls.Add(this.labelzirt);
            this.groupControl1.Controls.Add(this.txtTerif);
            this.groupControl1.Controls.Add(this.labelControl18);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(635, 172);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Tərif Məlumatları";
            this.groupControl1.Visible = false;
            // 
            // txtTerifAciqlama
            // 
            this.txtTerifAciqlama.Location = new System.Drawing.Point(119, 72);
            this.txtTerifAciqlama.Name = "txtTerifAciqlama";
            this.txtTerifAciqlama.Size = new System.Drawing.Size(511, 64);
            this.txtTerifAciqlama.TabIndex = 7;
            // 
            // labelzirt
            // 
            this.labelzirt.Appearance.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelzirt.Appearance.Options.UseFont = true;
            this.labelzirt.Appearance.Options.UseTextOptions = true;
            this.labelzirt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelzirt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelzirt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelzirt.Location = new System.Drawing.Point(0, 35);
            this.labelzirt.Name = "labelzirt";
            this.labelzirt.Size = new System.Drawing.Size(113, 31);
            this.labelzirt.TabIndex = 5;
            this.labelzirt.Text = "Terif:";
            // 
            // txtTerif
            // 
            this.txtTerif.Location = new System.Drawing.Point(119, 40);
            this.txtTerif.Name = "txtTerif";
            this.txtTerif.Size = new System.Drawing.Size(511, 22);
            this.txtTerif.TabIndex = 6;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseTextOptions = true;
            this.labelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl18.Location = new System.Drawing.Point(-16, 72);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(129, 64);
            this.labelControl18.TabIndex = 4;
            this.labelControl18.Text = "Açıqlama:";
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnImtina);
            this.groupControl2.Controls.Add(this.btnSec);
            this.groupControl2.Controls.Add(this.btnElave);
            this.groupControl2.Controls.Add(this.btnYaddaSaxla);
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 202);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(635, 71);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Əməliyyatlar";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // btnImtina
            // 
            this.btnImtina.ImageOptions.ImageIndex = 3;
            this.btnImtina.ImageOptions.ImageList = this.ımageList1;
            this.btnImtina.Location = new System.Drawing.Point(413, 31);
            this.btnImtina.Name = "btnImtina";
            this.btnImtina.Size = new System.Drawing.Size(96, 35);
            this.btnImtina.TabIndex = 0;
            this.btnImtina.Text = "İmtina et";
            this.btnImtina.Click += new System.EventHandler(this.btnImtina_Click);
            // 
            // btnSec
            // 
            this.btnSec.ImageOptions.ImageIndex = 1;
            this.btnSec.Location = new System.Drawing.Point(5, 31);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(96, 35);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnElave
            // 
            this.btnElave.ImageOptions.ImageIndex = 1;
            this.btnElave.ImageOptions.ImageList = this.ımageList1;
            this.btnElave.Location = new System.Drawing.Point(107, 31);
            this.btnElave.Name = "btnElave";
            this.btnElave.Size = new System.Drawing.Size(96, 35);
            this.btnElave.TabIndex = 0;
            this.btnElave.Text = "Əlavə et";
            this.btnElave.Click += new System.EventHandler(this.btnElave_Click);
            // 
            // btnYaddaSaxla
            // 
            this.btnYaddaSaxla.ImageOptions.ImageIndex = 4;
            this.btnYaddaSaxla.ImageOptions.ImageList = this.ımageList1;
            this.btnYaddaSaxla.Location = new System.Drawing.Point(515, 31);
            this.btnYaddaSaxla.Name = "btnYaddaSaxla";
            this.btnYaddaSaxla.Size = new System.Drawing.Size(115, 35);
            this.btnYaddaSaxla.TabIndex = 2;
            this.btnYaddaSaxla.Text = "Yadda Saxla";
            this.btnYaddaSaxla.Click += new System.EventHandler(this.btnYaddaSaxla_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.ImageIndex = 2;
            this.btnEdit.ImageOptions.ImageList = this.ımageList1;
            this.btnEdit.Location = new System.Drawing.Point(209, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 35);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.ImageIndex = 0;
            this.btnSil.ImageOptions.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(311, 31);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 35);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 273);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(635, 355);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBase,
            this.colAciqlama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colBase
            // 
            this.colBase.Caption = "Terif";
            this.colBase.FieldName = "Tanim";
            this.colBase.MinWidth = 25;
            this.colBase.Name = "colBase";
            this.colBase.OptionsColumn.AllowEdit = false;
            this.colBase.Visible = true;
            this.colBase.VisibleIndex = 0;
            this.colBase.Width = 94;
            // 
            // colAciqlama
            // 
            this.colAciqlama.Caption = "Aciqlama";
            this.colAciqlama.FieldName = "Aciqlama";
            this.colAciqlama.MinWidth = 25;
            this.colAciqlama.Name = "colAciqlama";
            this.colAciqlama.OptionsColumn.AllowEdit = false;
            this.colAciqlama.Visible = true;
            this.colAciqlama.VisibleIndex = 1;
            this.colAciqlama.Width = 94;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 628);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Kitablar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Təriflər";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTerifAciqlama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTerif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Kitablar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtTerifAciqlama;
        private DevExpress.XtraEditors.LabelControl labelzirt;
        private DevExpress.XtraEditors.TextEdit txtTerif;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnYaddaSaxla;
        private DevExpress.XtraEditors.SimpleButton btnImtina;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnElave;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colBase;
        private DevExpress.XtraGrid.Columns.GridColumn colAciqlama;
    }
}