using Employees.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DataAccess.Concrete.EntityFramework
{
    public class EmployeesContext:DbContext 
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
