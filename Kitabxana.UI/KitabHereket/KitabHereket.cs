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

namespace Kitabxana.UI.KitabHereket
{
    public partial class FrmKitabHereket : DevExpress.XtraEditors.XtraForm
    {
        IKitabHereketServis kitabHereketServis = new KitabHereketManager();
        public FrmKitabHereket()
        {
            InitializeComponent();
            kitabHereketServis.ContextYarad(true);
            Listele();

           
        }
        public void Listele()
        {
            gridControlKitabHereket.DataSource = kitabHereketServis.Listele();
        }

        private void btnIstifadeciYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnIstifadeciElave_Click(object sender, EventArgs e)
        {
            Entities.KitabHereket kitabHereketentity = (Entities.KitabHereket)gridKitabHereket.GetFocusedRow();
            kitabHereketentity.TeslimEdildi = false;
            kitabHereketentity.TeslimTarixi = null;
            kitabHereketServis.AddOrUpdate(kitabHereketentity);
            kitabHereketServis.Save();
            Listele();
        }
    }
}