using Cross.DBContexts;
using Cross.Dtos;
using Cross.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public class CommentRepository : BaseRepository<CommentDto>, ICommentRepository
    {
        public CommentRepository(BaseDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<CommentDto> GetByItemID(int itemID)
        {
            return Query(dbSet => dbSet.Where(p => p.ItemID == itemID));
        }

    }
}
