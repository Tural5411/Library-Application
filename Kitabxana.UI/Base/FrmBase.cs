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

namespace Kitabxana.UI.Base
{
    public partial class FrmBase : DevExpress.XtraEditors.XtraForm
    {
        #region
        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        IBaseServis baseServis = new BaseManager();
        public bool secildi = false;
        public Entities.Base _baseEntity= new Entities.Base();
        private Novu _nov;
        public FrmBase(Novu nov)
        {
            InitializeComponent();
            baseServis.ContextYarad(true);
            _nov = nov;
            gridControl1.DataSource = baseServis.Birlesdirme(x => x.Novu == nov.ToString());
            TerifBindings();
            BasligMelumat();
        }

        public enum Novu
        {
            KitabNovu,
            Sektor,
            MektebNovu
        }
        private void BasligMelumat()
        {
            switch (_nov)
            {
                case Novu.KitabNovu:
                    Kitablar.Text = "Kitab Növləri";
                    break;
                case Novu.Sektor:
                    Kitablar.Text = "Sektor Seçimi";
                    break;
                case Novu.MektebNovu:
                    Kitablar.Text = "Məktəb Növü Seçimi";
                    break;
            }
        }
        private void TerifBindings()
        {
            txtTerif.DataBindings.Clear();
            txtTerifAciqlama.DataBindings.Clear();
            txtTerif.DataBindings.Add("Text", _baseEntity, "Tanim", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTerifAciqlama.DataBindings.Add("Text", _baseEntity, "Aciqlama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void MelumatAc()
        {
            btnElave.Enabled = false;
            btnEdit.Enabled = false;
            btnSil.Enabled = false;
            btnYaddaSaxla.Enabled = true;
            btnImtina.Enabled = true;
            groupControl1.Visible = true;
            btnSec.Enabled = false;
            gridControl1.Enabled = false;
        }
        private void MelumatBagla()
        {
            btnElave.Enabled = true;
            btnEdit.Enabled = true;
            btnSil.Enabled = true;
            btnYaddaSaxla.Enabled = false;
            btnImtina.Enabled = false;
            groupControl1.Visible = false;
            gridControl1.Enabled = true;
            btnSec.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MelumatAc();
            _baseEntity =(Entities.Base)gridView1.GetFocusedRow();
            TerifBindings();
        }

        private void btnImtina_Click(object sender, EventArgs e)
        {
            _baseEntity = null;
            MelumatBagla();
        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            _baseEntity.Novu = _nov.ToString();
            if (baseServis.AddOrUpdate(_baseEntity) != null)
            {
                baseServis.Save();
                MelumatBagla();
            }
        }

        private void btnElave_Click(object sender, EventArgs e)
        {
            MelumatAc();
            _baseEntity = new Entities.Base();
            TerifBindings();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secildi = true;
            _baseEntity = (Entities.Base)gridView1.GetFocusedRow();
            this.Close();
        }
    }
}