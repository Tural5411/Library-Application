namespace Kitabxana.UI.Sinif
{
    partial class FrmSinifIsler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinifIsler));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GroupMenu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBagla = new DevExpress.XtraEditors.SimpleButton();
            this.Kitablar = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSinifAciqlama = new DevExpress.XtraEditors.MemoEdit();
            this.txtBolum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtMektebNovu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtComboSinif = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtComboSobe = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupMenu)).BeginInit();
            this.GroupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSinifAciqlama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMektebNovu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComboSinif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComboSobe.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.GroupMenu.Controls.Add(this.simpleButton1);
            this.GroupMenu.Controls.Add(this.btnBagla);
            this.GroupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupMenu.Location = new System.Drawing.Point(0, 445);
            this.GroupMenu.Name = "GroupMenu";
            this.GroupMenu.Size = new System.Drawing.Size(699, 100);
            this.GroupMenu.TabIndex = 4;
            this.GroupMenu.Text = "Menu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageIndex = 6;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(386, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 54);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Yadda Saxla";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnBagla
            // 
            this.btnBagla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBagla.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBagla.Appearance.Options.UseFont = true;
            this.btnBagla.ImageOptions.ImageIndex = 5;
            this.btnBagla.ImageOptions.ImageList = this.ımageList1;
            this.btnBagla.Location = new System.Drawing.Point(547, 34);
            this.btnBagla.Name = "btnBagla";
            this.btnBagla.Size = new System.Drawing.Size(147, 54);
            this.btnBagla.TabIndex = 0;
            this.btnBagla.Text = "Bagla";
            this.btnBagla.Click += new System.EventHandler(this.btnBagla_Click);
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
            this.Kitablar.Size = new System.Drawing.Size(699, 47);
            this.Kitablar.TabIndex = 3;
            this.Kitablar.Text = "Sinif Əməliyyatları";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtComboSobe);
            this.groupControl1.Controls.Add(this.txtComboSinif);
            this.groupControl1.Controls.Add(this.txtMektebNovu);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtSinifAciqlama);
            this.groupControl1.Controls.Add(this.txtBolum);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(699, 398);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Sinif Məlumatları";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl8.Location = new System.Drawing.Point(9, 169);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(152, 29);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Bölüm:";
            // 
            // txtSinifAciqlama
            // 
            this.txtSinifAciqlama.Location = new System.Drawing.Point(167, 219);
            this.txtSinifAciqlama.Name = "txtSinifAciqlama";
            this.txtSinifAciqlama.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSinifAciqlama.Properties.Appearance.Options.UseFont = true;
            this.txtSinifAciqlama.Size = new System.Drawing.Size(503, 98);
            this.txtSinifAciqlama.TabIndex = 13;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(167, 168);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolum.Properties.Appearance.Options.UseFont = true;
            this.txtBolum.Size = new System.Drawing.Size(503, 32);
            this.txtBolum.TabIndex = 11;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl15.Location = new System.Drawing.Point(9, 130);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(152, 29);
            this.labelControl15.TabIndex = 7;
            this.labelControl15.Text = "Şöbə:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl13.Location = new System.Drawing.Point(9, 92);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(152, 29);
            this.labelControl13.TabIndex = 8;
            this.labelControl13.Text = "Sinifi:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl7.Location = new System.Drawing.Point(9, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(152, 29);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Məktəb Növü:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl12.Location = new System.Drawing.Point(9, 220);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(152, 98);
            this.labelControl12.TabIndex = 10;
            this.labelControl12.Text = "Açıqlama:";
            // 
            // txtMektebNovu
            // 
            this.txtMektebNovu.Location = new System.Drawing.Point(167, 52);
            this.txtMektebNovu.Name = "txtMektebNovu";
            this.txtMektebNovu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMektebNovu.Properties.Appearance.Options.UseFont = true;
            this.txtMektebNovu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtMektebNovu.Size = new System.Drawing.Size(503, 30);
            this.txtMektebNovu.TabIndex = 17;
            this.txtMektebNovu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtMektebNovu_ButtonClick);
            // 
            // txtComboSinif
            // 
            this.txtComboSinif.Location = new System.Drawing.Point(167, 91);
            this.txtComboSinif.Name = "txtComboSinif";
            this.txtComboSinif.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtComboSinif.Properties.Appearance.Options.UseFont = true;
            this.txtComboSinif.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtComboSinif.Properties.Items.AddRange(new object[] {
            "9 sinif",
            "10 sinif",
            "11 sinif",
            "1 kurs",
            "2 kurs",
            "3 kurs",
            "4 kurs",
            "1 master",
            "2 master"});
            this.txtComboSinif.Size = new System.Drawing.Size(503, 30);
            this.txtComboSinif.TabIndex = 18;
            // 
            // txtComboSobe
            // 
            this.txtComboSobe.Location = new System.Drawing.Point(167, 132);
            this.txtComboSobe.Name = "txtComboSobe";
            this.txtComboSobe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtComboSobe.Properties.Appearance.Options.UseFont = true;
            this.txtComboSobe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtComboSobe.Properties.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.txtComboSobe.Size = new System.Drawing.Size(503, 30);
            this.txtComboSobe.TabIndex = 19;
            // 
            // FrmSinif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 545);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GroupMenu);
            this.Controls.Add(this.Kitablar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSinif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinif Əməliyyatları";
            ((System.ComponentModel.ISupportInitialize)(this.GroupMenu)).EndInit();
            this.GroupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSinifAciqlama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBolum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMektebNovu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComboSinif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComboSobe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl GroupMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnBagla;
        private DevExpress.XtraEditors.LabelControl Kitablar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit txtMektebNovu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.MemoEdit txtSinifAciqlama;
        private DevExpress.XtraEditors.TextEdit txtBolum;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit txtComboSinif;
        private DevExpress.XtraEditors.ComboBoxEdit txtComboSobe;
    }
}