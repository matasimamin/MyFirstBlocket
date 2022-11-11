using Blocket.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Blocket.Data.Repositories;
using Blocket.DataContracts;

namespace Blocket.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        //Constractur to create Rrop
        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET / items
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems() =>
            Ok(_itemService.GetItems());


        //GetBYID
        [HttpGet("{id}")]
        public Item GetItemByID(Guid id)
        {
            return _itemService.GetItemByID(id);

        }
        [HttpGet("name/{Name}")]
        public IEnumerable<Item> GetItemByName (string name) // no content in response body only when request by URL
        {
            return _itemService.GetItemByName(name);
            
        }
       

        [HttpPost]
        public ActionResult<Item> CreateItem (CreateItem item)
        {
            var newItem= _itemService.CreateItem(item);
            return CreatedAtAction(nameof(CreateItem), newItem);

        }

        [HttpPut ("{id}")]
        public ActionResult UpdateItem (UpdateItem updateItem , Guid id)
        {
           
                _itemService.UpdateItem(updateItem, id);
            return NoContent();
        }
           


    }
}
