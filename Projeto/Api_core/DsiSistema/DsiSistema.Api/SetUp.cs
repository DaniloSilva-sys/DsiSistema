using DsiSistema.Api.Data;
using DsiSistema.Api.Data.Repository;
using DsiSistema.Api.Models.Interfaces.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using DsiSistema.Api.Security;

namespace DsiSistema.Api
{
    public static class SetUp
    {
        private const string ISSUER = "";
        private const string AUDIENCE = "";

        public static void ConfigureContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DsiContext>(x => x.UseMySql(configuration.GetConnectionString("conexao")));
        }

        public static void ConfigureMVC(this IServiceCollection services)
        {
            services.AddMvc(option => {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();

                option.Filters.Add(new AuthorizeFilter(policy));
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        public static void ConfigureControllers(this IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(x => 
                    x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "DsiSistemas", Version = "v1" });
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //c.IncludeXmlComments(xmlPath);
                //}
            }
            );
        }

        public static void ConfigureAuthentication(this IServiceCollection services)
        {
            var signConfiguration = new SigningConfigurations();
            services.AddSingleton(signConfiguration);

            var tokenConfigurations = new TokenConfigurations
            { 
                Audience = AUDIENCE,
                Issuer = ISSUER,
                Seconds = int.Parse(TimeSpan.FromDays(1).TotalSeconds.ToString())
            };
            services.AddSingleton(tokenConfigurations);

            services.AddAuthentication(x => {

                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => {

                var paramsValidation = x.TokenValidationParameters;
                paramsValidation.IssuerSigningKey = signConfiguration.SigningCredentials.Key;
                paramsValidation.ValidAudience = tokenConfigurations.Audience;
                paramsValidation.ValidIssuer = tokenConfigurations.Issuer;
                paramsValidation.ValidateIssuerSigningKey = true;
                paramsValidation.ValidateLifetime = true;
                paramsValidation.ClockSkew = TimeSpan.Zero;
            });


            services.AddAuthorization(x => {
                x.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser().Build());
            });
        }
    }
}
