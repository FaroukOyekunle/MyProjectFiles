using System.Collections.Generic;

namespace MyReceiptDemo.Interfaces.Repositories
{
    public interface IItemRepository
    {
          Item CreateItem(Item item);
        Item UpdateItem(Item item);
        Item GetItemById(int id);
        List<Item> GetAllItems();
        void DeleteItem(Item item);
        Item ItemExistsByName(Item item);
    }
}