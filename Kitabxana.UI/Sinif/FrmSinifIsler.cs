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
using Kitabxana.UI.Base;
using Kitabxana.Business.Servisler;
using Kitabxana.Business.Idare;

namespace Kitabxana.UI.Sinif
{
    public partial class FrmSinifIsler : DevExpress.XtraEditors.XtraForm
    {
        ISinifServis sinifServis = new SinifManager();
        private Entities.Sinif _sinifEntity = new Entities.Sinif();
        public bool YaddaSaxlanildi4 = false;
        public FrmSinifIsler(Entities.Sinif sinifEntity)
        {
            InitializeComponent();
            _sinifEntity = sinifEntity;
            sinifServis.ContextYarad(true);

            txtMektebNovu.DataBindings.Add("Text", _sinifEntity, "MektebNovu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtComboSinif.DataBindings.Add("Text", _sinifEntity, "Sinifi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtComboSobe.DataBindings.Add("Text", _sinifEntity, "Sobe", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBolum.DataBindings.Add("Text", _sinifEntity, "Bolumu", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void txtMektebNovu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmBase form = new FrmBase(FrmBase.Novu.MektebNovu);
            form.ShowDialog();
            if (form.secildi == true)
            {
                txtMektebNovu.Text = form._baseEntity.Tanim;
            }
        }

        private void btnBagla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (sinifServis.AddOrUpdate(_sinifEntity) != null)
            {
                YaddaSaxlanildi4 = true;
                sinifServis.Save();
                this.Close();
            }
        }
    }
}