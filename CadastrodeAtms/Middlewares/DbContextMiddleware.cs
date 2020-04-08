using CadastrodeAtms.DbConn;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.Middlewares
{
    public static class DbContextMiddleware
    {

        public static void AddDbContextMiddleware(this IServiceCollection services,IConfiguration configuration)
        {

            services.AddDbContext<Conexao>(options =>
            {

                var connectionString = configuration.GetConnectionString("DefaultConnection");

                options.UseSqlite(connectionString);
            });

        }
    }
}
