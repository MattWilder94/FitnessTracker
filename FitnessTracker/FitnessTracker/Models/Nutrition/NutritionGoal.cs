using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models.Nutrition
{
    public enum GoalType
    {
        WeightLoss,
        Maintain,
        GainWeight

    }
    public class NutritionGoal
    {
        [Key]
        public int NutritionGoalId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please select a goal")]
        public GoalType GoalType { get; set; }

        [Required(ErrorMessage ="Please enter a daily calorie target")]
        public int CalorieTarget {  get; set; }

        [Required(ErrorMessage ="Please enter a daily protein target")]
        public int ProteinTarget {  get; set; }

        [Required(ErrorMessage ="Please enter a daily carbohydrate target")]
        public int CarbTarget { get; set; }

        [Required(ErrorMessage ="Please enter a daily fat traget")]
        public int FatTarget { get; set; }
    }
}
