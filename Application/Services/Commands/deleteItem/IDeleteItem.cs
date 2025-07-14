using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Commands.deleteItem
{
    public interface IDeleteItem
    {
        Task<bool> ExecuteAsync(long id);
    }
    public class DeleteItemService : IDeleteItem
    {
        private readonly ITodoListRepository _repo;
        public DeleteItemService(ITodoListRepository repo)
        {
            _repo = repo;
        }
        public async Task<bool> ExecuteAsync(long id)
        {
            var res = await _repo.DeleteAsync(id);
            if(res == 0) return false;
            else return true;
        }
    }
}
