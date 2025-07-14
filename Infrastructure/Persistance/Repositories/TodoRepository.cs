using Application.Interfaces.UnitofWork;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repositories
{
    public class TodoRepository : ITodoListRepository
    {
        private readonly DatabaseContext _context;
        public TodoRepository(DatabaseContext context) => _context = context;

        public async Task<int> AddAsync(Todo item)
        {
            await _context.Todo.AddAsync(item);
            return await _context.CommitAsync();
        }

        public async Task<int> DeleteAsync(long id)
        {
            var item = await _context.Todo.FindAsync(id);
            if (item != null) _context.Todo.Remove(item);
            return await _context.CommitAsync();
        }

        public async Task<List<Todo>> GetAllItemsAsync() => await _context.Todo.Select(item => new Todo
        {
            ID = item.ID,
            Title = item.Title,
            IsCompleted = item.IsCompleted,
            date = item.date
        }).ToListAsync();

        public async Task<Todo?> GetItemByIdAsync(long id) => await _context.Todo.Select(item => new Todo
        {
            ID = item.ID,
            Title = item.Title,
            IsCompleted = item.IsCompleted,
            date = item.date
        }).Where(item => item.ID == id).FirstOrDefaultAsync();

        public async Task<int> UpdateAsync(Todo item)
        {
            _context.Todo.Update(item);
            return await _context.CommitAsync();
        }
    }
}