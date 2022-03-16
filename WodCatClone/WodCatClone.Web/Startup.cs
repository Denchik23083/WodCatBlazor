using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WodCatClone.Db;
using WodCatClone.Logic.ActionsService.ExerciseService;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.UserService;
using WodCatClone.WebDb.ActionsRepository.ExercisesRepository;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;
using WodCatClone.WebDb.AuthRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IExercisesService, ExercisesService>();
            services.AddScoped<IExercisesRepository, ExercisesRepository>();
            services.AddScoped<IWorkoutsService, WorkoutsService>();
            services.AddScoped<IWorkoutsRepository, WorkoutsRepository>();
            services.AddScoped<IResultWorkoutsService, ResultWorkoutsService>();
            services.AddScoped<IResultWorkoutsRepository, ResultWorkoutsRepository>();

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<WodCatCloneContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("WodCatClone");

                options.UseSqlServer(connectionString);
            });
        }

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
