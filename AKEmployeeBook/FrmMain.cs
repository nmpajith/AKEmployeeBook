using AKCommon.Models;
using AKDataAccess.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace AKEmployeeBook
{
    public partial class FrmMain : Form
    {
        private readonly BindingSource _employeeBindingSource;
        private readonly BindingSource _departmentBindingSource;
        private readonly IEmployeeService _employeeService;
        private readonly IServiceProvider _serviceProvider;
        private bool _isCellClick;

        public FrmMain(IEmployeeService employeeService, IServiceProvider serviceProvider)
        {

            InitializeComponent();
            _employeeBindingSource = new BindingSource();
            _departmentBindingSource = new BindingSource();
            _employeeService = employeeService;
            dataGridView.DataSource = _employeeBindingSource;
            comboBoxDepartments.DataSource = _departmentBindingSource;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dataGridView.EnableHeadersVisualStyles = false;
            _serviceProvider = serviceProvider;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            var dataTable = CreateDataTableFromEmployees(employees);
            _employeeBindingSource.DataSource = dataTable;

            UpdateDepartmentComboBox(dataTable);
            comboBoxDepartments.SelectedItem = "All";
        }

        private DataTable CreateDataTableFromEmployees(IEnumerable<Employee> employees)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("EmployeeID", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Department", typeof(string));
            dataTable.Columns.Add("Salary", typeof(decimal));

            foreach (var employee in employees)
            {
                dataTable.Rows.Add(
                    employee.EmployeeID,
                    employee.FirstName,
                    employee.LastName,
                    employee.Department,
                    employee.Salary
                );
            }

            return dataTable;
        }

        private void UpdateDepartmentComboBox(DataTable dataTable)
        {
            var distinctDepartments = dataTable
                .AsEnumerable()
                .Select(r => r.Field<string>("Department"))
                .Distinct()
                .ToList();
            distinctDepartments.Add("All");
            comboBoxDepartments.DataSource = distinctDepartments;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var dataTable = _employeeBindingSource.DataSource as DataTable;
            var addEmployeeForm = _serviceProvider.GetRequiredService<FrmAddEditEmployee>();
            addEmployeeForm.ShowDialog();

            if (!addEmployeeForm.IsCancelled)
            {
                var newEmployee = addEmployeeForm.Employee;

                DataRow newRow = dataTable!.NewRow();
                newRow["EmployeeID"] = newEmployee.EmployeeID;
                newRow["FirstName"] = newEmployee.FirstName;
                newRow["LastName"] = newEmployee.LastName;
                newRow["Department"] = newEmployee.Department;
                newRow["Salary"] = newEmployee.Salary;

                dataTable.Rows.Add(newRow);
                var selectedItem = comboBoxDepartments.SelectedItem;
                UpdateDepartmentComboBox(dataTable);
                comboBoxDepartments.SelectedItem = selectedItem;
            }

            addEmployeeForm.Dispose();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private void comboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDepartments.SelectedItem != null && comboBoxDepartments.SelectedItem.ToString() != "All")
            {
                string selectedDepartment = comboBoxDepartments.SelectedItem.ToString()!;

                _employeeBindingSource.Filter = $"Department = '{selectedDepartment}'";
            }
            else
            {
                _employeeBindingSource.RemoveFilter();
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFilter.Text))
            {
                string selectedDepartment = textBoxFilter.Text;

                _employeeBindingSource.Filter = $"Department LIKE '%{selectedDepartment}%'";
            }
            else
            {
                _employeeBindingSource.RemoveFilter();
            }
        }

        private async void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _isCellClick = false;
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                var selectedRow = dataGridView.Rows[e.RowIndex];
                var dataRowView = selectedRow.DataBoundItem as DataRowView;

                if (dataRowView != null)
                {
                    var employeeDataRow = dataRowView.Row;
                    var employee = EmployeeFromDataRow(employeeDataRow);

                    var addEmployeeForm = _serviceProvider.GetRequiredService<FrmAddEditEmployee>();
                    addEmployeeForm.ShowDialog(employee);
                    await LoadDataAsync();
                }
            }
        }

        private Employee EmployeeFromDataRow(DataRow dataRow)
        {
            var employee = new Employee
            {
                EmployeeID = (int)dataRow["EmployeeID"],
                FirstName = (string)dataRow["FirstName"],
                LastName = (string)dataRow["LastName"],
                Department = (string)dataRow["Department"],
                Salary = (decimal)dataRow["Salary"]
            };

            return employee;
        }

        private async void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _isCellClick = true;
            await Task.Delay(200); // Adjust the delay duration as needed

            if (_isCellClick)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
                {
                    var selectedRow = dataGridView.Rows[e.RowIndex];
                    var dataRowView = selectedRow.DataBoundItem as DataRowView;

                    if (dataRowView != null)
                    {
                        var employeeDataRow = dataRowView.Row;
                        var employee = EmployeeFromDataRow(employeeDataRow);

                        var addEmployeeForm = _serviceProvider.GetRequiredService<FrmAddEditEmployee>();
                        addEmployeeForm.ShowDetailDialog(employee);
                    }
                }
                _isCellClick = false;
            }
        }
    }
}