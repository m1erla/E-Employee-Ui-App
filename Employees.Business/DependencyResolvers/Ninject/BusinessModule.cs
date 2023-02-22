using Employees.Business.Abstract;
using Employees.Business.Concrete;
using Employees.DataAccess.Abstract;
using Employees.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();
            Bind<IEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();

        }
    }
}
