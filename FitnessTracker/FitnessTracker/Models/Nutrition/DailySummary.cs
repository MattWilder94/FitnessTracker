using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Models.Nutrition
{
    public class DailySummary
    {
        [Key]
        public int SummaryId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public DateTime Date { get; set; }

        public int TotalCalories { get; set; }

        public int TotalProtein { get; set; }

        public int TotalCarbs { get; set; }

        public int TotalFats { get; set; }

        public bool CalGoalMet {  get; set; }
    }
}
