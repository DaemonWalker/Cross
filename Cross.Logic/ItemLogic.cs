using AutoMapper;
using Cross.ILogic;
using Cross.IRepository;
using Cross.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Logic
{
    public class ItemLogic : IItemLogic
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;
        public ItemLogic(IItemRepository itemRepository, IMapper mapper)
        {
            this._itemRepository = itemRepository;
            this._mapper = mapper;
        }
        public List<ItemOverviewModel> GetByName(string name)
        {
            return _mapper.Map<List<ItemOverviewModel>>(_itemRepository.GetByName(name));
        }

        public List<ItemOverviewModel> GetByTag(string tag)
        {
            return _mapper.Map<List<ItemOverviewModel>>(_itemRepository.GetByTag(tag));
        }

        public List<ItemOverviewModel> GetByTags(IEnumerable<string> tags)
        {
            return _mapper.Map<List<ItemOverviewModel>>(_itemRepository.GetByTags(tags));
        }

        public ItemViewModel GetItem(int id)
        {
            return _mapper.Map<ItemViewModel>(_itemRepository.GetItem(id));
        }

        public List<ItemOverviewModel> RandomGet()
        {
            return _mapper.Map<List<ItemOverviewModel>>(_itemRepository.RandomGet());
        }
    }
}
