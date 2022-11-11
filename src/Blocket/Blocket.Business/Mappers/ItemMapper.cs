using Blocket.Data.Repositories.Models;
using Blocket.DataContracts;

namespace Blocket.Business.Mappers;

public class ItemMapper : IItemMapper
{
    public Item FromDao(ItemDao dao) =>
        new() // why do we have new here if we return an exieste obj?
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

    public ItemDao ToDao(Item dao)
    {
        return new()
        {
            Id= dao.Id,
            Name = dao.Name,
            Price = dao.Price,
            Created= dao.Created,
        };

    }
}
 