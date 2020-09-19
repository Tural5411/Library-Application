using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using System.Threading.Tasks;
using Kitabxana.Entities;

namespace Kitabxana.Business.Tesdiqlemeler
{
   public class BarkodValidator:AbstractValidator<Barkod>
    {
        public BarkodValidator()
        {
            RuleFor(x => x.Barkodu).NotEmpty().WithMessage("Barkod Bos Ola Bilmez");
        }
    }
}
