using System;
using System.Collections.Generic;
using System.Text;

namespace Book_LongLH9.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
