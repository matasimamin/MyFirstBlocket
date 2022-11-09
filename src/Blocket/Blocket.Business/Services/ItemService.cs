using Blocket.Business.Mappers;
using Blocket.Data.Repositories;
using Blocket.Data.Repository;
using Blocket.DataContracts;

namespace Blocket.Business.Services
{
    public class ItemService : IItemService
    {
        private readonly IInMemItemsRepository _inMemItemsRepository;
        private readonly IItemMapper _itemMapper;

        public ItemService(
            IInMemItemsRepository inMemItemsRepository,
            IItemMapper itemMapper
            )
        {
            _itemMapper = itemMapper;
            _inMemItemsRepository = inMemItemsRepository;
        }
        public IEnumerable<Item> GetItems()
        {
            var daos = _inMemItemsRepository.GetItems();
            var items = new List<Item>();
            foreach(var dao in daos)
            {
                items.Add(_itemMapper.FromDao(dao));
            }
            return items;
            //return daos.Select(_itemMapper.FromDao);
        }

        public Item GetItem(Guid id)
        {
            var dao = _inMemItemsRepository.GetItem(id);
            
            return _itemMapper.FromDao(dao);
        }

        public Item CreateItem (CreateItem createItem)
        {
            // 1. Omvandla till DAO > 2 . Spara i Repo genom anrop
           var id= _inMemItemsRepository.CreateItem(_itemMapper.ToDao(createItem));
            return GetItem(id);
            

        }
            }
}
