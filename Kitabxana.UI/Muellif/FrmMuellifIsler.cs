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

namespace Kitabxana.UI.Muellif
{
    public partial class FrmMuellifIsler : DevExpress.XtraEditors.XtraForm
    {
        IMuellifServis muellifServis = new MuellifManager();
        IKitabServis kitabServis = new KitabManager();
        private Entities.Muellif _muellifEntity;
        //private Entities.Kitab _kitabEntity;
        public bool yaddaSaxla = false;
        
        public FrmMuellifIsler(Entities.Muellif muellifEntity)
        {
            InitializeComponent();
            _muellifEntity = muellifEntity;
            muellifServis.ContextYarad(true);
            kitabServis.ContextBagla(muellifServis.ContextYarad(false));
            txtMuellifAdi.DataBindings.Add("Text", _muellifEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMlfSoyadi.DataBindings.Add("Text",_muellifEntity,"Soyadi",false, DataSourceUpdateMode.OnPropertyChanged);
            txtMlfDogumTarixi.DataBindings.Add("Text", _muellifEntity, "DogumTarixi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMuellifAciqlama.DataBindings.Add("Text", _muellifEntity, "Aciqlama", false, DataSourceUpdateMode.OnPropertyChanged);
            gridControlMuellifKitab.DataSource = kitabServis.Listele(x => x.MuellifId == _muellifEntity.Id);
        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            muellifServis.AddOrUpdate(_muellifEntity);
            muellifServis.Save();
            yaddaSaxla = true;
            this.Close();
        }

        private void btnBagla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}