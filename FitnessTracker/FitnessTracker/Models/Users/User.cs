using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models.Users
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required")]
        public int UserAge { get; set; }

        [Required(ErrorMessage = "Height is required")]
        public string UserHeight { get; set; } = string.Empty;

        [Required(ErrorMessage = "Weight is required")]
        public int UserWeight { get; set; }

        [Required(ErrorMessage = "Fitness goal is required")]
        public string FitnessGoal { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select an activity level")]
        public string ActivityLevel { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please input a caloric target")]
        public int CaloricTarget { get; set; }
    }
}
