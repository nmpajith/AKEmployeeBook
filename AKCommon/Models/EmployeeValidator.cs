using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKCommon.Models
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(50).WithMessage("First name must not exceed 50 characters.");

            RuleFor(e => e.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(50).WithMessage("Last name must not exceed 50 characters.");

            RuleFor(e => e.Department)
                .NotEmpty().WithMessage("Department is required.")
                .MaximumLength(50).WithMessage("Department must not exceed 50 characters.");

            RuleFor(e => e.Salary)
                .NotEmpty().WithMessage("Salary is required.")
                .GreaterThan(0).WithMessage("Salary must be greater than zero.");
        }
    }
}
