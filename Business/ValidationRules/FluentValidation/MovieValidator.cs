using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(m => m.Description).NotEmpty();
            RuleFor(m=>m.StartDate).NotEmpty();
            RuleFor(m=>m.EndDate).NotEmpty();
            RuleFor(m => m.Price).NotEmpty();
        }
    }
}
