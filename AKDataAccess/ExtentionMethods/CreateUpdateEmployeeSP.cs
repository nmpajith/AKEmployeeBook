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
    public static class CreateUpdateEmployeeSP
    {
        public static void CreateUpdateEmployeeStoredProcedure(this IConfiguration configuration)
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
CREATE PROCEDURE [dbo].[spUpdateEmployee]
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Department VARCHAR(50),
    @Salary DECIMAL(10, 2)
AS
BEGIN
    UPDATE Employees
    SET FirstName = @FirstName,
        LastName = @LastName,
        Department = @Department,
        Salary = @Salary
    WHERE EmployeeID = @EmployeeID
END";

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
