using Blocket.webapi.Repositories;
using Blocket.webapi.Entities;
namespace Blocket.webapi
{
    public static class Extensions 

    {

        public static ItemDTO AsDto (this Item item)
        {
            return new ItemDTO
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                Created = item.Created
            };
        }
        
    }
}
