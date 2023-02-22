using Employees.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DataAccess.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
    }
}
