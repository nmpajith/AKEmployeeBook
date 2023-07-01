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
    public static class CreateGetEmployeeByIdSP
    {
        public static void CreateGetEmployeeByIdStoredProcedure(this IConfiguration configuration)
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
CREATE PROCEDURE [dbo].[spGetEmployeeById]
    @EmployeeID INT,
    @FirstName VARCHAR(50) OUTPUT,
    @LastName VARCHAR(50) OUTPUT,
    @Department VARCHAR(50) OUTPUT,
    @Salary DECIMAL(10, 2) OUTPUT
AS
BEGIN
    SELECT
        @FirstName = FirstName,
        @LastName = LastName,
        @Department = Department,
        @Salary = Salary
    FROM
        Employees
    WHERE
        EmployeeID = @EmployeeID
END";

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
