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
    public partial class FrmIstifadeci : DevExpress.XtraEditors.XtraForm
    {
        IIstifadeciServis istifadeciServis = new IstifadeciManager();

        public FrmIstifadeci()
        {
            InitializeComponent();
            istifadeciServis.ContextYarad(true);
            List();
        }
        public void List()
        {
            gridControlKitab.DataSource = istifadeciServis.Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmIstifadeciIsler form = new FrmIstifadeciIsler(new Entities.Istifadeci());
            form.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Entities.Istifadeci istifadecilerEntity = (Entities.Istifadeci)gridKitab.GetFocusedRow();
            FrmIstifadeciIsler form = new FrmIstifadeciIsler(istifadecilerEntity);
            form.ShowDialog();
        }
    }
}