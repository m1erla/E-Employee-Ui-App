using Employees.Business.Abstract;
using Employees.Business.Utilities;
using Employees.Business.ValidationRules;
using Employees.DataAccess.Abstract;
using Employees.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal) 
        { _employeeDal = employeeDal; }
        public void FireAnEmployee(Employee employee)
        {
            _employeeDal.EjectAnEmployee(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public List<Employee> GetEmployeeByDepartment(int employeeId)
        {
            return _employeeDal.GetAll(p => p.Title.ToLower().Contains(employeeId.ToString()));
        }

       

        public List<Employee> GetEmployeeByEmployeeFirstName(string employeeFirstName)
        {
            return _employeeDal.GetAll(p => p.FirstName == employeeFirstName);
        }

        public List<Employee> GetEmployeeByEmployeeLastName(string employeeLastName)
        {
            return _employeeDal.GetAll(p => p.LastName==employeeLastName);
        }

        //public List<Employee> GetEmployeeByEmployeeTitle(int employeeTitle)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Employee> GetEmployeeByEmployeeTitle(string employeeTitle)
        {
            return _employeeDal.GetAll(p => p.Title.ToLower().Contains(employeeTitle.ToLower()));
        }

        public void HireAnEmployee(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.HireAnEmployee(employee);
        }

        public void Update(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.UpdateAnEmloyee(employee);
        }
    }
}
