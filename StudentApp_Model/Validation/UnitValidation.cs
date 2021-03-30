using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model.Validation {
    public class UnitValidation : AbstractValidator<Unit> {

        public UnitValidation() {

            //RuleFor(u => u.Code).I

        }

    }
}
