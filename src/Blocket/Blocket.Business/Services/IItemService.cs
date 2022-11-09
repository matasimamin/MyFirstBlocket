using Blocket.DataContracts;

namespace Blocket.Business.Services;

public interface IItemService
{
    IEnumerable<Item> GetItems();
}