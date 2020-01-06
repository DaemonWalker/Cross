using Cross.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.ILogic
{
    public interface ICommentVoteLogic
    {
        void Vote(CommentVoteModel commentVote);
        void Remove(CommentVoteModel commentVote);
    }
}
