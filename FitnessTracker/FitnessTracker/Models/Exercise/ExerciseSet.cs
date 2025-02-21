using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models.Exercise
{
    // this model tracks sets inside workout.cs
    public class ExerciseSet
    {
        [Key]
        public int SetId { get; set; }

        [ForeignKey("Exercise")]
        public int ExerciseId { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }

        public int SetNumber { get; set; }

        public int WeightAmount { get; set; }

        public int Reps { get; set; }

        public int RPE { get; set; }
    }
}
