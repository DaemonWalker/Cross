using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface IItemRepository
    {
        ItemDto Get(string name);
        ItemDto Get(int id);
        //ItemDto Get(IEnumerable<TagDto> tags);
    }
}
