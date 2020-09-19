using FluentValidation;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business
{
    public class KitabValidator:AbstractValidator<Kitab>
    {
        public KitabValidator()
        {
            RuleFor(c => c.KitabKodu).NotEmpty().WithMessage("Kitab Kodu Bos ola Bilmez");
            RuleFor(c => c.KitabAdi).NotEmpty().WithMessage("Kitab Adi Bos ola Bilmez");
            RuleFor(c => c.MuellifId).NotEmpty().WithMessage("Muellif Adi Bos ola Bilmez");
        }
    }
}
