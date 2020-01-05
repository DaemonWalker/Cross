using Cross.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.IService
{
    public interface IItemService
    {
        List<ItemOverviewModel> RandomGet();
        ItemViewModel GetItem(int id);
        List<ItemOverviewModel> GetByTag(string tag);
        List<ItemOverviewModel> GetByTags(IEnumerable<string> tags);
        List<ItemOverviewModel> GetByName(string name);
    }
}
