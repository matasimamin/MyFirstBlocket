using Blocket.Data.Repositories.Models;

namespace Blocket.Data.Repository
{
    public class InMemItemsRepository : IInMemItemsRepository
    {
        private readonly List<ItemDao> items = new()
        {
            new ItemDao {Id = Guid.NewGuid(), Name="Pistol" , Price = 20 , Created= DateTime.UtcNow},
            new ItemDao {Id = Guid.NewGuid(), Name="Pistol" , Price = 40 , Created= DateTime.UtcNow},
            new ItemDao {Id = Guid.NewGuid(), Name="Sword" , Price = 9 , Created= DateTime.UtcNow},
            new ItemDao {Id = Guid.NewGuid(), Name="Shield" , Price = 18 , Created= DateTime.UtcNow},
        };

        public IEnumerable<ItemDao> GetItems() => items;

        public ItemDao GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public IEnumerable<ItemDao> GetItemByName(string name)
        {
            return items.Where(item => item.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
        }
    }
}
