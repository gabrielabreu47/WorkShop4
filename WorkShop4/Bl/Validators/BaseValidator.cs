using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkShop4.Bl.Validators
{
    public interface IBaseValidator : IValidator
    {

    }
    public class BaseValidator<T> : AbstractValidator<T>, IBaseValidator
    {
        public virtual string[] GetRulerelativeName(object dto)
        {
            return new string[] { "default" };
        }
    }
}
