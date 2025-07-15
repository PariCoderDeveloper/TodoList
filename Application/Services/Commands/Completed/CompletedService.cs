using Domain.Interfaces;

namespace Application.Services.Commands.Completed
{
    public class CompeletedService : ICompletedService
    {
        private readonly ITodoListRepository _repo;
        public CompeletedService(ITodoListRepository repo) => _repo = repo;
        public async Task<bool> ExecuteAsync(long id)
        {
            var res = await _repo.CompletedAsync(id);
            if (res == 0) return false;
            return true;
        }
    }
}
