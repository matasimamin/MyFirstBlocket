using Blocket.webapi.Entities;

namespace Blocket.webapi.Repositories
{
    public interface IInMemItemsRepository
    {
        IEnumerable<Item> GetItems();
        Item GetItem(Guid id);

        IEnumerable<Item> GetItemByName (string name);
    }
}
