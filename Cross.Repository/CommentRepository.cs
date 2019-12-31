using Cross.Dtos;
using Cross.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public class CommentRepository : RepositoryBase, ICommentRepository
    {
        public CommentRepository(DBContext dbContext) : base(dbContext)
        {
        }

        public int Delete(CommentDto comment)
        {
            _dbContext.Comment.Remove(comment);
            return _dbContext.SaveChanges();
        }

        public int Insert(CommentDto comment)
        {
            _dbContext.Comment.Add(comment);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<CommentDto> Query(int itemID)
        {
            return _dbContext.Comment.Where(p => p.ItemID == itemID);
        }

        public int Update(CommentDto comment)
        {
            _dbContext.Update(comment);
            return _dbContext.SaveChanges();
        }
    }
}
