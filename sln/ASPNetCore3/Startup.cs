using ASPNetCore3.IServices;
using ASPNetCore3.Middleware;
using ASPNetCore3.Models;
using ASPNetCore3.Models.Configuration;
using ASPNetCore3.ServiceImpl;
using Domain;
using ExternalAPIs.Contracts;
using ExternalAPIs.GoogleDriveAPI;
using Infrastructure;
using Infrastructure.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            var authConfig = Configuration.GetSection("ExternalLogins").Get<List<ExternalLogin>>();

            services.AddAuthentication()
                .AddGoogle(options => {
                    var googleAuth = authConfig.FirstOrDefault(x => x.Provider.ToLower() == "google");
                    options.ClientId = googleAuth.ClientID;
                    options.ClientSecret = googleAuth.ClientSecret;
                })
                .AddFacebook(options => {
                    var googleAuth = authConfig.FirstOrDefault(x => x.Provider.ToLower() == "facebook");
                    options.ClientId = googleAuth.ClientID;
                    options.ClientSecret = googleAuth.ClientSecret;
                });

            services.AddControllersWithViews();

            services.AddScoped<IGoogleDriveAPI, GoogleDriveAPI>();

            services.AddInfrastructureServices();

            services.AddRazorPages();
            services.AddSwaggerGen();

            services.AddTransient<SeedData>();

            services.Configure<MailConfig>(Configuration.GetSection("MailConfig"));
            services.Configure<ExternalLogin>(Configuration.GetSection("ExternalLogins"));

            services.AddTransient<IEmailSender, MailService>();

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext dbContext, SeedData seeder)
        {
            app.UseMiddleware(typeof(VisitorCounterMiddleware));

            if (true || env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            seeder.Initialize().Wait();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

        }
    }

    public class SeedData
    {
        private ApplicationDbContext _dbContext;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public SeedData(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task Initialize()
        {
            var context = _dbContext;
            await context.Database.MigrateAsync();
            var roles = new string[] { "Boss", "SuperAdmin", "Admin", "Moderator", "NormalUser" };

            foreach (string role in roles)
            {
                if (await _roleManager.FindByNameAsync(role) == null)
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var boss = await _userManager.FindByEmailAsync("nvthinh09t4@gmail.com");
            if (boss == null)
            {
                var user = new ApplicationUser {
                    Email = "nvthinh09t4@gmail.com",
                    NormalizedEmail = "nvthinh09t4@gmail.com",
                    UserName = "Thinh",
                    NormalizedUserName = "Thinh",
                    PhoneNumber = "+84945318379",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };

                var password = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = password.HashPassword(user, "Protoss123@");

                await _userManager.CreateAsync(user);
                await _userManager.AddToRoleAsync(user, "Boss");
            }

        }
    }
}
