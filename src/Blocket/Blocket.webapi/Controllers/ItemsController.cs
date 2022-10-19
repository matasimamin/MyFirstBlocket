using Microsoft.AspNetCore.Mvc;
using Blocket.webapi.Repositories;
using Blocket.webapi.Entities;


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

        //GET / items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {

            var items = _repository.GetItems().Select(item => new ItemDTO
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                Created = item.Created
            });
            return _repository.GetItems();
        }
        [HttpGet("{id}")]
        public Item GetItem(Guid id)
        {
            return _repository.GetItem(id);
        }
        
        //Get BY name
        [HttpGet("name/{Name}")]
        public ActionResult<IEnumerable<Item>> GetItemByName(String name)
        {
            return Ok(_repository.GetItemByName(name));
        }
        
    }
}
