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

namespace Kitabxana.UI.Kitab
{
    public partial class FrmKitabSec : DevExpress.XtraEditors.XtraForm
    {
        IKitabServis kitabServis = new KitabManager();
        public Entities.Barkod barkodEntity;
        public bool Secildi = false;

        public FrmKitabSec()
        {
            InitializeComponent();
            kitabServis.ContextYarad(true);
            gridControlKitab.DataSource = kitabServis.Listele();
        }

        private void FrmKitabSec_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
            lblBasliq.Text = "Zəhmət Olmasa Kitab Seçin";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (navigationFrame1.SelectedPage == navigationPage1)
            {
                Entities.Kitab kitapEntity = (Entities.Kitab)gridKitab.GetFocusedRow();
                navigationFrame1.SelectedPage = navigationPage2;
                gridControlBarkod.DataSource = kitapEntity.Barkods;
                lblBasliq.Text = "Zəhmət Olmasa Barkod Daxil Edin - " + kitapEntity.KitabAdi;
            }
            else
            {
                barkodEntity = (Entities.Barkod)gridBarkod.GetFocusedRow();
                Secildi = true;
                this.Close();
            }

        }

        private void btnBagla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}