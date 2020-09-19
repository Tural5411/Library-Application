using FluentValidation;
using Kitabxana.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitabxana.Business.Vasiteler
{
    public class TesdiqVasitesi
    {
        public bool Tesdiqle(IValidator validator, IEntity entity)
        {
            bool netice = true;
            var tesdiqlemekontrol = validator.Validate(entity);

            if (!tesdiqlemekontrol.IsValid)
            {
                string mesaj = null;
                foreach (var error in tesdiqlemekontrol.Errors)
                {
                    mesaj += error.ErrorMessage + "\n";
                }
                MessageBox.Show(mesaj);
            }

            return netice;
        }
    }
}
