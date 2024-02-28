using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using StoreProject.Application.Contracts.Infrastructure;
using StoreProject.Application.Contracts.Infrastructure.Identity;
using StoreProject.Application.Contracts.Infrastructure.IReposiotry;
using StoreProject.Application.Contracts.Infrastructure.Payment;
using StoreProject.Application.Models;
using StoreProject.Application.Models.Identity;
using StoreProject.Domain.Entities;
using StoreProject.Infrastructure.Data;
using StoreProject.Infrastructure.Mail;
using StoreProject.Infrastructure.Repositories;
using StoreProject.Infrastructure.Services;
using StoreProject.Infrastructure.Services.PaymentService.VnPay;
using Stripe;
using System.Text;


namespace StoreProject.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            services.AddTransient<IEmailSender, EmailSender>();
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection")));

            StripeConfiguration.ApiKey = configuration.GetSection("Stripe:SecretKey").Get<string>();
			services.Configure<VnpayConfig>(
			  configuration.GetSection(VnpayConfig.ConfigName));
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // use aspnetcore identity 
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
	            options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();


			services.AddTransient<IVnPayService, VnPayService>();
			services.AddTransient<IAuthService, AuthService>();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        ValidIssuer = configuration["JwtSettings:Issuer"],
                        ValidAudience = configuration["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))
                    };
                });
            

            return services;
        }
    }


}
