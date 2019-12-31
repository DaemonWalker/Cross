using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface ICommentRepository
    {
        int Insert(CommentDto comment);
        IEnumerable<CommentDto> Query(int itemID);
        int Update(CommentDto comment);
        int Delete(CommentDto comment);
    }
}
