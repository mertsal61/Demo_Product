using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class Customervalidator: AbstractValidator<Customer>
    {
        public Customervalidator()  
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Bilgisi Boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş bırakılamaz");
        }
    }
}
