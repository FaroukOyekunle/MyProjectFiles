using System.Collections.Generic;
using MyReceiptDemo.Dtos;

namespace MyReceiptDemo.Interfaces.Services
{
    public interface IItemService
    {
         bool AddItem(CreateItemRequestModel model);
        bool UpdateItem(int id, UpdateItemRequestModel model);
        ItemDto GetItem(int id);
        IList<ItemDto> GetItems();
        void DeleteItem(int id);
    }
}