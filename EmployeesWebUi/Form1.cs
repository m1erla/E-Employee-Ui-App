using Employees.Business.Abstract;
using Employees.Business.DependencyResolvers.Ninject;
using Employees.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesWebUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }
        private IEmployeeService _employeeService;

        private void LoadEmployeesTitle() 
        {
            cbxTıtle.DataSource = _employeeService.GetAll();
            cbxTıtle.DisplayMember = "Title"; 
            cbxTıtle.ValueMember= "Title";

            

            cbxUpdateTitle.DataSource = _employeeService.GetAll();
            cbxUpdateTitle.DisplayMember = "Title";
            cbxUpdateTitle.ValueMember= "Title";

        }
        private void LoadEmployees() 
        { dgwEmployee.DataSource = _employeeService.GetAll(); }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadEmployeesTitle();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeService.HireAnEmployee(new Employee
                {
                    FirstName = tbxEmployeeFirstNameAdd.Text,
                    LastName = tbxEmployeeLastNameAdd.Text,
                    Title = Convert.ToString(cbxTıtle.SelectedValue),
                    Address = tbxAddAdress.Text,
                    City = tbxAddCity.Text,
                    Country= tbxAddCountry.Text,
                    PostalCode = tbxAddPostalCode.Text,  
                     
                });
                MessageBox.Show("New Employee Added");
                LoadEmployees();

            }
            catch (Exception exception)
            {
                
                MessageBox.Show(exception.Message);
            }
           

        }

        private void dgwEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwEmployee.CurrentRow;
            tbxUpdatePostalCode.Text = Convert.ToString(row.Cells[5].Value.ToString());
            tbxUpdateCity.Text = Convert.ToString(row.Cells[7].Value.ToString());
            tbxUpdateCountry.Text = Convert.ToString(row.Cells[4].Value.ToString());
            tbxUpdateAdress.Text = Convert.ToString(row.Cells[6].Value.ToString());
            tbxUpdateFirstName.Text = row.Cells[3].Value.ToString();
            tbxUpdateLastName.Text = row.Cells[2].Value.ToString();
            cbxUpdateTitle.Text = row.Cells[1].Value.ToString();
            
            
        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            _employeeService.FireAnEmployee(new Employee 
            {
              EmployeeId = Convert.ToInt32(dgwEmployee.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Fired an Employee");
            LoadEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeService.Update(new Employee
                {
                    EmployeeId = Convert.ToInt32(dgwEmployee.CurrentRow.Cells[0].Value),
                    FirstName = tbxUpdateFirstName.Text,
                    LastName = tbxUpdateLastName.Text,
                    Title = Convert.ToString(cbxUpdateTitle.SelectedValue),
                    Address = tbxUpdateAdress.Text,
                    Country = tbxUpdateCountry.Text,
                    City = tbxUpdateCity.Text,
                    PostalCode = tbxUpdatePostalCode.Text
                   
                });
                MessageBox.Show("Updated an Employee Data!");
                LoadEmployees();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }
            
        }

    }
}
