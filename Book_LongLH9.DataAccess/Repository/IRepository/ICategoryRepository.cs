using Book_LongLH9.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book_LongLH9.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
