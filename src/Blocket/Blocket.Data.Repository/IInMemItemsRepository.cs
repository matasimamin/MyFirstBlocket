using Blocket.webapi.Entities;
using Blocket.Data.Repositories.Models;
namespace Blocket.Data.Repositories
{
    public interface IInMemItemsRepository
    {
        IEnumerable<ItemDao> GetItems();
        ItemDao GetItem(Guid id);

        IEnumerable<ItemDao> GetItemByName (string name);
    }
}
