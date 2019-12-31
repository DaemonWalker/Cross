using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Repository
{
    public class RepositoryBase
    {
        protected readonly DBContext _dbContext;
        public RepositoryBase(DBContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
