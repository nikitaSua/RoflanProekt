using BLL.DtoModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.Validators
{
	public class LoginValidator : AbstractValidator<RegisterModel>
	{
		public LoginValidator()
		{
			RuleFor(x => x.Email).EmailAddress().NotNull();
			RuleFor(x => x.Password).Length(8, 25).NotNull();
		}
	}
}

