using FluentValidation;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Tesdiqlemeler
{
    public class IstifadeciValidator:AbstractValidator<Istifadeci>
    {
        public IstifadeciValidator()
        {
            RuleFor(x => x.SinifId).NotEmpty().WithMessage("Sinif Bos Kecile Bilmez");
        }
    }
}
