using Microsoft.EntityFrameworkCore;
using FitnessTracker.Models.Exercise;

namespace FitnessTracker.Models.SeedData.Exercise
{
    public static class CategorySeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseCategory>().HasData(
                    new ExerciseCategory { CategoryId = 1, CategoryName = CategoryName.Abs },
                    new ExerciseCategory { CategoryId = 2, CategoryName = CategoryName.Back },
                    new ExerciseCategory { CategoryId = 3, CategoryName = CategoryName.Biceps },
                    new ExerciseCategory { CategoryId = 4, CategoryName = CategoryName.Cardio },
                    new ExerciseCategory { CategoryId = 5, CategoryName = CategoryName.Chest },
                    new ExerciseCategory { CategoryId = 6, CategoryName = CategoryName.Legs },
                    new ExerciseCategory { CategoryId = 7, CategoryName = CategoryName.Shoulders },
                    new ExerciseCategory { CategoryId = 8, CategoryName = CategoryName.Triceps }
                );
        }
    }
}
