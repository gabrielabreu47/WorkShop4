using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop4.Bl.Dto;

namespace WorkShop4.Bl.Validators.Person
{
    public class PersonValidator : BaseValidator<PersonDto>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Debe ingresar un nombre");
        }
    }
}
