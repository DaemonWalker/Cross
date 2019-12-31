using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface ITagRepository
    {
        int Insert(TagDto tag);
    }
}
