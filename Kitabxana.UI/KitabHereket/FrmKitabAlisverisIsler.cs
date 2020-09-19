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
using Kitabxana.UI.Kitab;
using Kitabxana.UI.Istifadeci;

namespace Kitabxana.UI.KitabHereket
{
    public partial class FrmKitabAlisverisIsler : DevExpress.XtraEditors.XtraForm
    {
        IBarkodServis barkodServis = new BarkodManager();
        IIstifadeciServis istifadeciServis = new IstifadeciManager();
        IKitabHereketServis kitabHereketServis = new KitabHereketManager();
        IKitabServis kitabServis = new KitabManager();
        private Entities.Kitab _kitabEntity;
        private Entities.Barkod _barkodEntity;
        private Entities.KitabHereket _kitabHereketEntity;
        private Entities.Istifadeci _istifadeciEntity;
        public bool editle = false;

        public FrmKitabAlisverisIsler(Entities.KitabHereket kitabHereketEntity=null)
        {
            InitializeComponent();
            _kitabHereketEntity = kitabHereketEntity;
            kitabHereketServis.ContextYarad(true);
            barkodServis.ContextBagla(kitabHereketServis.ContextYarad(false));
            istifadeciServis.ContextBagla(kitabHereketServis.ContextYarad(false));
            kitabServis.ContextBagla(kitabHereketServis.ContextYarad(false));
            if (kitabHereketEntity != null)
            {
                _kitabEntity = kitabServis.Getir(x => x.Id == kitabHereketEntity.KitabId);
                _istifadeciEntity = istifadeciServis.Getir(x => x.Id == kitabHereketEntity.IstifadeciId);
                _barkodEntity = barkodServis.Getir(x => x.Id == kitabHereketEntity.BarkodId);
                _kitabHereketEntity = kitabHereketEntity;
                KitabYukle(_kitabEntity.Id);
                IstifadeciYukle(_istifadeciEntity.Id);
                PageİslemSecim.Visible = false;
                editle = true;
            }
            else
            {
                _kitabHereketEntity = new Entities.KitabHereket();
            }
        }

