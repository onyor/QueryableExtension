using DataAccess.Data;
using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;

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


            return services;
        }
    }
}
