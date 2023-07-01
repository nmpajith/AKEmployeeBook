using AKDataAccess.Persistence.Repositories.Contracts;
using System.Data.SqlClient;
using System.Data;
using AKCommon.Models;
using AKCommon.Exceptions;

namespace AKDataAccess.Persistence.Repositories.Implementation
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task AddAsync(Employee employee)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spAddEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@Department", employee.Department);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);

                    var employeeIdParameter = new SqlParameter("@EmployeeID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(employeeIdParameter);

                    await command.ExecuteNonQueryAsync();

                    if (employeeIdParameter.Value != DBNull.Value)
                    {
                        employee.EmployeeID = (int)employeeIdParameter.Value;
                    }
                }
            }
        }

        public async Task UpdateAsync(Employee employee)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spUpdateEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@Department", employee.Department);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<Employee> GetByIdAsync(int employeeId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spGetEmployeeById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@EmployeeID", employeeId);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            var employee = new Employee
                            {
                                EmployeeID = (int)reader["EmployeeID"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Department = (string)reader["Department"],
                                Salary = (decimal)reader["Salary"]
                            };

                            return employee;
                        }
                    }
                }
            }
            throw new NotFoundException("Employee not found");
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("spGetAllEmployees", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        var employees = new List<Employee>();

                        while (reader.Read())
                        {
                            var employee = new Employee
                            {
                                EmployeeID = (int)reader["EmployeeID"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Department = (string)reader["Department"],
                                Salary = (decimal)reader["Salary"]
                            };

                            employees.Add(employee);
                        }

                        return employees;
                    }
                }
            }
        }
    }
}
