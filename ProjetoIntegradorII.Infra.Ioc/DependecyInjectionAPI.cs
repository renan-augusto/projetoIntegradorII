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
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IAdressRepository, AdressRepository>();
            services.AddScoped<IBeneficiaryRepository, BeneficiaryRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ITitleRepository, TitleRepository>();
            services.AddScoped<IBeneficiaryService, BeneficiaryService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<ITitleService, TitleService>();  

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            var myhandlers = AppDomain.CurrentDomain.Load("ProjetoIntegradorII.Application");

            //services.AddMediatR(myhandlers);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(myhandlers));

            return services;
        }
    }
}
