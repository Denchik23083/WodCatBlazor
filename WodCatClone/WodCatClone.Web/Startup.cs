using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WodCatClone.Db;
using WodCatClone.Logic.ActionsService.ArticlesService;
using WodCatClone.Logic.ActionsService.EventsService;
using WodCatClone.Logic.ActionsService.ExercisesService;
using WodCatClone.Logic.ActionsService.HallsService;
using WodCatClone.Logic.ActionsService.ProgramsService;
using WodCatClone.Logic.ActionsService.WorkoutsService;
using WodCatClone.Logic.AuthService;
using WodCatClone.Logic.CallBackService;
using WodCatClone.Logic.UserService;
using WodCatClone.WebDb.ActionsRepository.ArticlesRepository;
using WodCatClone.WebDb.ActionsRepository.EventsRepository;
using WodCatClone.WebDb.ActionsRepository.ExercisesRepository;
using WodCatClone.WebDb.ActionsRepository.HallsRepository;
using WodCatClone.WebDb.ActionsRepository.ProgramsRepository;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;
using WodCatClone.WebDb.AuthRepository;
using WodCatClone.WebDb.CallBackRepository;
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
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IProgramsService, ProgramsService>();
            services.AddTransient<IProgramsRepository, ProgramsRepository>();
            services.AddTransient<IExercisesService, ExercisesService>();
            services.AddTransient<IExercisesRepository, ExercisesRepository>();
            services.AddTransient<IWorkoutsService, WorkoutsService>();
            services.AddTransient<IWorkoutsRepository, WorkoutsRepository>();
            services.AddTransient<IEventsService, EventsService>();
            services.AddTransient<IEventsRepository, EventsRepository>();
            services.AddTransient<IResultWorkoutsService, ResultWorkoutsService>();
            services.AddTransient<IResultWorkoutsRepository, ResultWorkoutsRepository>();
            services.AddTransient<IHallsService, HallsService>();
            services.AddTransient<IHallsRepository, HallsRepository>();
            services.AddTransient<IArticlesService, ArticlesService>();
            services.AddTransient<IArticlesRepository, ArticlesRepository>();
            services.AddTransient<ICallBackService, CallBackService>();
            services.AddTransient<ICallBackRepository, CallBackRepository>();

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<WodCatCloneContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("WodCatClone");

                options.UseSqlServer(connectionString);
            }, ServiceLifetime.Transient);

            services.AddDbContext<TestsWodCatCloneContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("TestsWodCatCloneDb");

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

            EnsureWodCatCloneDbCreated(app);
            EnsureTestsWodCatCloneDbCreated(app);
        }

        private void EnsureWodCatCloneDbCreated(IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();

            using var scope = scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<WodCatCloneContext>();

            context!.Database.EnsureCreated();
        }

        private void EnsureTestsWodCatCloneDbCreated(IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();

            using var scope = scopeFactory.CreateScope();
            var context = scope.ServiceProvider.GetService<TestsWodCatCloneContext>();

            context!.Database.EnsureCreated();
        }
    }
}
