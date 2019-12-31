using Cross.Dtos;
using Cross.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public class ItemRepository : RepositoryBase, IItemRepository
    {
        public ItemRepository(DBContext dbContext) : base(dbContext)
        {
        }

        public ItemDto Get(string name)
        {
            return _dbContext.Item.FirstOrDefault(p => p.Name == name);
        }

        public ItemDto Get(int id)
        {
            return _dbContext.Item.FirstOrDefault(p => p.ID == id);
        }

        //public ItemDto Get(IEnumerable<TagDto> tags)
        //{
        //    return _dbContext.Item.Where(p=>tags.Contains(p.))
        //}
    }
}
