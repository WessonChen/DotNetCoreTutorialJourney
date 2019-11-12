using DotNetCoreTutorialJourney.Models;
using DotNetCoreTutorialJourney.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCoreTutorialJourney
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("EmployeeDBConnection")));

            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 3;
                options.Password.RequireNonAlphanumeric = false;

                options.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            }).AddXmlSerializerFormatters();

            services.AddAuthentication().
                AddGoogle(options =>
                {
                    options.ClientId = "88577239875-hl6h46k9g834d1ofginr9suei73a3mhm.apps.googleusercontent.com";
                    options.ClientSecret = "_y7e3IGOFdVGI3BEcuMjNDNv";
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("CreateRolePolicy",
                    policy => policy.RequireClaim("Create Role"));

                //options.AddPolicy("EditRolePolicy",
                //    policy => policy.RequireAssertion(context => AuthorizeAccess(context)));

                options.AddPolicy("EditRolePolicy", policy =>
                    policy.AddRequirements(new ManageAdminRolesAndClaimsRequirement()));

                options.AddPolicy("DeleteRolePolicy",
                    policy => policy.RequireClaim("Delete Role"));
            });

            services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();
            services.AddSingleton<IAuthorizationHandler, CanEditOnlyOtherAdminRolesAndClaimsHandler>();
            services.AddSingleton<IAuthorizationHandler, SuperAdminHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }

        private bool AuthorizeAccess(AuthorizationHandlerContext context)
        {
            return context.User.IsInRole("Admin") ||
                context.User.HasClaim(claim => claim.Type == "Edit Role" && claim.Value == "Edit Role");
            ;
        }
    }
}