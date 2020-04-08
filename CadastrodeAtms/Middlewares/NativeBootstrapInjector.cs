using CadastrodeAtms.DAO;
using CadastrodeAtms.DAO.Interface;
using CadastrodeAtms.DbConn;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.Middlewares
{
    public static class NativeBootstrapInjector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<Conexao>();
            services.AddSingleton<ILoggerFactory, LoggerFactory>();
            services.AddScoped<IAtmDAO, AtmDAO>();
            services.AddScoped<IMunicipioDAO, MunicipioDAO>();
            services.AddScoped<IUfDAO, UfDAO>();
        }
    }
}
