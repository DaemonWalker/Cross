using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface ICommentVoteRepository : IBaseRepository<CommentVoteDto>
    {
        CommentVoteDto GetByCommentIDAndUserID(int commentID, int userID);
        bool ExistByCommentIDAndUserID(int commentID, int userID);
    }
}
