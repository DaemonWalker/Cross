using Cross.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IService
{
    public interface ICommentLogic
    {
        List<CommentShowModel> GetCommentsByItemID(int itemID);
        CommentShowModel Add(CommentModel comment);
        public void Delete(int commentID);
        void Modify(CommentModel comment);
    }
}
