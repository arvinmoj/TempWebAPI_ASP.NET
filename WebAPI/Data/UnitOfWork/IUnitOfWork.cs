namespace Data
{
    public interface IUnitOfWork : Base.IUnitOfWork
    {
        // *****
        ITestModelRepository TestModelRepository { get; }
        // *****
        
    }
}