using Blocket.webapi.Entities;
using System.Linq;

namespace Blocket.webapi.Repositories
{
    public class InMemItemsRepository : IInMemItemsRepository
    {
        private readonly List<Item> items = new List<Item>()
        {


            new Item {Id = Guid.NewGuid(), Name="Pistol" , Price = 20 , Created= DateTime.UtcNow},
            new Item {Id = Guid.NewGuid(), Name="Pistol" , Price = 40 , Created= DateTime.UtcNow},
            new Item {Id = Guid.NewGuid(), Name="Sword" , Price = 9 , Created= DateTime.UtcNow},
            new Item {Id = Guid.NewGuid(), Name="Shield" , Price = 18 , Created= DateTime.UtcNow},
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public IEnumerable<Item> GetItemByName(string name)
        {

            return items.Where(item => item.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
            
        }
    }
}
