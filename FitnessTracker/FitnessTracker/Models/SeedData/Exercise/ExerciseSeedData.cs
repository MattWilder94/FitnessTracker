using Microsoft.EntityFrameworkCore;
using FitnessTracker.Models.Exercise;

namespace FitnessTracker.Models.SeedData.Exercise
{
    public static class ExerciseSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercises>().HasData(
                    new Exercises
                    {
                        ExerciseId = 1,
                        CategoryId = 5,
                        ExerciseName = "Machine Chest Press"

                    },
                    new Exercises
                    {
                        ExerciseId = 2,
                        CategoryId = 5,
                        ExerciseName = "Decline Chest Press"

                    },
                    new Exercises
                    {
                        ExerciseId = 3,
                        CategoryId = 5,
                        ExerciseName = "Pec Deck"

                    },
                    new Exercises
                    {
                        ExerciseId = 4,
                        CategoryId = 5,
                        ExerciseName = "Bench Press"

                    },
                    new Exercises
                    {
                        ExerciseId = 5,
                        CategoryId = 5,
                        ExerciseName = "Incline Dumbbell Press"

                    },
                    new Exercises
                    {
                        ExerciseId = 6,
                        CategoryId = 5,
                        ExerciseName = "Incline Bench Press"

                    },
                    new Exercises
                    {
                        ExerciseId = 7,
                        CategoryId = 2,
                        ExerciseName = "Cable Row"

                    },
                    new Exercises
                    {
                        ExerciseId = 8,
                        CategoryId = 2,
                        ExerciseName = "Dumbbell Row"

                    },
                    new Exercises
                    {
                        ExerciseId = 9,
                        CategoryId = 2,
                        ExerciseName = "Pulldowns"

                    },
                    new Exercises
                    {
                        ExerciseId = 10,
                        CategoryId = 2,
                        ExerciseName = "Machine Seated Row"

                    },
                    new Exercises
                    {
                        ExerciseId = 11,
                        CategoryId = 2,
                        ExerciseName = "TBar Row"

                    },
                    new Exercises
                    {
                        ExerciseId = 12,
                        CategoryId = 3,
                        ExerciseName = "Dumbbell Bicep Curl"
                    },
                    new Exercises
                    {
                        ExerciseId = 13,
                        CategoryId = 3,
                        ExerciseName = "Hammer Curl"

                    },
                    new Exercises
                    {
                        ExerciseId = 14,
                        CategoryId = 3,
                        ExerciseName = "Single Arm Cable Curls"

                    },
                    new Exercises
                    {
                        ExerciseId = 15,
                        CategoryId = 3,
                        ExerciseName = "Concentration Curl"

                    },
                    new Exercises
                    {
                        ExerciseId = 16,
                        CategoryId = 6,
                        ExerciseName = "Barbell Squat"

                    },
                    new Exercises
                    {
                        ExerciseId = 17,
                        CategoryId = 6,
                        ExerciseName = "Hack Squat"

                    },
                    new Exercises
                    {
                        ExerciseId = 18,
                        CategoryId = 6,
                        ExerciseName = "Leg Curls"

                    },
                    new Exercises
                    {
                        ExerciseId = 19,
                        CategoryId = 6,
                        ExerciseName = "Leg Press"

                    },
                    new Exercises
                    {
                        ExerciseId = 20,
                        CategoryId = 6,
                        ExerciseName = "Leg Extensions"

                    },
                    new Exercises
                    {
                        ExerciseId = 21,
                        CategoryId = 6,
                        ExerciseName = "Calf Raises"

                    },
                    new Exercises
                    {
                        ExerciseId = 22,
                        CategoryId = 7,
                        ExerciseName = "Machine Shoulder Press"

                    },
                    new Exercises
                    {
                        ExerciseId = 23,
                        CategoryId = 7,
                        ExerciseName = "Dumbbell Shoulder Press"

                    },
                    new Exercises
                    {
                        ExerciseId = 24,
                        CategoryId = 7,
                        ExerciseName = "Dumbbell Shrugs"

                    },
                   new Exercises
                   {
                       ExerciseId = 25,
                       CategoryId = 7,
                       ExerciseName = "Face Pulls"

                   },
                   new Exercises
                   {
                       ExerciseId = 26,
                       CategoryId = 7,
                       ExerciseName = "Reverse Fly"

                   },
                   new Exercises
                   {
                       ExerciseId = 27,
                       CategoryId = 7,
                       ExerciseName = "Cable Lateral Raises"

                   },
                   new Exercises
                   {
                       ExerciseId = 28,
                       CategoryId = 7,
                       ExerciseName = "Dumbbell Lateral Raises"

                   },
                   new Exercises
                   {
                       ExerciseId = 29,
                       CategoryId = 8,
                       ExerciseName = "Dips"

                   },
                   new Exercises
                   {
                       ExerciseId = 30,
                       CategoryId = 8,
                       ExerciseName = "Pushdowns"

                   },
                   new Exercises
                   {
                       ExerciseId = 31,
                       CategoryId = 8,
                       ExerciseName = "Tricep Extensions"

                   }
                );
        }
    }
}
