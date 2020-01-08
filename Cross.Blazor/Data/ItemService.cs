using Cross.ILogic;
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
        public readonly IItemLogic _itemLogic;
        public ItemApi(IItemLogic itemLogic)
        {
            this._itemLogic = itemLogic;
        }
        public ItemOverviewModel GetOverview(int id)
        {
            return new ItemOverviewModel();
        }
    }
}
