﻿using Blocket.Business.Services;
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

        //[HttpGet]
        //public string TestClass()
        //{


        //    // return _repository.GetItems();
        //    return "Test";
        //}

        // [HttpGet("{id}")]
        // public Item GetItem(Guid id)
        // {
        //     return _repository.GetItem(id).AsDto();
        // }
        //
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
