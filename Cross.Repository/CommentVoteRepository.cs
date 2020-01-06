using Cross.DBContexts;
using Cross.Dtos;
using Cross.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public class CommentVoteRepository : BaseRepository<CommentVoteDto>, ICommentVoteRepository
    {
        public CommentVoteRepository(BaseDbContext dbContext) : base(dbContext)
        {
        }

        public bool ExistByCommentIDAndUserID(int commentID, int userID)
        {
            return Query(dbSet => dbSet.Where(p => p.Account.ID == userID && p.Comment.ID == commentID)).Count() > 0;
        }

        public CommentVoteDto GetByCommentIDAndUserID(int commentID, int userID)
        {
            return Query(dbSet => dbSet.Where(p => p.Account.ID == userID && p.Comment.ID == commentID)).FirstOrDefault();
        }
    }
}
