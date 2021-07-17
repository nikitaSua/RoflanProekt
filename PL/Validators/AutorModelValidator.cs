using BLL.DtoModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.Validators
{
    public class AutorModelValidator:AbstractValidator<AutorModel>
    {
        public  AutorModelValidator()
        {
            RuleFor(x => x.Name).Length(3, 25).NotNull();
        }
    }
}
