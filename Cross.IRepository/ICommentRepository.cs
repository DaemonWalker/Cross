using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface ICommentRepository : IBaseRepository<CommentDto>
    {
        IEnumerable<CommentDto> GetByItemID(int itemID);
    }
}
