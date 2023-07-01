using AKCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKDataAccess.Persistence.Repositories.Contracts
{
    internal interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetAllAsync();
        public Task AddAsync(Employee employee);
        public Task UpdateAsync(Employee employee);
        public Task<Employee> GetByIdAsync(int employeeId);
    }
}
