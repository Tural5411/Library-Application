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
using Kitabxana.UI.Base;
using Kitabxana.UI.Sinif;

namespace Kitabxana.UI.Istifadeci
{
    public partial class FrmIstifadeciIsler : DevExpress.XtraEditors.XtraForm
    {
        #region
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        private Entities.Istifadeci _istifadeciEntity = new Entities.Istifadeci();
        private Telefon _telefonEntity;
        private Unvan _unvanEntity = new Entities.Unvan();

        public bool YaddaSaxlanildi3 = false;

        IIstifadeciServis IstifadeciServis = new IstifadeciManager();
        ITelefonServis telefonServis = new TelefonManager();
        ISinifServis sinifServis = new SinifManager();
        IUnvanServis unvanServis = new UnvanManager();

        public FrmIstifadeciIsler(Entities.Istifadeci istifadeciEntity)
        {
            InitializeComponent();
            IstifadeciServis.ContextYarad(true);
            telefonServis.ContextBagla(IstifadeciServis.ContextYarad(false));
            unvanServis.ContextBagla(IstifadeciServis.ContextYarad(false));
            sinifServis.ContextBagla(IstifadeciServis.ContextYarad(false));
            _istifadeciEntity = istifadeciEntity;

            toggleVeziyyet.DataBindings.Add("EditValue", _istifadeciEntity,
                "Veziyyet", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSexsiyyetN.DataBindings.Add("Text", _istifadeciEntity,
                "SexsiyyetNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMektebN.DataBindings.Add("Text", _istifadeciEntity,
                "MektebNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIstifadeciBarkod.DataBindings.Add("Text", _istifadeciEntity,
                "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdi.DataBindings.Add("Text", _istifadeciEntity,
                "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _istifadeciEntity,
                "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtQeydiyyat.DataBindings.Add("EditValue", _istifadeciEntity,
                "QeydiyyatTarixi", true, DataSourceUpdateMode.OnPropertyChanged, DateTime.Now);
            txtSektor.DataBindings.Add("Text", _istifadeciEntity,
                "Sektor", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciqlama.DataBindings.Add("Text", _istifadeciEntity,
                "Aciqlama", false, DataSourceUpdateMode.OnPropertyChanged);

            gridControlTelefon.DataSource = telefonServis.Birlesdirme(x => x.IstifadeciId == _istifadeciEntity.Id);
            gridControUnvan.DataSource = unvanServis.Birlesdirme(x => x.IstifadeciId == _istifadeciEntity.Id);
            SinifList();
            UnvanBinding();
        }


        #region Sinif
        private void SinifList()
        {
            searchSinif.Properties.DataSource = sinifServis.Listele();
            searchSinif.Properties.DisplayMember = "MektebNovu";
            searchSinif.Properties.ValueMember = "Id";
            if (_istifadeciEntity.SinifId != 0)
            {
                SinifYukle(_istifadeciEntity.SinifId);
            }
        }

        private void SinifYukle(int id)
        {
            _istifadeciEntity.SinifId = id;
            var sinifEntity = sinifServis.Getir(x => x.Id == id);
            searchSinif.EditValue = sinifEntity.Id;
            txtSinif.Text = sinifEntity.Sinifi;
            txtSobe.Text = sinifEntity.Sobe;
            txtBolum.Text = sinifEntity.Bolumu;
            txtSinifAciqlama.Text = sinifEntity.Aciqlama;

            gridControlSinif.DataSource = IstifadeciServis.Listele(x => x.SinifId == id);
        }
        #endregion
        #region Telefon
        private void TelefonMelumatAc()
        {
            btnTelefonElave.Enabled = false;
            btnTelefonEdit.Enabled = false;
            btnTelefonSil.Enabled = false;
            btnTelefonYaddaSaxla.Enabled = true;
            btnTelefonImtina.Enabled = true;

            grpTelefonMelumat.Visible = true;
            GroupMenu.Enabled = false;

            gridControlTelefon.Enabled = true;
        }
        private void TelefonMelumatBagla()
        {
            btnTelefonElave.Enabled = true;
            btnTelefonEdit.Enabled = true;
            btnTelefonSil.Enabled = true;
            btnTelefonYaddaSaxla.Enabled = false;
            btnTelefonImtina.Enabled = false;

            grpTelefonMelumat.Visible = false;
            GroupMenu.Enabled = true;

            gridControlTelefon.Enabled = false;
        }


        private void TelefonBinding()
        {
            txtTelefon.DataBindings.Clear();
            txtTelefonAdiSoyadi.DataBindings.Clear();
            txtTelefonYaxinliq.DataBindings.Clear();
            txtTelefonAciqlama.DataBindings.Clear();

            txtTelefon.DataBindings.Add("Text", _telefonEntity,
                "Telefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefonAdiSoyadi.DataBindings.Add("Text", _telefonEntity,
                "AdiSoyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefonYaxinliq.DataBindings.Add("Text", _telefonEntity,
                "Mesafe", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefonAciqlama.DataBindings.Add("Text", _telefonEntity,
                "Aciqlama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnTelefonElave_Click(object sender, EventArgs e)
        {
            TelefonMelumatAc();
            _telefonEntity = new Telefon();
            TelefonBinding();
        }

        private void btnTelefonEdit_Click(object sender, EventArgs e)
        {
            TelefonMelumatAc();
            _telefonEntity = (Telefon)layoutTelefon.GetFocusedRow();
            TelefonBinding();
        }

        private void btnTelefonSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmək İstədiyinizdən Əminsiniz?", "Bildiriş", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                layoutTelefon.DeleteSelectedRows();
            }
        }

        private void btnTelefonYaddaSaxla_Click(object sender, EventArgs e)
        {
            _telefonEntity.IstifadeciId = _istifadeciEntity.Id;
            if (telefonServis.AddOrUpdate(_telefonEntity) != null)
            {
                TelefonMelumatBagla();
            }
        }

        private void btnTelefonImtina_Click(object sender, EventArgs e)
        {
            TelefonMelumatBagla();
            _telefonEntity = null;
        }
        #endregion
        #region Unvan
        private void UnvanMelumatAc()
        {
            btnUnvanElave.Enabled = false;
            btnUnvanEdit.Enabled = false;
            btnUnvanSil.Enabled = false;
            btnUnvanYaddaSaxla.Enabled = true;
            btnUnvanImtina.Enabled = true;

            groupUnvanMelumat.Visible = true;
            GroupMenu.Enabled = false;

            gridControUnvan.Enabled = true;
        }
        private void UnvanMelumatBagla()
        {
            btnUnvanElave.Enabled = true;
            btnUnvanEdit.Enabled = true;
            btnUnvanSil.Enabled = true;
            btnUnvanYaddaSaxla.Enabled = false;
            btnUnvanImtina.Enabled = false;

            groupUnvanMelumat.Visible = false;
            GroupMenu.Enabled = true;

            gridControUnvan.Enabled = false;
        }
        private void btnUnvanElave_Click(object sender, EventArgs e)
        {
            UnvanMelumatAc();
            _unvanEntity = new Unvan();
            UnvanBinding();

        }
        private void btnUnvanEdit_Click(object sender, EventArgs e)
        {
            UnvanMelumatAc();
            _unvanEntity = (Unvan)layoutUnvan.GetFocusedRow();
            UnvanBinding();
        }

        private void btnUnvanSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmək İstədiyinizdən Əminsiniz?", "Bildiriş", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                layoutUnvan.DeleteSelectedRows();
            }
        }

        private void btnUnvanYaddaSaxla_Click(object sender, EventArgs e)
        {
            _unvanEntity.IstifadeciId = _istifadeciEntity.Id;
            if (unvanServis.AddOrUpdate(_unvanEntity) != null)
            {
                UnvanMelumatBagla();
            }
        }

        private void btnUnvanImtina_Click(object sender, EventArgs e)
        {
            if (_unvanEntity.Id != 0)
            {
                _unvanEntity = null;
                UnvanMelumatBagla();
            }

        }

        private void UnvanBinding()
        {
            txtSeher.DataBindings.Clear();
            txtRayon.DataBindings.Clear();
            txtMenteqe.DataBindings.Clear();
            txtMetro.DataBindings.Clear();
            txtUnvan.DataBindings.Clear();
            txtUnvanAciqlama.DataBindings.Clear();

            txtSeher.DataBindings.Add("Text", _unvanEntity, "Seher", false, DataSourceUpdateMode.OnPropertyChanged);
            txtRayon.DataBindings.Add("Text", _unvanEntity, "Rayon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMenteqe.DataBindings.Add("Text", _unvanEntity, "Menteqe", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMetro.DataBindings.Add("Text", _unvanEntity, "Metro", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUnvan.DataBindings.Add("Text", _unvanEntity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUnvanAciqlama.DataBindings.Add("Text", _unvanEntity, "Aciqlama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (IstifadeciServis.AddOrUpdate(_istifadeciEntity) != null)
            {
                YaddaSaxlanildi3 = true;
                IstifadeciServis.Save();
                this.Close();
            }
        }

        private void btnBagla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPane1_SelectedPageChanging(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangingEventArgs e)
        {
            if (GroupMenu.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void searchSinif_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if(searchSinif.Properties.View.SelectedRowsCount != 0)
            {
                var id =(int)searchSinif.Properties.View.GetFocusedRowCellValue(colSinifId);

                SinifYukle(id);
            }
        }

        private void txtSektor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmBase form = new FrmBase(FrmBase.Novu.Sektor);
            form.ShowDialog();
            if (form.secildi == true)
            {
                txtSektor.Text = form._baseEntity.Tanim;
            }
        }

        private void searchSinif_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                FrmSinifIsler form = new FrmSinifIsler(new Entities.Sinif());
                form.ShowDialog();
                if (form.YaddaSaxlanildi4 == true)
                {
                    SinifList();
                }
            }
        }
    }
}