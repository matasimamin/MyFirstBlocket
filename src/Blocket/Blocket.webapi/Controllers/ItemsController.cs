using Microsoft.AspNetCore.Mvc;
using Blocket.Data.Repositories;
using Blocket.DataContracts;

namespace Blocket.webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {

        private readonly IInMemItemsRepository _repository;

        //Constractur to create Rrop
        public ItemsController(IInMemItemsRepository inMemItemsRepository) => _repository = inMemItemsRepository;

        public IInMemItemsRepository InMemItemsRepository { get; }

       // GET / items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {

            var items = _repository.GetItems().Select(item => item.AsDto());
     
            // return _repository.GetItems();
            return items;
        }

        //[HttpGet]
        //public string TestClass()
        //{


        //    // return _repository.GetItems();
        //    return "Test";
        //}

        [HttpGet("{id}")]
        public Item GetItem(Guid id)
        {
            return _repository.GetItem(id).AsDto();
        }

        //Get BY name
        [HttpGet("name/{Name}")]
        public ActionResult<IEnumerable<Item>> GetItemByName(String name)
        {
            return Ok(_repository.GetItemByName(name));
        }

        //CreateItem
        [HttpPost]

        public ActionResult<Item> CreateItem(CreateItem createItem)
        {
            var item = new CreateItem
            {
                Id=Guid.NewGuid(),
                Name=itemDTO.Name,
                Price=itemDTO.Price,
                Created=DateTime.Now,
            };

            return CreatedAtActionResult(nameof(CreateItem), new(id = item.Id), item);
        }

    }
}
