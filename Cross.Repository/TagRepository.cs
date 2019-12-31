using Cross.Dtos;
using Cross.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Repository
{
    public class TagRepository : RepositoryBase, ITagRepository
    {
        public TagRepository(DBContext dbContext) : base(dbContext)
        {
        }

        public int Insert(TagDto tag)
        {
            _dbContext.Tag.Add(tag);
            return _dbContext.SaveChanges();
        }
    }
}
