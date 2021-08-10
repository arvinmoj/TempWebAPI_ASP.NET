using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentTestModelConfig : IEntityTypeConfiguration<TestModel>
    {
        public void Configure(EntityTypeBuilder<TestModel> builder)
        {
            // ***** 
            builder
           .Property(s => s.FullName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // ***** 
            builder
           .Property(s => s.PhoneNumber)
           .IsRequired()
           .HasMaxLength(12);
            // *****

            // ***** 
            builder
           .Property(s => s.Age)
           .IsRequired()
           .HasColumnType("number");
            // *****
        }
    }
}