using Cross.ILogic;
using Cross.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Blazor.Data
{
    public class CommentService
    {
        private readonly ICommentLogic _commentLogic;
        public CommentService(ICommentLogic commentLogic)
        {
            this._commentLogic = commentLogic;
        }
        public CommentViewModel Add(CommentModel commentModel)
        {
            return _commentLogic.Add(commentModel);
        }
        public void Delete(int commentID)
        {
            _commentLogic.Delete(commentID);
        }
        public CommentViewModel Modify(CommentModel commentModel)
        {
            return _commentLogic.Modify(commentModel);
        }
        public List<CommentViewModel> GetByItemID(int itemID)
        {
            return _commentLogic.GetCommentsByItemID(itemID);
        }
    }
}
