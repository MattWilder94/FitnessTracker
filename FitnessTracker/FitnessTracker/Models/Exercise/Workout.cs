using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models.Exercise
{
    public enum WorkoutType
    {
        Strength,
        Cardio,
        Mixed
    }

    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter the workout name")]
        public string WorkoutName {  get; set; } = string.Empty;

        [Required(ErrorMessage ="Please enter a workout type")]
        public WorkoutType Type {  get; set; }

        public DateTime WorkoutDate { get; set; }

        public string Notes { get; set; } = string.Empty;

    }
}
