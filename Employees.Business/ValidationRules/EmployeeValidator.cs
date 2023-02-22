using Employees.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {

        public EmployeeValidator() 
        {
           RuleFor(p=>p.FirstName).NotEmpty();
           RuleFor(p=>p.LastName).NotEmpty();
          // RuleFor(p=>p.Address).NotEmpty();
          // RuleFor(p=>p.City).NotEmpty();
           //RuleFor(p=>p.EmployeeID).NotEmpty();
        }
    }
}
