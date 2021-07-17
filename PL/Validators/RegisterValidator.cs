using BLL.DtoModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.Validators
{
    public class RegisterValidator : AbstractValidator<RegisterModel>
    {
		public RegisterValidator()
		{
			RuleFor(x => x.Email).EmailAddress().NotNull();
			RuleFor(x => x.Password).Length(8,25).NotNull();
			RuleFor(x => x.Login).Length(4, 25).Matches("/ ^[a - z] + ([-_]?[a - z0 - 9] +){ 0,2}$/ i").NotNull();
			RuleFor(x => x.Name).Length(4, 25).NotNull();
		}
	}
}
