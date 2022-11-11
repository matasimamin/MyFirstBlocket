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
        public IEnumerable<Item> GetItemByName (string name)
        {
            return _itemService.GetItemByName(name);
            
        }
       

        
        // //Get BY name
        // [HttpGet("name/{Name}")]
        // public ActionResult<IEnumerable<Item>> GetItemByName(String name)
        // {
        //     return Ok(_repository.GetItemByName(name));
        // }
        //
        // //CreateItem
        // [HttpPost]
        //
        // public ActionResult<Item> CreateItem(CreateItem createItem)
        // {
        //     var item = new CreateItem
        //     {
        //         Id=Guid.NewGuid(),
        //         Name=itemDTO.Name,
        //         Price=itemDTO.Price,
        //         Created=DateTime.Now,
        //     };
        //
        //     return CreatedAtActionResult(nameof(CreateItem), new(id = item.Id), item);
        // }


        [HttpPost]
        public ActionResult<Item> CreateItem (CreateItem item)
        {
            var newItem= _itemService.CreateItem(item);
            return CreatedAtAction(nameof(CreateItem), newItem);

        }
    }
}
