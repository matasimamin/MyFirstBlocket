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

        public Item GetItemByID(Guid id)
        {
            var dao = _inMemItemsRepository.GetItem(id);
            if (dao is null)
            {
                return null;
            }
            return _itemMapper.FromDao(dao);
        }

        public IEnumerable<Item> GetItemByName (string name)
        {
          var item= _inMemItemsRepository.GetItemByName(name);
            var items = new List<Item>();
            foreach (var dao in item)
            {
                var _itemfromdao=_itemMapper.FromDao(dao);
                items.Add(_itemfromdao);

            }
            return items;
            
        }

        public Item CreateItem (CreateItem createItem)
        {
            // 1. Omvandla till DAO > 2 . Spara i Repo genom anrop
           var id= _inMemItemsRepository.CreateItem(_itemMapper.ToDao(createItem));
            return GetItemByID(id);
            

        }

        public Boolean UpdateItem (UpdateItem updateItem , Guid id )
        {
            
            var item = GetItemByID(id);
            if (item is null)
                return false;
            item.Name = updateItem.Name;
            item.Price = updateItem.Price;
            _inMemItemsRepository.UpdateItem(_itemMapper.ToDao(item));
            return true;
        }

        public void DeleteItem(Guid id)
        {
            _inMemItemsRepository.DeleteItem(id);
        }

     
    }
}
