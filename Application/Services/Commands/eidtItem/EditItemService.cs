using Domain.Interfaces;
using Domain.Models;

namespace Application.Services.Commands.EidtItem
{
    public class EditItemService : IEditItem
    {
        private readonly ITodoListRepository _repo;
        public EditItemService(ITodoListRepository repo) => _repo = repo;
        public async Task<bool> ExecuteAsync(EditItemDto item)
        {
            var result = await _repo.UpdateAsync(new Todo
            {
                ID = item.ID,
                Title = item.Title,
                IsCompleted = item.IsCompleted,
                date = item.date
            });
            if (result == 0) return false;
            else return true;
        }
    }
}
