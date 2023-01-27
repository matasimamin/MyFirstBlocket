using Blocket.DataContracts;

namespace Blocket.Business.Services;

public interface IItemService
{
    IEnumerable<Item> GetItems();
    Item GetItemByID(Guid id);
    //Guid GetItemId();
    IEnumerable<Item> GetItemByName(string name);
    Item CreateItem(CreateItem createItem);

    Boolean UpdateItem(UpdateItem updateItem, Guid id);

    void DeleteItem(Guid id);
}