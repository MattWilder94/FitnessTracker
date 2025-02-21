using Microsoft.EntityFrameworkCore;
using FitnessTracker.Models.Exercise;

namespace FitnessTracker.Models.SeedData.Exercise
{
    public static class SetSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciseSet>().HasData(
                new ExerciseSet
                {
                    SetId = 1,
                    ExerciseId = 1,
                    WorkoutId = 1,
                    SetNumber = 1,
                    WeightAmount = 75,
                    Reps = 10,
                    RPE = 8
                },
                new ExerciseSet
                {
                    SetId = 2,
                    ExerciseId = 1,
                    WorkoutId = 1,
                    SetNumber = 2,
                    WeightAmount = 75,
                    Reps = 9,
                    RPE = 10
                },
               new ExerciseSet
               {
                   SetId = 3,
                   ExerciseId = 1,
                   WorkoutId = 1,
                   SetNumber = 3,
                   WeightAmount = 75,
                   Reps = 8,
                   RPE = 10
               },
              new ExerciseSet
              {
                  SetId = 4,
                  ExerciseId = 2,
                  WorkoutId = 1,
                  SetNumber = 1,
                  WeightAmount = 70,
                  Reps = 10,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 5,
                  ExerciseId = 2,
                  WorkoutId = 1,
                  SetNumber = 2,
                  WeightAmount = 70,
                  Reps = 8,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 6,
                  ExerciseId = 2,
                  WorkoutId = 1,
                  SetNumber = 3,
                  WeightAmount = 70,
                  Reps = 8,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 7,
                  ExerciseId = 22,
                  WorkoutId = 1,
                  SetNumber = 1,
                  WeightAmount = 100,
                  Reps = 6,
                  RPE = 10
              },
              new ExerciseSet
              {
                  SetId = 8,
                  ExerciseId = 22,
                  WorkoutId = 1,
                  SetNumber = 2,
                  WeightAmount = 90,
                  Reps = 10,
                  RPE = 10
              },
              new ExerciseSet
              {
                  SetId = 9,
                  ExerciseId = 22,
                  WorkoutId = 1,
                  SetNumber = 3,
                  WeightAmount = 90,
                  Reps = 7,
                  RPE = 10
              },
              new ExerciseSet
              {
                  SetId = 10,
                  ExerciseId = 27,
                  WorkoutId = 1,
                  SetNumber = 1,
                  WeightAmount = 30,
                  Reps = 8,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 11,
                  ExerciseId = 27,
                  WorkoutId = 1,
                  SetNumber = 2,
                  WeightAmount = 30,
                  Reps = 9,
                  RPE = 8
              },
             new ExerciseSet
             {
                 SetId = 12,
                 ExerciseId = 27,
                 WorkoutId = 1,
                 SetNumber = 3,
                 WeightAmount = 30,
                 Reps = 10,
                 RPE = 9
             },
              new ExerciseSet
              {
                  SetId = 13,
                  ExerciseId = 30,
                  WorkoutId = 1,
                  SetNumber = 1,
                  WeightAmount = 130,
                  Reps = 10,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 14,
                  ExerciseId = 30,
                  WorkoutId = 1,
                  SetNumber = 2,
                  WeightAmount = 130,
                  Reps = 10,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 15,
                  ExerciseId = 30,
                  WorkoutId = 1,
                  SetNumber = 3,
                  WeightAmount = 130,
                  Reps = 10,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 16,
                  ExerciseId = 10,
                  WorkoutId = 2,
                  SetNumber = 1,
                  WeightAmount = 175,
                  Reps = 10,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 17,
                  ExerciseId = 10,
                  WorkoutId = 2,
                  SetNumber = 2,
                  WeightAmount = 175,
                  Reps = 10,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 18,
                  ExerciseId = 10,
                  WorkoutId = 2,
                  SetNumber = 3,
                  WeightAmount = 175,
                  Reps = 10,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 19,
                  ExerciseId = 9,
                  WorkoutId = 2,
                  SetNumber = 1,
                  WeightAmount = 110,
                  Reps = 12,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 20,
                  ExerciseId = 9,
                  WorkoutId = 2,
                  SetNumber = 2,
                  WeightAmount = 110,
                  Reps = 12,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 21,
                  ExerciseId = 9,
                  WorkoutId = 2,
                  SetNumber = 3,
                  WeightAmount = 110,
                  Reps = 12,
                  RPE = 10
              },
              new ExerciseSet
              {
                  SetId = 22,
                  ExerciseId = 7,
                  WorkoutId = 2,
                  SetNumber = 1,
                  WeightAmount = 130,
                  Reps = 12,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 23,
                  ExerciseId = 7,
                  WorkoutId = 2,
                  SetNumber = 2,
                  WeightAmount = 130,
                  Reps = 12,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 24,
                  ExerciseId = 7,
                  WorkoutId = 2,
                  SetNumber = 3,
                  WeightAmount = 145,
                  Reps = 8,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 25,
                  ExerciseId = 12,
                  WorkoutId = 2,
                  SetNumber = 1,
                  WeightAmount = 40,
                  Reps = 8,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 26,
                  ExerciseId = 12,
                  WorkoutId = 2,
                  SetNumber = 2,
                  WeightAmount = 40,
                  Reps = 8,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 27,
                  ExerciseId = 12,
                  WorkoutId = 2,
                  SetNumber = 3,
                  WeightAmount = 40,
                  Reps = 8,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 28,
                  ExerciseId = 13,
                  WorkoutId = 2,
                  SetNumber = 1,
                  WeightAmount = 30,
                  Reps = 10,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 29,
                  ExerciseId = 13,
                  WorkoutId = 2,
                  SetNumber = 2,
                  WeightAmount = 30,
                  Reps = 10,
                  RPE = 9
              },
              new ExerciseSet
              {
                  SetId = 30,
                  ExerciseId = 13,
                  WorkoutId = 2,
                  SetNumber = 3,
                  WeightAmount = 30,
                  Reps = 10,
                  RPE = 8
              },
              new ExerciseSet
              {
                  SetId = 31,
                  ExerciseId = 20,
                  WorkoutId = 3,
                  SetNumber = 1,
                  WeightAmount = 140,
                  Reps = 12,
                  RPE = 6
              },
               new ExerciseSet
               {
                   SetId = 32,
                   ExerciseId = 20,
                   WorkoutId = 3,
                   SetNumber = 2,
                   WeightAmount = 160,
                   Reps = 12,
                   RPE = 8
               },
                new ExerciseSet
                {
                    SetId = 33,
                    ExerciseId = 20,
                    WorkoutId = 3,
                    SetNumber = 3,
                    WeightAmount = 180,
                    Reps = 8,
                    RPE = 9
                },
                 new ExerciseSet
                 {
                     SetId = 34,
                     ExerciseId = 18,
                     WorkoutId = 3,
                     SetNumber = 1,
                     WeightAmount = 110,
                     Reps = 10,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 35,
                     ExerciseId = 18,
                     WorkoutId = 3,
                     SetNumber = 2,
                     WeightAmount = 110,
                     Reps = 8,
                     RPE = 9
                 },
                 new ExerciseSet
                 {
                     SetId = 36,
                     ExerciseId = 18,
                     WorkoutId = 3,
                     SetNumber = 3,
                     WeightAmount = 110,
                     Reps = 10,
                     RPE = 9
                 },
                 new ExerciseSet
                 {
                     SetId = 37,
                     ExerciseId = 21,
                     WorkoutId = 3,
                     SetNumber = 1,
                     WeightAmount = 320,
                     Reps = 15,
                     RPE = 7
                 },
                 new ExerciseSet
                 {
                     SetId = 38,
                     ExerciseId = 21,
                     WorkoutId = 3,
                     SetNumber = 2,
                     WeightAmount = 330,
                     Reps = 15,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 39,
                     ExerciseId = 21,
                     WorkoutId = 3,
                     SetNumber = 3,
                     WeightAmount = 330,
                     Reps = 15,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 40,
                     ExerciseId = 5,
                     WorkoutId = 4,
                     SetNumber = 1,
                     WeightAmount = 65,
                     Reps = 10,
                     RPE = 9
                 },
                 new ExerciseSet
                 {
                     SetId = 41,
                     ExerciseId = 5,
                     WorkoutId = 4,
                     SetNumber = 2,
                     WeightAmount = 65,
                     Reps = 8,
                     RPE = 9
                 },
                 new ExerciseSet
                 {
                     SetId = 42,
                     ExerciseId = 5,
                     WorkoutId = 4,
                     SetNumber = 3,
                     WeightAmount = 65,
                     Reps = 5,
                     RPE = 10
                 },
                 new ExerciseSet
                 {
                     SetId = 43,
                     ExerciseId = 2,
                     WorkoutId = 4,
                     SetNumber = 1,
                     WeightAmount = 75,
                     Reps = 10,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 44,
                     ExerciseId = 2,
                     WorkoutId = 4,
                     SetNumber = 2,
                     WeightAmount = 75,
                     Reps = 10,
                     RPE = 9
                 },
                 new ExerciseSet
                 {
                     SetId = 45,
                     ExerciseId = 2,
                     WorkoutId = 4,
                     SetNumber = 3,
                     WeightAmount = 75,
                     Reps = 7,
                     RPE = 10
                 },
                 new ExerciseSet
                 {
                     SetId = 46,
                     ExerciseId = 22,
                     WorkoutId = 4,
                     SetNumber = 1,
                     WeightAmount = 80,
                     Reps = 8,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 47,
                     ExerciseId = 22,
                     WorkoutId = 4,
                     SetNumber = 2,
                     WeightAmount = 80,
                     Reps = 10,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 48,
                     ExerciseId = 22,
                     WorkoutId = 4,
                     SetNumber = 3,
                     WeightAmount = 80,
                     Reps = 10,
                     RPE = 10
                 },
                 new ExerciseSet
                 {
                     SetId = 49,
                     ExerciseId = 27,
                     WorkoutId = 4,
                     SetNumber = 1,
                     WeightAmount = 30,
                     Reps = 12,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 50,
                     ExerciseId = 27,
                     WorkoutId = 4,
                     SetNumber = 2,
                     WeightAmount = 30,
                     Reps = 12,
                     RPE = 9
                 },
                 new ExerciseSet
                 {
                     SetId = 51,
                     ExerciseId = 27,
                     WorkoutId = 4,
                     SetNumber = 3,
                     WeightAmount = 30,
                     Reps = 12,
                     RPE = 9
                 },
                 new ExerciseSet
                 {
                     SetId = 52,
                     ExerciseId = 30,
                     WorkoutId = 4,
                     SetNumber = 1,
                     WeightAmount = 120,
                     Reps = 12,
                     RPE = 7
                 },
                 new ExerciseSet
                 {
                     SetId = 53,
                     ExerciseId = 30,
                     WorkoutId = 4,
                     SetNumber = 2,
                     WeightAmount = 120,
                     Reps = 12,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 54,
                     ExerciseId = 30,
                     WorkoutId = 4,
                     SetNumber = 3,
                     WeightAmount = 120,
                     Reps = 12,
                     RPE = 8
                 },
                 new ExerciseSet
                 {
                     SetId = 55,
                     ExerciseId = 31,
                     WorkoutId = 4,
                     SetNumber = 1,
                     WeightAmount = 80,
                     Reps = 9,
                     RPE = 9
                 },
                 new ExerciseSet
                 {
                     SetId = 56,
                     ExerciseId = 31,
                     WorkoutId = 4,
                     SetNumber = 2,
                     WeightAmount = 80,
                     Reps = 10,
                     RPE = 10
                 },
                 new ExerciseSet
                 {
                     SetId = 57,
                     ExerciseId = 31,
                     WorkoutId = 4,
                     SetNumber = 3,
                     WeightAmount = 80,
                     Reps = 8,
                     RPE = 10
                 },
                 new ExerciseSet
                 {
                     SetId = 58,
                     ExerciseId = 10,
                     WorkoutId = 5,
                     SetNumber = 1,
                     WeightAmount = 130,
                     Reps = 12,
                     RPE = 8
                 },
                  new ExerciseSet
                  {
                      SetId = 59,
                      ExerciseId = 10,
                      WorkoutId = 5,
                      SetNumber = 2,
                      WeightAmount = 145,
                      Reps = 10,
                      RPE = 8
                  },
                  new ExerciseSet
                  {
                      SetId = 60,
                      ExerciseId = 10,
                      WorkoutId = 5,
                      SetNumber = 3,
                      WeightAmount = 145,
                      Reps = 12,
                      RPE = 8
                  },
                  new ExerciseSet
                  {
                      SetId = 61,
                      ExerciseId = 9,
                      WorkoutId = 5,
                      SetNumber = 1,
                      WeightAmount = 125,
                      Reps = 10,
                      RPE = 9
                  },
                  new ExerciseSet
                  {
                      SetId = 62,
                      ExerciseId = 9,
                      WorkoutId = 5,
                      SetNumber = 2,
                      WeightAmount = 125,
                      Reps = 10,
                      RPE = 9
                  },
                  new ExerciseSet
                  {
                      SetId = 63,
                      ExerciseId = 9,
                      WorkoutId = 5,
                      SetNumber = 3,
                      WeightAmount = 125,
                      Reps = 10,
                      RPE = 9
                  },
                  new ExerciseSet
                  {
                      SetId = 64,
                      ExerciseId = 7,
                      WorkoutId = 5,
                      SetNumber = 1,
                      WeightAmount = 150,
                      Reps = 12,
                      RPE = 8
                  },
                  new ExerciseSet
                  {
                      SetId = 65,
                      ExerciseId = 7,
                      WorkoutId = 5,
                      SetNumber = 2,
                      WeightAmount = 150,
                      Reps = 8,
                      RPE = 8
                  },
                  new ExerciseSet
                  {
                      SetId = 66,
                      ExerciseId = 7,
                      WorkoutId = 5,
                      SetNumber = 3,
                      WeightAmount = 150,
                      Reps = 9,
                      RPE = 8
                  },
                  new ExerciseSet
                  {
                      SetId = 67,
                      ExerciseId = 14,
                      WorkoutId = 5,
                      SetNumber = 1,
                      WeightAmount = 50,
                      Reps = 12,
                      RPE = 6
                  },
                  new ExerciseSet
                  {
                      SetId = 68,
                      ExerciseId = 14,
                      WorkoutId = 5,
                      SetNumber = 2,
                      WeightAmount = 60,
                      Reps = 8,
                      RPE = 8
                  },
                  new ExerciseSet
                  {
                      SetId = 69,
                      ExerciseId = 14,
                      WorkoutId = 5,
                      SetNumber = 3,
                      WeightAmount = 60,
                      Reps = 10,
                      RPE = 9
                  },
                  new ExerciseSet
                  {
                      SetId = 70,
                      ExerciseId = 13,
                      WorkoutId = 5,
                      SetNumber = 1,
                      WeightAmount = 30,
                      Reps = 12,
                      RPE = 9
                  },
                  new ExerciseSet
                  {
                      SetId = 71,
                      ExerciseId = 13,
                      WorkoutId = 5,
                      SetNumber = 2,
                      WeightAmount = 30,
                      Reps = 12,
                      RPE = 9
                  },
                  new ExerciseSet
                  {
                      SetId = 72,
                      ExerciseId = 13,
                      WorkoutId = 5,
                      SetNumber = 3,
                      WeightAmount = 30,
                      Reps = 12,
                      RPE = 10
                  }
                );
        }
    }
}
