using Microsoft.EntityFrameworkCore;
using FitnessTracker.Models.Users;

namespace FitnessTracker.Models.SeedData.User
{
    public static class UserSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().HasData(
                new UserInfo
                {
                    UserId = 1,
                    UserName = "MbWilder",
                    UserAge = 30,
                    UserWeight = 206,
                    UserHeight = 69,
                    FitnessGoal = FitnessGoal.Weightloss,
                    ActivityLevel = ActivityLevel.Moderate,
                    CaloricTarget = 2300 // This will hopefully be calculated in future
                }
                );
        }
    }
}
