using Microsoft.AspNetCore.Mvc;
using MyReceiptDemo.Interfaces.Services;

namespace MyReceiptDemo.Controllers
{
    public class ItemController: Controller
    {
         private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        
    }
}