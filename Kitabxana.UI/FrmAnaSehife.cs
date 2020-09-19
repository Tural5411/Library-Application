using Kitabxana.UI.Istifadeci;
using Kitabxana.UI.Kitab;
using Kitabxana.UI.KitabHereket;
using Kitabxana.UI.Sinif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kitabxana.UI
{
    public partial class FrmAnaSehife : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaSehife()
        {
            InitializeComponent();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKitab form = new FrmKitab();
            form.MdiParent = this;
            form.Show();
        }
        private void FrmAnaSehife_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIstifadeci form = new FrmIstifadeci();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSinif form = new FrmSinif();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKitabAlisVeris form = new FrmKitabAlisVeris();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKitabHereket form = new FrmKitabHereket();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEnler form = new FrmEnler();
            form.MdiParent = this;
            form.Show();
        }
    }
}
