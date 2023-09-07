using Microsoft.EntityFrameworkCore;
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
using WodCatClone.Web.Utilities.Mapper;
using WodCatClone.WebDb.ActionsRepository.ArticlesRepository;
using WodCatClone.WebDb.ActionsRepository.EventsRepository;
using WodCatClone.WebDb.ActionsRepository.ExercisesRepository;
using WodCatClone.WebDb.ActionsRepository.HallsRepository;
using WodCatClone.WebDb.ActionsRepository.ProgramsRepository;
using WodCatClone.WebDb.ActionsRepository.WorkoutsRepository;
using WodCatClone.WebDb.AuthRepository;
using WodCatClone.WebDb.CallBackRepository;
using WodCatClone.WebDb.UserRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProgramsService, ProgramsService>();
builder.Services.AddScoped<IProgramsRepository, ProgramsRepository>();
builder.Services.AddScoped<IExercisesService, ExercisesService>();
builder.Services.AddScoped<IExercisesRepository, ExercisesRepository>();
builder.Services.AddScoped<IWorkoutsService, WorkoutsService>();
builder.Services.AddScoped<IWorkoutsRepository, WorkoutsRepository>();
builder.Services.AddScoped<IEventsService, EventsService>();
builder.Services.AddScoped<IEventsRepository, EventsRepository>();
builder.Services.AddScoped<IHallsService, HallsService>();
builder.Services.AddScoped<IHallsRepository, HallsRepository>();
builder.Services.AddScoped<IArticlesService, ArticlesService>();
builder.Services.AddScoped<IArticlesRepository, ArticlesRepository>();
builder.Services.AddScoped<ICallBackService, CallBackService>();
builder.Services.AddScoped<ICallBackRepository, CallBackRepository>();

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<WodCatCloneContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("WodCatClone");

    options.UseSqlServer(connectionString);
});

var app = builder.Build();

using var scope = app.Services.CreateScope();

var context = scope.ServiceProvider.GetService<WodCatCloneContext>();

context!.Database.EnsureCreated();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
