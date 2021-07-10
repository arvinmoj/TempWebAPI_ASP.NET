using Data;
namespace Infrastructure
{
    public class BaseControllerWithDatabase : BaseController
    {
        private readonly DatabaseContext _databaseContext;

        public BaseControllerWithDatabase(DatabaseContext DatabaseContext)
        {
            _databaseContext = DatabaseContext;
        }
    }
}