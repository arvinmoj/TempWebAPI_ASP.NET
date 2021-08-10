using Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        // public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        // {
        //     Database.EnsureCreated();
        // }

        /// <summary>
        /// Using Migrations!
        /// </summary>
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        
        public DbSet<TestModel> TestModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region  Configuration
            // ***** 
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentTestModelConfig());
            // *****
            #endregion

            #region Seed Data
            // *****
            modelBuilder.ApplyConfiguration(new SeedData.TestModel());
            // *****
            #endregion

        }
    }
}