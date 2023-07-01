using AKCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKDataAccess.Services.Contracts
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        public Task AddEmployeeAsync(Employee employee);
        public Task UpdateEmployeeAsync(Employee employee);
        public Task<Employee> GetEmployeeByIdAsync(int employeeId);
    }
}
