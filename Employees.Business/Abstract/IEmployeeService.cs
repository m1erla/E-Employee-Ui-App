using Employees.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business.Abstract
{
    public interface IEmployeeService
    {
        void HireAnEmployee(Employee employee);
        void FireAnEmployee(Employee employee);
        List<Employee> GetAll();
        List<Employee> GetEmployeeByDepartment(int employeeId);
        List<Employee> GetEmployeeByEmployeeFirstName(string employeeFirstName);
        List<Employee> GetEmployeeByEmployeeLastName(string employeeLastName);
        List<Employee> GetEmployeeByEmployeeTitle(string employeeTitle);
        void Update(Employee employee);
        
    }
}
