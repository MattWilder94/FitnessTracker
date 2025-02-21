using System.ComponentModel.DataAnnotations;

public enum FitnessGoal
{
    Weightloss,
    Weightgain,
    MaintainWeight
}

public enum ActivityLevel
{
    Sedentary,
    Light,
    Moderate,
    Heavy
}

namespace FitnessTracker.Models.Users
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required")]
        public int UserAge { get; set; }

        [Required(ErrorMessage = "Height is required")]
        public int UserHeight { get; set; }

        [Required(ErrorMessage = "Weight is required")]
        public int UserWeight { get; set; }

        [Required(ErrorMessage = "Fitness goal is required")]
        public FitnessGoal FitnessGoal { get; set; }

        [Required(ErrorMessage = "Please select an activity level")]
        public ActivityLevel ActivityLevel { get; set; }

        [Required(ErrorMessage = "Please input a caloric target")]
        public int CaloricTarget { get; set; }
    }
}
