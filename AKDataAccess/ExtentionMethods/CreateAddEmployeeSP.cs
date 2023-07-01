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
    public static class CreateAddEmployeeSP
    {
        public static void CreateAddEmployeeStoredProcedure(this IConfiguration configuration)
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
CREATE PROCEDURE [dbo].[spAddEmployee]
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Department VARCHAR(50),
    @Salary DECIMAL(10, 2),
    @EmployeeID INT OUTPUT
AS
BEGIN
    DECLARE @InsertedRows TABLE (EmployeeID INT)
    
    INSERT INTO Employees (FirstName, LastName, Department, Salary)
    OUTPUT inserted.EmployeeID INTO @InsertedRows
    VALUES (@FirstName, @LastName, @Department, @Salary)

    SELECT @EmployeeID = EmployeeID FROM @InsertedRows
END";

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
