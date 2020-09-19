using FluentValidation;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Tesdiqlemeler
{
    public class MuellifValidator:AbstractValidator<Muellif>
    {
        public MuellifValidator()
        {
            //RuleFor(x => x.Adi).NotEmpty().WithMessage("Muellif Adi Bos Kecile Bilmez");
        }
    }
}
