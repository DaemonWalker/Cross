using Cross.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IRepository
{
    public interface IItemRepository
    {
        IEnumerable<ItemDto> RandomGet();
        ItemDto GetItem(int id);
        IEnumerable<ItemDto> GetByTag(string tag);
        IEnumerable<ItemDto> GetByTags(IEnumerable<string> tags);
        IEnumerable<ItemDto> GetByName(string name);
    }
}
