using Application.Services.DTOs;
using Domain.Interfaces;

namespace Application.Services.Queries.GetAllItems
{
    public class GetAllItems : IGetAllItems
    {
        private readonly ITodoListRepository _todorep;
        public GetAllItems(ITodoListRepository todorep) => _todorep = todorep;
        public async Task<IEnumerable<ItemDto>> ExecuteAsync()
        {
            var result = await _todorep.GetAllItemsAsync();
            return  result.Select(t => new ItemDto
            {
                ID = t.ID,
                Title = t.Title,
                IsCompleted = t.IsCompleted,
                date = t.date
            }).ToList();
        }
    }
}
