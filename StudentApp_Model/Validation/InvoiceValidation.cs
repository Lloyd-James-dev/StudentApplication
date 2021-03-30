using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model.Validation {
    public class InvoiceValidation : AbstractValidator<Invoice> {

        public InvoiceValidation() {
            //RuleFor(a => a.Debit).GreaterThan(0).When(a => a.Credit.Equals(0));
            //RuleFor(a => a.Credit).GreaterThan(0).When(a => a.Debit.Equals(0));
            // RuleFor(a => a.Credit).NotEmpty().When(a => string.IsNullOrEmpty(a.Debit));
        }
    }
}
