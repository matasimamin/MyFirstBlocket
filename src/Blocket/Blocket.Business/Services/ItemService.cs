using Blocket.Business.Mappers;
using Blocket.Data.Repositories;
using Blocket.Data.Repository;
using Blocket.DataContracts;

namespace Blocket.Business.Services
{
    public class ItemService : IItemService
    {
        private readonly IInMemItemsRepository _inMemItemsRepository;
        private readonly IItemMapper _mapper;

        public ItemService(
            IInMemItemsRepository inMemItemsRepository,
            IItemMapper itemMapper
            )
        {
            _mapper = itemMapper;
            _inMemItemsRepository = inMemItemsRepository;
        }
        public IEnumerable<Item> GetItems()
        {
            var daos = _inMemItemsRepository.GetItems();
            return daos.Select(_mapper.FromDao);
        }
    }
}
