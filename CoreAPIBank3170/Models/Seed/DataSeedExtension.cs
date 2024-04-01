using CoreAPIBank3170.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIBank3170.Models.Seed
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            UserCardInfo ucInfo = new()
            {
                ID = 1,
                Balance = 100000,
                CardLimit = 100000,
                CardNumber = "1111 1111 1111 1111",
                CardUserName = "Test verisidir",
                CCV = "222",
                ExpiryMonth = 12,
                ExpiryYear = 2024

            };

            modelBuilder.Entity<UserCardInfo>().HasData(ucInfo);
        }
    }
}
