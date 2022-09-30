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
            return _repository.GetItems();
        }
        [HttpGet("{id}")]
        public Item GetItem (Guid id)
        {
            return _repository.GetItem(id);
        }
    }
}
