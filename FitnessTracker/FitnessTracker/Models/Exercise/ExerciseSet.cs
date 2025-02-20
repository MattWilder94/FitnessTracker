using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models.Exercise
{
    public class ExerciseSet
    {
        [Key]
        public int SetId { get; set; }

        [ForeignKey("Exercise")]
        public int ExerciseId { get; set; }

        public int SetNumber { get; set; }

        public int WeightAmount { get; set; }

        public int Reps { get; set; }
    }
}
