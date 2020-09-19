using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Kitabxana.Business.Servisler;
using Kitabxana.Business.Idare;
using Kitabxana.Entities;

namespace Kitabxana.UI.Kitab
{
    public partial class FrmKitab : DevExpress.XtraEditors.XtraForm
    {
        private IKitabServis kitabServis = new KitabManager();
        public FrmKitab()
        {
            InitializeComponent();
            kitabServis.ContextYarad(true);
            List();
        }

        private void FrmKitab_Load(object sender, EventArgs e)
        {

        }
        private void List()
        {
            gridControlKitab.DataSource = kitabServis.Listele();
        }

        private void Kitablar_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKitabIsler form = new FrmKitabIsler(new Entities.Kitab());
            form.ShowDialog();
            if (form.YaddaSaxlanildi2 == true)
            {
                List();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = (int)gridKitab.GetFocusedRowCellValue(colId);
            FrmKitabIsler form = new FrmKitabIsler(kitabServis.Getir(x=>x.Id==id));
            form.ShowDialog();
            if (form.YaddaSaxlanildi2 == true)
            {
                List();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Entities.Kitab Silinecek = (Entities.Kitab)gridKitab.GetFocusedRow();
            if (MessageBox.Show("Silmək İstədiyinizdən Əminsiniz?", "Bildiriş", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kitabServis.Sil(x=>x.Id==Silinecek.Id);
                kitabServis.Save();
                List();
            }
        }
    }
}