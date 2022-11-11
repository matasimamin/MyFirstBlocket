using Blocket.DataContracts;

namespace Blocket.Business.Services;

public interface IItemService
{
    IEnumerable<Item> GetItems();
    Item GetItemByID(Guid id);
    IEnumerable<Item> GetItemByName(string name);
    Item CreateItem(CreateItem createItem);
}