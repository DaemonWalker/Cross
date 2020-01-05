using Cross.DBContexts;
using Cross.Dtos;
using Cross.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public class ItemRepository : BaseRepository<ItemDto>, IItemRepository
    {
        public ItemRepository(BaseDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<ItemDto> GetByName(string name)
        {
            return Query(dbSet => dbSet.Where(p => p.Name.Contains(name)));
        }

        public IEnumerable<ItemDto> GetByTag(string tag)
        {
            return _dbContext.Tag.Where(p => p.Name == tag)
                  .Join(_dbContext.ItemTag, tag => tag.ID, it => it.TagID, (tag, it) => it)
                  .Join(_dbContext.Item, it => it.ItemID, item => item.ID, (it, item) => item);
        }

        public IEnumerable<ItemDto> GetByTags(IEnumerable<string> tags)
        {
            return _dbContext.Tag.Where(p => tags.Contains(p.Name))
                   .Join(_dbContext.ItemTag, tag => tag.ID, it => it.TagID, (tag, it) => it)
                   .Join(_dbContext.Item, it => it.ItemID, item => item.ID, (it, item) => item);
        }

        public ItemDto GetItem(int id)
        {
            return Query(dbSet => dbSet.Where(p => p.ID == id)).First();
        }

        public IEnumerable<ItemDto> RandomGet()
        {
            var random = new Random();
            var idList = Query(dbSet => dbSet.Where(p => p.IsDelete == 0)).Select(p => p.ID).OrderBy(p => random.NextDouble()).Take(20);
            return Query(dbSet => dbSet.Where(p => idList.Contains(p.ID)));
        }
    }
}
