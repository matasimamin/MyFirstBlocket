using Blocket.DataContracts;

namespace Blocket.Business.Services;

public interface IItemService
{
    IEnumerable<Item> GetItems();
    Item GetItemByID(Guid id);
    //Guid GetItemId();
    IEnumerable<Item> GetItemByName(string name);
    Item CreateItem(CreateItem createItem);

    void UpdateItem(UpdateItem updateItem, Guid id);
}