using Cross.IService;
using Cross.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Blazor.Data
{
    public class ItemApi
    {
        public readonly IItemService _itemService;
        public ItemApi(IItemService itemService)
        {
            this._itemService = itemService;
        }
        public ItemOverviewModel GetOverview(int id)
        {
            return new ItemOverviewModel();
        }
    }
}
