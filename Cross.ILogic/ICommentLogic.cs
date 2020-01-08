using Cross.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.ILogic
{
    public interface ICommentLogic
    {
        List<CommentViewModel> GetByItemIDOrderByTime(int itemID, int skip = 0, int take = 0);
        List<CommentViewModel> GetByItemIDOrderByUp(int itemID, int skip = 0, int take = 0);
        CommentViewModel Add(CommentModel comment);
        public void Delete(int commentID);
        CommentViewModel Modify(CommentModel comment);
    }
}
