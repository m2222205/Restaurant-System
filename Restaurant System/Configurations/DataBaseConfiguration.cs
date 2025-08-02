using Microsoft.EntityFrameworkCore;
using Restaurant.Infastructure;
using System;

namespace Restaurant_System.Configurations
{
    public static class DatabaseConfiguration
    {
        public static void ConfigureDB(this WebApplicationBuilder builder)
        {
            if (builder.Environment.EnvironmentName == "Testing")
                return;

            var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

            builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(connectionString));
        }
    }

}
