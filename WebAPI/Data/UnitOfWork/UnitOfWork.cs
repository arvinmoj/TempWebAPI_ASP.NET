namespace Data
{
    public class UnitOfWork : Base.UnitOfWork, IUnitOfWork
    {
        public UnitOfWork(Tools.Options options) : base(options)
        {
        }

        // **************************************************
        //private IXXXXXRepository _xXXXXRepository;

        //public IXXXXXRepository XXXXXRepository
        //{
        //	get
        //	{
        //		if (_xXXXXRepository == null)
        //		{
        //			_xXXXXRepository =
        //				new XXXXXRepository(DatabaseContext);
        //		}

        //		return _xXXXXRepository;
        //	}
        //}
        // **************************************************

        // *****
        private ITestModelRepository _testModelRepository;

        public ITestModelRepository TestModelRepository
        {
            get
            {
                if (_testModelRepository == null)
                {
                    _testModelRepository =
                       new TestModelRepository(DatabaseContext);
                }
                return _testModelRepository;
            }
        }
        // *****
    }
}