using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data2.EF;
using Web.Service2.Data;
using Web.Service2.ManageStation;

namespace Web.BackendManageApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Web Solution", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });
            });

           
            services.AddDbContext<apom_app_svContext>(options =>
               options.UseNpgsql(Configuration.GetConnectionString("apom_app_svContext"),
    x => x.UseNetTopologySuite()));

            //services.AddIdentity<ManageUser, ManageRole>()
            //    .AddEntityFrameworkStores<ManageDbContext>()
            //    .AddDefaultTokenProviders();
            services.AddControllers();
            services.AddCors();
            services.AddTransient<IAGroupService, AGroupService>();
            services.AddTransient<IAComponentGeotiffDailyService, AComponentGeotiffDailyService>();
            services.AddTransient<IAComponentService, AComponentService>();
            services.AddTransient<IAComponentStationDailyService, AComponentStationDailyService>();
            services.AddTransient<IAGroupComponentService, AGroupComponentService>();
            services.AddTransient<IdataContext, dataContext>();
            //services.AddCors(options => options.AddPolicy("ExposeResponseHeaders",
            //p =>
            //{
            //    p.WithOrigins("http://localhost:8080") // single origin THIS MUST BE THE SAME OF YOUR ANGULAR APPLICATION (not your ASP.NET Core app address)
            //     .AllowAnyMethod() // any method
            //     .AllowAnyHeader() // any header is *allowed*
            //     .AllowCredentials() // credentials allowed
            //     .WithExposedHeaders("Content-Disposition"); // content-disposition is *exposed* (and allowed because of AllowAnyHeader)
            //}));
            //service moi
            services.AddTransient<IAGroupService, AGroupService>();
            services.AddTransient<IAComponentGeotiffDailyService, AComponentGeotiffDailyService>();
            services.AddTransient<IAComponentService, AComponentService>();
            services.AddTransient<IAComponentStationDailyService, AComponentStationDailyService>();
            services.AddTransient<IAGroupComponentService, AGroupComponentService>();
            services.AddTransient<IdataContext, dataContext>();
            services.AddTransient<Web.Service2.Common.IStorageService, Web.Service2.Common.FileStorageService>();
 
       
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            
            string issuer = Configuration.GetValue<string>("Tokens:Issuer");
            string signingKey = Configuration.GetValue<string>("Tokens:Key");
            byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = issuer,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
                };
            });
        
    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseRouting();

            app.UseCors(o => o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().WithExposedHeaders("Content-Disposition"));
            //app.UseCors();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Web V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
