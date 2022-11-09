using Blocket.Data.Repositories.Models;

namespace Blocket.Data.Repository
{
    public interface IInMemItemsRepository
    {
        IEnumerable<ItemDao> GetItems();
        ItemDao GetItem(Guid id);

        IEnumerable<ItemDao> GetItemByName (string name);
    }
}
