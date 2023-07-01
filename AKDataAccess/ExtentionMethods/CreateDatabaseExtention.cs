using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace AKDataAccess.ExtentionMethods
{
    public static class CreateDatabaseExtention
    {
        public static void CreateDatabase(this IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("AKDataAccess");
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            string databaseName = builder.InitialCatalog;
            string initialCatalogStr = $"Initial Catalog={databaseName};";
            string dataSource = connectionString.Replace(initialCatalogStr, "");
            using (SqlConnection connection = new SqlConnection(dataSource))
            {
                connection.Open();

                string createDatabaseQuery = $"IF DB_ID('{databaseName}') IS NULL CREATE DATABASE {databaseName}";
                using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.ChangeDatabase(databaseName);

                string createTableQuery = @"CREATE TABLE Employees (
                                EmployeeID INT PRIMARY KEY IDENTITY(1,1),
                                FirstName VARCHAR(50),
                                LastName VARCHAR(50),
                                Department VARCHAR(50),
                                Salary DECIMAL(10, 2)
                            )";
                using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
