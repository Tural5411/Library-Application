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
    public partial class FrmEnler : DevExpress.XtraEditors.XtraForm
    {
        IKitabHereketServis kitabHereketServis = new KitabHereketManager();

        public FrmEnler()
        {
            InitializeComponent();
            kitabHereketServis.ContextYarad(true);
            chartControl1.Series.Add("Ən Çox Oxunanlar", DevExpress.XtraCharts.ViewType.Bar);
            chartControl1.DataSource = kitabHereketServis.EnCoxOxunan(5);
            chartControl1.Series[0].ArgumentDataMember = "kitap.KitabAdi";
            chartControl1.Series[0].ValueDataMembers[0] = "OxunmaSayi";

            chartControl2.Series.Add("Ən Çox Oxuyanlar", DevExpress.XtraCharts.ViewType.Bar);
            chartControl2.DataSource = kitabHereketServis.EnCoxOxuyan(5);
            chartControl2.Series[0].ArgumentDataMember = "istfdci.Adi";
            chartControl2.Series[0].ValueDataMembers[0] = "OxunmaSayi";

            gridControlKitab.DataSource = kitabHereketServis.EnCoxOxunan(5);
            gridControl1.DataSource = kitabHereketServis.EnCoxOxuyan(5);
        }
    }
}