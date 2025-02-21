using FitnessTracker.Models.Exercise;
using FitnessTracker.Models.Nutrition;
using FitnessTracker.Models.SeedData.Exercise;
using FitnessTracker.Models.SeedData.User;
using FitnessTracker.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<ExerciseSet> ExerciseSets {  get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<UserInfo> Users { get; set; }

        public DbSet<DailySummary> DailySummary { get; set; }
        public DbSet<FoodEntry> FoodEntries { get; set; }
        public DbSet<NutritionGoal> NutritionGoal { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            CategorySeedData.Seed(modelBuilder);
            ExerciseSeedData.Seed(modelBuilder);
            SetSeedData.Seed(modelBuilder);
            WorkoutSeedData.Seed(modelBuilder);
            UserSeedData.Seed(modelBuilder);
        }
    }
}
