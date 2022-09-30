using Blocket.webapi.Entities;

namespace Blocket.webapi.Repositories
{
    public class InMemItemsRepository : IInMemItemsRepository
    {
        private readonly List<Item> items = new List<Item>()
        {


            new Item {Id = Guid.NewGuid(), Name="Pistol" , Price = 20 , Created= DateTimeOffset.UtcNow},
            new Item {Id = Guid.NewGuid(), Name="Sword" , Price = 9 , Created= DateTimeOffset.UtcNow},
            new Item {Id = Guid.NewGuid(), Name="Shield" , Price = 18 , Created= DateTimeOffset.UtcNow},
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
    }
}
