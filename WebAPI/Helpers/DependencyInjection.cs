using DataAccess.Data;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using Business.Abstract;
using Business.Concrete;
using DataAccess.EfManagement;
using Core.DataAccess.Concrete;

namespace WebAPI.Helpers
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccess(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<NorthwindDbContext>(options =>
                 options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<INorthwindDbContext>(provider => provider.GetRequiredService<NorthwindDbContext>());

            services.AddScoped<ICustomerManager, CustomerManager>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();

            return services;
        }
    }
}
