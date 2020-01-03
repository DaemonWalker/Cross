using Autofac.Extras.DynamicProxy;
using Cross.Models;
using Cross.Share;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IService
{
    public interface ICommentService : IBaseService
    {
        CommentModel Add(CommentModel comment);
        bool Delete(CommentModel comment);
        CommentModel Modify(CommentModel comment);
        IEnumerable<CommentModel> Get(int itemID);

    }
}
