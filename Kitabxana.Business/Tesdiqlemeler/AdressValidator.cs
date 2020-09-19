using FluentValidation;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Tesdiqlemeler
{
    public class AdressValidator:AbstractValidator<Unvan>
    {
        public AdressValidator()
        {
            //RuleFor(x => x.Adres).NotEmpty().WithMessage("Adress Bos Ola bilmez");
        }
    }
}
