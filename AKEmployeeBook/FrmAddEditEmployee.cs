using AKCommon.Models;
using AKDataAccess.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKEmployeeBook
{
    public partial class FrmAddEditEmployee : Form
    {
        private readonly IEmployeeService _employeeService;
        public bool IsCancelled = true;
        private bool _isUpdateMode = false;

        public Employee Employee { get; set; } = new Employee();
        public FrmAddEditEmployee(IEmployeeService employeeService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            textBoxEmployeeID.DataBindings.Add("Text", Employee, "EmployeeID");
            textBoxFirstName.DataBindings.Add("Text", Employee, "FirstName");
            textBoxLastName.DataBindings.Add("Text", Employee, "LastName");
            textBoxDepartment.DataBindings.Add("Text", Employee, "Department");
            textBoxSalary.DataBindings.Add("Text", Employee, "Salary");
        }

        public void ShowDialog(Employee employee)
        {
            if (employee == null)
            {
                return;
            }
            UpdateEmployee(employee);
            buttonOk.Text = "Update";
            _isUpdateMode = true;
            labelTitle.Text = $"Update Employee: {employee.FirstName} {employee.LastName}";
            this.Text = labelTitle.Text;
            this.ShowDialog();
        }

        public void ShowDetailDialog(Employee employee)
        {
            if (employee == null)
            {
                return;
            }
            UpdateEmployee(employee);
            buttonOk.Visible = false;
            buttonCancel.Text = "Ok";
            textBoxFirstName.ReadOnly = true;
            textBoxLastName.ReadOnly = true;
            textBoxDepartment.ReadOnly = true;
            textBoxSalary.ReadOnly = true;
            labelTitle.Text = $"Details of Employee: {employee.FirstName} {employee.LastName}";
            this.Text = labelTitle.Text;
            this.ShowDialog();
        }

        private void UpdateEmployee(Employee employee)
        {
            Employee.EmployeeID = employee.EmployeeID;
            Employee.FirstName = employee.FirstName;
            Employee.LastName = employee.LastName;
            Employee.Department = employee.Department;
            Employee.Salary = employee.Salary;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            var validator = new EmployeeValidator();
            var validationResult = validator.Validate(Employee);

            if (validationResult.IsValid)
            {
                if (_isUpdateMode)
                {
                    await _employeeService.UpdateEmployeeAsync(Employee);
                }
                else
                {
                    await _employeeService.AddEmployeeAsync(Employee);
                }
                this.Close();
                IsCancelled = false;
            }
            else
            {
                labelError.Text = validationResult.Errors.FirstOrDefault()!.ErrorMessage;
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            labelError.Text = "";
        }
    }
}
