using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITodoListRepository
    {
        // C R U D
        Task<List<Todo>> GetAllItemsAsync();
        Task<Todo?> GetItemByIdAsync(long id);
        Task<int> AddAsync(Todo item);
        Task<int> UpdateAsync(Todo item);
        Task<int> DeleteAsync(long id);
    }
}
