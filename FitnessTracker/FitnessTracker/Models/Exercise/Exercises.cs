using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FitnessTracker.Models.Exercise
{
    public class Exercises
    {
        [Key]
        public int ExerciseId { get; set; }

        [ForeignKey("ExerciseCategory")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Please enter an exercise name")]
        public string ExerciseName { get; set; } = string.Empty;
    }
}
