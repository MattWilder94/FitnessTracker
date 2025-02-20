using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public enum MuscleGroup
{
    Chest,
    Back,
    Legs,
    Arms,
    Shoudlers,
    Core
}

namespace FitnessTracker.Models.Exercise
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutID { get; set; }

        [Required(ErrorMessage ="Please enter an exercise name")]
        public string ExerciseName { get; set; } = string.Empty;

        [Required(ErrorMessage ="Please select a muscle group")]
        public MuscleGroup TargetMuscle { get; set; }
    }
}
