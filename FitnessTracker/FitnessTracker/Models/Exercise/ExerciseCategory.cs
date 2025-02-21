using System.ComponentModel.DataAnnotations;

public enum CategoryName
{
    Abs,
    Back,
    Biceps,
    Cardio,
    Chest,
    Legs,
    Shoulders,
    Triceps
}

namespace FitnessTracker.Models.Exercise

{
    public class ExerciseCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public CategoryName CategoryName { get; set; }
    }
}
