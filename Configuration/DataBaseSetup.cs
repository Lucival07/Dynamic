using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mechanics.Configuration;

namespace Dynamic.Configuration
{
    public static class DataBaseSetup
    {

        public static IServiceCollection AddDataBaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentException(nameof(services));

            services.AddDbContext<ApplicationDbContext>(options => options.UseMySQL(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

    }
}
