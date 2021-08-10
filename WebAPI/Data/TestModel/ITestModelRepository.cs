using System;
namespace Data
{
    public interface ITestModelRepository : Base.IRepository<Models.TestModel> 
    {
        bool Any(Guid id);
    }
}
