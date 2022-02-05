using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop4.Bl.Dto;

namespace WorkShop4.Bl.Validators.Employee
{
    public class EmployeeValidator : BaseValidator<EmployeeDto>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Salary)
                .GreaterThan(15000)
                .WithMessage("Eso no e cualto, subale ese sueldo");

            RuleFor(x => x.Person.Name)
                .NotEmpty()
                .When(x => x.Salary > 15000)
                .When(x => x.Salary < 30000)
                .WithErrorCode("5513505351")
                .WithMessage("Pongale nombre que esta entre 15 y 30");
                
        }
    }
}
