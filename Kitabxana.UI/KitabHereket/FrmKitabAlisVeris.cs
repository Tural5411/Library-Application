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
    public partial class FrmKitabAlisVeris : DevExpress.XtraEditors.XtraForm
    {
        IKitabHereketServis kitabHereketServis = new KitabHereketManager();
        public FrmKitabAlisVeris()
        {
            InitializeComponent();
            kitabHereketServis.ContextYarad(true);
            gridControlAlisVeris.DataSource = kitabHereketServis.Listele();

        }


        private void Kitablar_Click(object sender, EventArgs e)
        {

        }

        private void btnIstifadeciElave_Click(object sender, EventArgs e)
        {
            FrmKitabAlisverisIsler form = new FrmKitabAlisverisIsler();
            form.ShowDialog();
            gridControlAlisVeris.DataSource = kitabHereketServis.Listele(x=>x.TeslimEdildi==false);
        }

        private void btnIstifadeciEdit_Click(object sender, EventArgs e)
        {
            var secilen = (Entities.KitabHereket)gridAlisVeris.GetFocusedRow();
            FrmKitabAlisverisIsler form = new FrmKitabAlisverisIsler(secilen);
            form.ShowDialog();
            gridControlAlisVeris.DataSource = kitabHereketServis.Listele(x => x.TeslimEdildi == false);

        }

        private void btnIstifadeciSil_Click(object sender, EventArgs e)
        {
            Entities.KitabHereket silinecek = (Entities.KitabHereket)gridAlisVeris.GetFocusedRow();
            if(MessageBox.Show("Secdiyiniz melumati silmek istediyinizden eminsiniz ?", 
                MessageBeepSound.Question.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kitabHereketServis.Sil(x => x.Id == silinecek.Id);
                kitabHereketServis.Save();
                gridControlAlisVeris.DataSource = kitabHereketServis.Listele();
            }
        }
    }
}