        private void txtKitabBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _barkodEntity = barkodServis.Getir(x => x.Barkodu == txtKitabBarkod.Text);
                if (_barkodEntity == null)
                {
                    MessageBox.Show("Barkod Tapilmadi");
                }
                else
                {
                    KitabYukle(_barkodEntity.KitabId);
                }

            }
        }

        private void KitabYukle(int id)
        {
            _kitabEntity = kitabServis.Getir(x => x.Id == id);
            txtKitabKodu.Text = _kitabEntity.KitabKodu;
            toggleKiraye.IsOn = _kitabEntity.KirayeVerilebiler;
            toggleVeziyyet.IsOn = _kitabEntity.Veziyyet;
            txtISBN.Text = _kitabEntity.ISBN;
            txtKitabAdi.Text = _kitabEntity.KitabAdi;
            txtNesriyyatEvi.Text = _kitabEntity.Nesriyyat;
            txtNesrIli.Text = _kitabEntity.Nesrili.ToString();
            txtNesrSayi.Text = _kitabEntity.NesrSayi.ToString();
            txtCildSayi.Text = _kitabEntity.CildSayi.ToString();
            txtSehifeSayi.Text = _kitabEntity.SehifeSayi.ToString();
            txtDemirbas.Text = _kitabEntity.Demirbasno.ToString();
            txtKitabAciqlama.Text = _kitabEntity.Aciqlama;
            txtKitabNovi.Text = _kitabEntity.Novu;
            gridControlKitabHereket.DataSource = _kitabEntity.KitabHereketler;
            txtMlfAdi.Text = _kitabEntity.Muellifs.Adi;
            txtMlfSoyadi.Text = _kitabEntity.Muellifs.Soyadi;
            txtMlfDogumTarixi.Text = _kitabEntity.Muellifs.DogumTarixi.ToString();
            txtMuellifAciqlama.Text = _kitabEntity.Muellifs.Aciqlama;
        }

        private void IstifadeciYukle(int id)
        {
            _istifadeciEntity = istifadeciServis.Getir(x => x.Id == id);
            toggleIstifadeciVezyet.IsOn = _istifadeciEntity.Veziyyet;
            txtSexsiyyetN.Text = _istifadeciEntity.SexsiyyetNo.ToString();
            txtIstifadeciBarkod.Text = _istifadeciEntity.Barkod;
            txtMektebN.Text = _istifadeciEntity.MektebNo.ToString();
            txtAdi.Text = _istifadeciEntity.Adi;
            txtSoyadi.Text = _istifadeciEntity.Soyadi;
            txtSektor.Text = _istifadeciEntity.Sektor;
            txtIstifadeciAciqlama.Text = _istifadeciEntity.Aciqlama;
            txtQeydiyyatTarixi.Text = _istifadeciEntity.QeydiyyatTarixi.Value.ToString("MMMM dd, yyyy");
            txtMektebNovu.Text = _istifadeciEntity.Sinif.MektebNovu;
            txtSinifi.Text = _istifadeciEntity.Sinif.Sinifi;
            txtSobe.Text = _istifadeciEntity.Sinif.Sobe;
            txtBolum.Text = _istifadeciEntity.Sinif.Bolumu;
            txtSinifAciqlama.Text = _istifadeciEntity.Sinif.Aciqlama;
            gridControlTelefon.DataSource = _istifadeciEntity.Telefonlar;
            gridControUnvan.DataSource = _istifadeciEntity.Unvanlar;
            gridControlIstifadeciKitabHereket.DataSource = _istifadeciEntity.KitabHereketler;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKitabSec form = new FrmKitabSec();
            form.ShowDialog();
            if (form.Secildi == true)
            {
                KitabYukle(form.barkodEntity.KitabId);
                _barkodEntity = form.barkodEntity;
                txtKitabBarkod.Text = _barkodEntity.Barkodu;
            }
        }

        private void txtIstifadeciBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var istifadeciEntity = istifadeciServis.Getir(x => x.Barkod == txtIstifadeciBarkod.Text);
                if (istifadeciEntity == null)
                {
                    MessageBox.Show("Barkod Tapilmadi");
                }
                else
                {
                    IstifadeciYukle(istifadeciEntity.Id);
                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmIstifadeciSec form = new FrmIstifadeciSec();
            form.ShowDialog();
            if (form._istifadeciEntity != null)
            {
                IstifadeciYukle(form._istifadeciEntity.Id);
            }
        }

        private void calendarVerilis_DateTimeChanged(object sender, EventArgs e)
        {
            Tekrar();
        }

        private void Tekrar()
        {
            calendarTeslim.DateTime = calendarVerilis.DateTime.AddDays(15);
            lblTekrar.Text = $"Emeliyyat Tekrari\n\n{_barkodEntity.Barkodu} - {_kitabEntity.KitabAdi}\n\nYuxarıda Göstərilən Kİtab{calendarVerilis.DateTime.ToString("d")} tarixində 15 gün ərzində {_istifadeciEntity.Barkod} barkodlu {_istifadeciEntity.Adi} {_istifadeciEntity.Soyadi} istifadəçisinə {calendarTeslim.DateTime.ToString("d")} tarixində geri gətirmək şərti ilə təslim ediləcək. Qəbul Edirsiniz ?";
            if (checkKitabAl.Checked == false)
            {
                _kitabHereketEntity.VerilmeTarixi = calendarVerilis.DateTime;
                _kitabHereketEntity.VerilmeMuddeti = 15;
            }

        }

        private void PageGiris_FinishClick(object sender, CancelEventArgs e)
        {
            if (checkKitabAl.Checked == true)

            {
                _kitabHereketEntity.DeyerlendirmeUmumi = (int)ratingEsas.Rating;


                _kitabHereketEntity.DeyerlendirmeZaman = (int)ratingZaman.Rating;
                _kitabHereketEntity.DeyerlendirmeKitab = (int)ratingVeziyyet.Rating;
                _kitabHereketEntity.TeslimEdildi = true;
                _kitabHereketEntity.TeslimTarixi = calendarTeslimLazimOlan.DateTime;
            }
            else
            {
                _kitabHereketEntity.IstifadeciId = _istifadeciEntity.Id;
            }
            _kitabHereketEntity.BarkodId = _barkodEntity.Id;
            _kitabHereketEntity.KitabId = _kitabEntity.Id;
            kitabHereketServis.AddOrUpdate(_kitabHereketEntity);
            kitabHereketServis.Save();
        }
        private void KitabAl()
        {
            pageIstifadeciSec.Visible = false;
            pageIslemTekrar.Visible = false;
        }
        private void KitabVer()
        {
            pageDeyerlendirme.Visible = false;
        }
        private void PageGiris_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {

            if (e.PrevPage == PageİslemSecim && e.Direction==DevExpress.XtraWizard.Direction.Forward)
            {
                if (checkKitabAl.Checked)
                {
                    KitabAl();
                }
                else
                {
                    KitabVer();
                }
            }
            //Kitab Secme emeliyyatlari
            if (e.PrevPage == pageKitabSec && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                if (_kitabEntity == null)
                {
                    MessageBox.Show("Bir sonrakı addıma keçmək üçün zəhmətə olmasa KİTAB seçin");
                    e.Cancel = true;
                }
                else
                {
                    if (!_kitabEntity.KirayeVerilebiler)
                    {
                        MessageBox.Show("Bu kitab Kiraye Verile bilmez", MessageBeepSound.Warning.ToString(), MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }

                    Entities.KitabHereket control = kitabHereketServis.Getir(x => x.BarkodId == _barkodEntity.Id && x.TeslimEdildi == false);
                    if (checkKitabAl.Checked == true)
                    {
                        if (control != null)
                        {
                            _kitabHereketEntity = control;
                        }
                        else
                        {
                            MessageBox.Show("Bu kitab Kitabxanadadir");
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        if (control!=null && editle==false)
                        {
                            MessageBox.Show($"Bu Kitab {control.Istifadeci.Barkod} barkodlu  " +
                        $"{control.Istifadeci.Adi}  {control.Istifadeci.Soyadi}" +
                        $" adli istifadecidedir.{control.VerilmeTarixi.AddDays(control.VerilmeMuddeti).ToShortDateString()} " +
                        $"tarixine qeder geri qaytarilmalidir.");
                            e.Cancel = true;
                        }
                    }
                }
            }
            //Istifadeci Secme emeliyyatlari
            if (e.PrevPage == pageIstifadeciSec && _istifadeciEntity == null && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                MessageBox.Show("Bir sonrakı addıma keçmək üçün zəhmətə olmasa İSTİFADƏÇİ seçin");
                e.Cancel = true;
            }
            if (e.Page == pageIslemTekrar && e.Direction == DevExpress.XtraWizard.Direction.Forward)
            {
                Tekrar();
            }
        }
    }
}