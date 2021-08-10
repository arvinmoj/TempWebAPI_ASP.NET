using System;
using System.Linq;

namespace Data
{    public class TestModelRepository : Base.Repository<Models.TestModel>, ITestModelRepository
    {
        internal TestModelRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public bool Any(Guid id)
        {
            var result =
                DbSet.Any(e => e.Id == id);

            return result;
        }
    }
}

