using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoIntegradorII.Application.Interfaces;
using ProjetoIntegradorII.Application.Mappings;
using ProjetoIntegradorII.Application.Services;
using ProjetoIntegradorII.Domain.Interfaces;
using ProjetoIntegradorII.Infra.Data.Context;
using ProjetoIntegradorII.Infra.Data.Repositories;

namespace ProjetoIntegradorII.Infra.Ioc
{
    public static class DependecyInjectionAPI
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly("ProjetoIntegradorII.Api");
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null);

                }));

            services.AddScoped<IAdressRepository, AdressRepository>();
            services.AddScoped<IBeneficiaryRepository, BeneficiaryRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ITitleRepository, TitleRepository>();
            services.AddScoped<IBeneficiaryService, BeneficiaryService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ITitleService, TitleService>();  

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            var myhandlers = AppDomain.CurrentDomain.Load("ProjetoIntegradorII.Application");

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(myhandlers));

            return services;
        }
    }
}
