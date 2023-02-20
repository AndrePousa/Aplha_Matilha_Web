using Alpha_Matilha.Aplication.Interfaces;
using Alpha_Matilha.Aplication.Mappings;
using Alpha_Matilha.Aplication.Services;
using Alpha_Matilha.Domain.Interfaces;
using Alpha_Matilha.Infrastructure.Context;
using Alpha_Matilha.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Matilha.Shared.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            //services.AddDbContext<AlphaMatilhaContext>(options =>
            // options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            //), b => b.MigrationsAssembly(typeof(AlphaMatilhaContext).Assembly.FullName)));

            //services.AddDbContext<ApplicationDbContext>(options =>
            //   options.UseMySql(configuration.GetConnectionString("DefaultConnection"),
            //         new MySqlServerVersion(new Version(8, 0, 11))));

            services.AddScoped<IAddress_PersonRepository, Address_PersonRepository>();
            services.AddScoped<IAddress_PersonService, Address_PersonService>();

            //services.AddScoped<IProdutoRepository, ProdutoRepository>();
            //services.AddScoped<IProdutoService, ProdutoService>();
            //services.AddScoped<ICategoriaService, CategoriaService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;

        }
    }
}
