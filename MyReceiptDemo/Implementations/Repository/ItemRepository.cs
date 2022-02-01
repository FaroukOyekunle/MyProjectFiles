using System.Collections.Generic;
using System.Linq;
using MyReceiptDemo.Interfaces.Repositories;

namespace MyReceiptDemo.Implementations.Repository
{
    public class ItemRepository: IItemRepository
    {
         private readonly MyReceiptDemoContext _context;
        public ItemRepository(MyReceiptDemoContext context)
        {
            _context = context;
        }
         public Item CreateItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public void DeleteItem(Item item)
        {
            _context.Items.Remove(item);
            _context.SaveChanges();
        }

        public List<Item> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public Item GetItemById(int id)
        {
            return _context.Items.Find(id);
        }

        public Item ItemExistsByName(Item item)
        {
            throw new System.NotImplementedException();
        }

        public Item UpdateItem(Item item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
            return item;
        }
    }
}