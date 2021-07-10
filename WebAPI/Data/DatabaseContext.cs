using Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DatabaseContext : DbContext
    {
  
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Using Migrations!
        /// </summary>
        //public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        //{
        //}l
        
        public DbSet<TestModel> TestModels { get; set; }
    }
}