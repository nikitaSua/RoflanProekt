using BLL.DtoModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.Validators
{
    public class CourseModelValidator : AbstractValidator<CourseModel>
    {
        public CourseModelValidator()
        {
            
        }
       
    }
}
