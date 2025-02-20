using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models.Nutrition
{
    public class FoodEntry
    {
        [Key]
        public int FoodId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please enter the food name")]
        public string FoodName { get; set; } = string.Empty;

        [Required(ErrorMessage ="Please enter the calorie amount")]
        public int Calories { get; set; }

        [Required(ErrorMessage = "Please enter the protein amount")]
        public int Protein { get; set; }

        [Required(ErrorMessage = "Please enter the carbohydrate amount")]
        public int Carbs { get; set; }

        [Required(ErrorMessage = "Please enter the total fat amount")]
        public int Fats { get; set; }
    }
}
