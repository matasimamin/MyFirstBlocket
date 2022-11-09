using Blocket.Data.Repositories.Models;
using Blocket.DataContracts;

namespace Blocket.Business.Mappers;

public class ItemMapper : IItemMapper
{
    public Item FromDao(ItemDao dao) =>
        new()
        {
            Created = dao.Created,
            Id = dao.Id,
            Name = dao.Name,
            Price = dao.Price
        };

    public ItemDao ToDao(CreateItem dao)
    {
        return new()
        {   Id= Guid.NewGuid(),
            Name = dao.Name,
            Price = dao.Price,
            Created=DateTime.UtcNow
        };
       
    }
}
