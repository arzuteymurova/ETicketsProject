using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ActorValidator:AbstractValidator<Actor>
    {
        public ActorValidator()
        {
            RuleFor(a => a.FullName).NotEmpty();
            RuleFor(a => a.ProfilePictureUrl).NotEmpty();
        }
    }
}
