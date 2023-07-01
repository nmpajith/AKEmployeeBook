using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKDataAccess.ExtentionMethods
{
    public static class CreateGetAllEmployeesSP
    {
        public static void CreateGetAllEmployeesStoredProcedure(this IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("AKDataAccess");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    command.CommandText = @"
CREATE PROCEDURE [dbo].[spGetAllEmployees]
AS
BEGIN
    SELECT EmployeeID, FirstName, LastName, Department, Salary
    FROM Employees
END";

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

