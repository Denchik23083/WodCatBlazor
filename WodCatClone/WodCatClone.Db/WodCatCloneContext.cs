using Microsoft.EntityFrameworkCore;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Db
{
    public class WodCatCloneContext : DbContext
    {
        public WodCatCloneContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Exercises> Exercises { get; set; }

        public DbSet<Workouts> Workouts { get; set; }

        public DbSet<ResultWorkouts> ResultWorkouts { get; set; }

        public DbSet<Halls> Halls { get; set; }

        public DbSet<HallEmblem> HallEmblem { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<ArticlesEmblem> ArticlesEmblem { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Question> Question { get; set; }
        
        public DbSet<Answer> Answer { get; set; }
    }
}
