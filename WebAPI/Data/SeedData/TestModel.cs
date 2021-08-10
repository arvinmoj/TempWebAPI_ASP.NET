using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SeedData
{
    public class TestModel : IEntityTypeConfiguration<Models.TestModel>
    {
        public void Configure(EntityTypeBuilder<Models.TestModel> builder)
        {
            // ***** TestModels *****
            #region TestModels

            // ***** 
            builder.HasData(new Models.TestModel
            {
                Id = Guid.Parse("16bcbb89-9dcf-4742-82eb-474013215322"),
                FullName = "Arvinmoj",
                Age = 20 ,
                PhoneNumber = "09120000000"
            });
            // ***** 

            // ***** TestModels ***** \\
            #endregion
        }
    }
}