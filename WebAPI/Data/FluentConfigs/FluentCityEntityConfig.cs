using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentCityEntityConfig : IEntityTypeConfiguration<TestModel>
    {
        public void Configure(EntityTypeBuilder<TestModel> builder)
        {
            // ***** City *****
            #region City
            
            // *****
            // builder
            //   .HasOne<Models.TestModel>(s => s.)
            //   .WithMany(g => g.Cities);
            // ***** 

            // ***** City ***** \\
            #endregion
        }
    }
}