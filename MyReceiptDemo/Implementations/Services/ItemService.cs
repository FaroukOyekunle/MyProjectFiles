using System.Collections.Generic;
using MyReceiptDemo.Dtos;
using MyReceiptDemo.Interfaces.Repositories;
using MyReceiptDemo.Interfaces.Services;

namespace MyReceiptDemo.Implementations.Services
{
    public class ItemService: IItemService
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public bool AddItem(CreateItemRequestModel model)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            throw new System.NotImplementedException();
        }

        public ItemDto GetItem(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<ItemDto> GetItems()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateItem(int id, UpdateItemRequestModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}