using Microsoft.EntityFrameworkCore;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;

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
    }
}
