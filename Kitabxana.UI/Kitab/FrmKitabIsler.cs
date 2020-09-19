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
using Kitabxana.UI.Muellif;
using Kitabxana.UI.Base;

namespace Kitabxana.UI.Kitab
{
    public partial class FrmKitabIsler : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Kitab _entity;
        private Barkod _barkodEntity = new Barkod();
        IKitabServis kitabServis = new KitabManager();
        IBarkodServis barkodServis = new BarkodManager();
        IMuellifServis muellifServis = new MuellifManager();
        public bool YaddaSaxlanildi2 = false;
        public FrmKitabIsler(Entities.Kitab entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleVeziyyet.DataBindings.Add("EditValue", _entity, "Veziyyet", false, DataSourceUpdateMode.OnPropertyChanged);
            toggleKiraye.DataBindings.Add("EditValue", _entity, "KirayeVerilebiler", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKitabKodu.DataBindings.Add("Text", _entity, "KitabKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtISBN.DataBindings.Add("Text", _entity, "ISBN", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKitabAdi.DataBindings.Add("Text", _entity, "KitabAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNovu.DataBindings.Add("Text", _entity, "Novu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNesriyyatEvi.DataBindings.Add("Text", _entity, "Nesriyyat", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNesrIli.DataBindings.Add("Text", _entity, "Nesrili", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNesrSayi.DataBindings.Add("Text", _entity, "NesrSayi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCildSayi.DataBindings.Add("Text", _entity, "CildSayi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSehifeSayi.DataBindings.Add("Text", _entity, "SehifeSayi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDemirbas.DataBindings.Add("Text", _entity, "Demirbasno", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKitabAciqlama.DataBindings.Add("Text", _entity, "Aciqlama", false, DataSourceUpdateMode.OnPropertyChanged);

            kitabServis.ContextYarad(true);
            barkodServis.ContextBagla(kitabServis.ContextYarad(false));
            gridControlBarkod.DataSource = barkodServis.Birlesdirme(x=>x.KitabId==_entity.Id);
            muellifServis.ContextBagla(kitabServis.ContextYarad(false));
            MuellifListele();

        }

        private void MuellifListele()
        {
            searchMuellif.Properties.DataSource = muellifServis.Listele();
            searchMuellif.Properties.DisplayMember = "Adi";
            searchMuellif.Properties.ValueMember = "Id";
            if (_entity.MuellifId != 0)
            {
                MuellifYukle(_entity.MuellifId);
            }
        }
        private void BarkodBinding()
        {
            txtBarkod.DataBindings.Clear();
            txtOtaq.DataBindings.Clear();
            txtRef.DataBindings.Clear();
            txtSira.DataBindings.Clear();
            txtSiyirme.DataBindings.Clear();
            txtBarkodAciqlama.DataBindings.Clear();
            rateDeyerlendirme.DataBindings.Clear();
            txtBarkod.DataBindings.Add("Text", _barkodEntity,
                "Barkodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtOtaq.DataBindings.Add("Text", _barkodEntity,
                "Otaq", false, DataSourceUpdateMode.OnPropertyChanged);
            txtRef.DataBindings.Add("Text", _barkodEntity,
                "Ref", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSira.DataBindings.Add("Text", _barkodEntity,
                "Sira", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSiyirme.DataBindings.Add("Text",
                _barkodEntity, "Siyirme", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBarkodAciqlama.DataBindings.Add("Text",
                _barkodEntity, "Aciqlama", false, DataSourceUpdateMode.OnPropertyChanged);
            rateDeyerlendirme.DataBindings.Add("EditValue", _barkodEntity,
                "Deyerlendirme", false, DataSourceUpdateMode.OnPropertyChanged);

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (kitabServis.AddOrUpdate(_entity) != null)
            {
                kitabServis.Save();
                YaddaSaxlanildi2 = true;
                this.Close();   
            }
        }
        private void btnBarkodYaddaSaxla_Click(object sender, EventArgs e)
        {
            _barkodEntity.KitabId = _entity.Id;
            if (barkodServis.AddOrUpdate(_barkodEntity) != null)
            {
                BarkodMelumatBagla();
            }
        }
        private void btnBarkodElave_Click(object sender, EventArgs e)
        {
            BarkodMelumatAc();
            _barkodEntity = new Barkod();
            BarkodBinding();
        }
        private void BarkodMelumatAc()
        {
            grpBarkodMelumat.Visible = true;
            gridControlBarkod.Enabled = false;
            GroupMenu.Enabled = false;
            btnBarkodElave.Enabled = false;
            btnBarkodEdit.Enabled = false;
            btnBarkodSil.Enabled = false;
            btnBarkodYaddaSaxla.Enabled = true;
            btnBarkodImtina.Enabled = true;

        }
        private void BarkodMelumatBagla()
        {
            grpBarkodMelumat.Visible = false;
            gridControlBarkod.Enabled = true;
            GroupMenu.Enabled = true;
            btnBarkodElave.Enabled = true;
            btnBarkodEdit.Enabled = true;
            btnBarkodSil.Enabled = true;
            btnBarkodYaddaSaxla.Enabled = false;
            btnBarkodImtina.Enabled = false;
        }



        private void btnBarkodEdit_Click(object sender, EventArgs e)
        {
            BarkodMelumatAc();
            _barkodEntity = (Barkod)layoutBarkod.GetFocusedRow();
            BarkodBinding();
        }

        private void btnBarkodImtina_Click(object sender, EventArgs e)
        {
            if (_barkodEntity.Id != 0)
            {
                _barkodEntity = null;
                BarkodMelumatBagla();
            }
        }

        private void btnBarkodSil_Click(object sender, EventArgs e)
        {
            Barkod Silinecek = (Barkod)layoutBarkod.GetFocusedRow();
            if(MessageBox.Show("Silmək İstədiyinizdən Əminsiniz?", "Bildiriş", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Alternativ olaraq layoutBarkod.DeleteSelectedRows();
                barkodServis.Sil(Silinecek);
            }
        }

        private void btnBagla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchMuellif_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (searchMuellif.Properties.View.SelectedRowsCount > 0)
            {
                var id = (Int32)searchMuellif.Properties.View.GetFocusedRowCellValue(colMuellifId);
                MuellifYukle(id);
            }

        }

        private void MuellifYukle(int id)
        {
            var muellifentity = muellifServis.Getir(x => x.Id == id);
            txtMlfSoyadi.Text = muellifentity.Soyadi;
            searchMuellif.EditValue = muellifentity.Id;
            _entity.MuellifId = id;
            txtMlfDogumTarixi.Text = muellifentity.DogumTarixi.ToString();
            txtMuellifAciqlama.Text = muellifentity.Aciqlama;
            gridControlMuellifKitab.DataSource = kitabServis.Listele(x => x.MuellifId == id);
        }

        private void searchMuellif_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                FrmMuellifIsler form = new FrmMuellifIsler(new Entities.Muellif());
                form.ShowDialog();
                if (form.yaddaSaxla == true)
                {
                    MuellifListele();
                }
            }
        }

        private void txtNovu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmBase form = new FrmBase(FrmBase.Novu.KitabNovu);
            form.ShowDialog();
            if (form.secildi == true)
            {
                txtNovu.Text = form._baseEntity.Tanim;
            }
        }


        //private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    FrmBase form = new FrmBase(FrmBase.Novu.KitabQrupu);
        //    form.ShowDialog();
        //    if (form.secildi == true)
        //    {
        //        buttonEdit1.Text = form._baseEntity.Tanim;
        //    }
        //}
    }
}