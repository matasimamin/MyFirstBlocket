using Blocket.Data.Repositories.Models;
using Blocket.DataContracts;

namespace Blocket.Business.Mappers;

public interface IItemMapper
{
    Item FromDao(ItemDao dao);
    ItemDao ToDao(CreateItem dao);
}