using BigMuscleShop.Application.Contracts;
using BigMuscleShop.Core.Data;
using BigMuscleShop.Infractructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Infractructure
{
    public static class InfractructureServicesConfiguration
    {
        public static IServiceCollection ConfigureInfractructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddTransient<IApplicationDbContext, ApplicationDbContext>();

            return services;
        }
    }
}
