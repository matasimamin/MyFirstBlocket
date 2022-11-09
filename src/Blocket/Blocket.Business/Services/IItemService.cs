using Blocket.DataContracts;

namespace Blocket.Business.Services;

public interface IItemService
{
    IEnumerable<Item> GetItems();
    Item GetItem(Guid id);
    Item CreateItem(CreateItem createItem);
}