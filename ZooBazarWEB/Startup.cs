using DataAccessLayer;
using Domain.Manager;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace TopTierReviewWeb

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
            services.AddRazorPages(); // Add Razor Pages support

            // Register UserManager with its dependencies
            services.AddScoped<UserDB>();
            services.AddScoped<TicketManager>();

            services.AddSession();
            services.AddHttpContextAccessor();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
           .AddCookie(options =>
           {
               options.LoginPath = "/Login";
               options.LogoutPath = "/Logout";
               options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
               options.SlidingExpiration = true;
           });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); // Map Razor Pages
            });
        }
    }
}
