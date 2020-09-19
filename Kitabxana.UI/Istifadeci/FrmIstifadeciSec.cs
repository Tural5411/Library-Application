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

namespace Kitabxana.UI.Istifadeci
{
    public partial class FrmIstifadeciSec : DevExpress.XtraEditors.XtraForm
    {
        IIstifadeciServis istifadeciServis =new IstifadeciManager();
        public Entities.Istifadeci _istifadeciEntity;
        public FrmIstifadeciSec()
        {
            InitializeComponent();
            istifadeciServis.ContextYarad(true);
            gridControlIstifadeci.DataSource = istifadeciServis.Listele();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            _istifadeciEntity = (Entities.Istifadeci)gridIstifadeci.GetFocusedRow();
            this.Close();
        }

        private void btnBagla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}