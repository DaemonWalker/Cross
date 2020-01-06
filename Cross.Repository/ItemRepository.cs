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
            return _dbContext.Item.Include(p => p.ItemTags).ThenInclude(p => p.Tag).Where(p => p.ItemTags.Any(q => q.Tag.Name == tag));
        }

        public IEnumerable<ItemDto> GetByTags(IEnumerable<string> tags)
        {
            throw new NotImplementedException();
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
