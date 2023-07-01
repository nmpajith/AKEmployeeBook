using AKDataAccess.Persistence.Repositories.Contracts;
using AKDataAccess.Persistence.Repositories.Implementation;
using AKDataAccess.Services.Contracts;
using AKDataAccess.Services.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AKDataAccess
{
    public sealed class CompositionRoot
    {
        public static void RegisterDependencies(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("AKDataAccess"); 
            services.AddScoped<IEmployeeRepository>(provider =>
                new EmployeeRepository(connectionString));
            services.AddScoped<IEmployeeService, EmployeeService>();
        }
    }
}
