using Microsoft.EntityFrameworkCore;
using FitnessTracker.Models.Exercise;

namespace FitnessTracker.Models.SeedData.Exercise
{
    public static class WorkoutSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workout>().HasData(
                new Workout
                {
                    WorkoutId = 1,
                    UserID = 1,
                    WorkoutName = "Push-Monday",
                    Type = WorkoutType.Strength,
                    WorkoutDate = new DateTime(2025, 02, 17)
                },
                new Workout
                {
                    WorkoutId = 2,
                    UserID = 1,
                    WorkoutName = "Pull-Tuesday",
                    Type = WorkoutType.Strength,
                    WorkoutDate = new DateTime(2025, 02, 18)
                },
                new Workout
                {
                    WorkoutId = 3,
                    UserID = 1,
                    WorkoutName = "Legs",
                    Type = WorkoutType.Strength,
                    WorkoutDate = new DateTime(2025, 02, 19)
                },
                new Workout
                {
                    WorkoutId = 4,
                    UserID = 1,
                    WorkoutName = "Push-Thursday",
                    Type = WorkoutType.Strength,
                    WorkoutDate = new DateTime(2025, 02, 20)
                },
                new Workout
                {
                    WorkoutId = 5,
                    UserID = 1,
                    WorkoutName = "Pull-Friday",
                    Type = WorkoutType.Strength,
                    WorkoutDate = new DateTime(2025, 02, 21)
                }

                );
        }
    }
}
