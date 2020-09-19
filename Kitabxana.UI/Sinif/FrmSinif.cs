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
using Kitabxana.UI.Istifadeci;

namespace Kitabxana.UI.Sinif
{
    public partial class FrmSinif : DevExpress.XtraEditors.XtraForm
    {
        ISinifServis sinifService = new SinifManager();
        IIstifadeciServis uyeService = new IstifadeciManager();
        private List<Entities.Sinif> sinifListe;
        public FrmSinif()
        {
            InitializeComponent();
            Listele();

        }

        private void Listele()
        {
            sinifService.ContextYarad(true);
            uyeService.ContextBagla(sinifService.ContextYarad(false));
            sinifListe = sinifService.Listele();
            gridControlSinif.DataSource = sinifListe;
        }

        private void btnSinifElave_Click_1(object sender, EventArgs e)
        {
            FrmSinifIsler form = new FrmSinifIsler(new Entities.Sinif());
            form.ShowDialog();
            if (form.YaddaSaxlanildi4)
            {
                Listele();
            }
        }

        private void btnSinifEdit_Click_1(object sender, EventArgs e)
        {
            Entities.Sinif sinifEntity = (Entities.Sinif)gridSinif.GetFocusedRow();
            FrmSinifIsler form = new FrmSinifIsler(sinifEntity);
            form.ShowDialog();
            if (form.YaddaSaxlanildi4)
            {
                Listele();
            }
        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            Entities.Sinif sinifEntity = (Entities.Sinif)gridSinif.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sinifService.Sil(sinifEntity);
                sinifService.Save();
                Listele();
            }
        }

        private void btnSinifYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnIstifadeciElave_Click_1(object sender, EventArgs e)
        {
            FrmIstifadeciIsler form = new FrmIstifadeciIsler(new Entities.Istifadeci());
            form.ShowDialog();
            if (form.YaddaSaxlanildi3)
            {
                Listele();
            }
        }

        private void btnIstifadeciEdit_Click(object sender, EventArgs e)
        {
            Entities.Istifadeci uyeEntity = (Entities.Istifadeci)layoutIstifadeci.GetFocusedRow();
            FrmIstifadeciIsler form = new FrmIstifadeciIsler(uyeEntity);
            form.ShowDialog();
            if (form.YaddaSaxlanildi3)
            {
                Listele();
            }
        }

        private void btnIstifadeciSil_Click(object sender, EventArgs e)
        {
            Entities.Istifadeci uyeEntity = (Entities.Istifadeci)layoutIstifadeci.GetFocusedRow();
            if (MessageBox.Show("Seçili olan melumati silmek istediyinizden eminsiziniz?", "Bildiris",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                uyeService.Sil(uyeEntity);
                uyeService.Save();
                Listele();
            }
        }

        private void btnIstifadeciYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }


        private void btnBagla_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridSinif_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ////gridControlSinif.DataSource = sinifListe[gridSinif.FocusedRowHandle].Istifadeciler;
        }
    }
}