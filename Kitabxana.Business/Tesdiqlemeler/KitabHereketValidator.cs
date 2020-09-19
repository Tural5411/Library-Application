using FluentValidation;
using Kitabxana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabxana.Business.Tesdiqlemeler
{
    public class KitabHereketValidator:AbstractValidator<KitabHereket>
    {
        public KitabHereketValidator()
        {
            //RuleFor(x => x.Aciqlama);
        }
    }
}
