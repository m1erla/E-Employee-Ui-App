using Employees.DataAccess.Abstract;
using Employees.DataAccess.Concrete.EntityFramework;
using Employees.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DataAccess.Concrete
{
    public class EfEmployeeDal:EfEntityRepositoryBase<Employee,EmployeesContext>,IEmployeeDal
    {
    }
}
