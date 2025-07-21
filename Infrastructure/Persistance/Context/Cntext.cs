using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.UnitofWork;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Context
{
    public class DatabaseContext : DbContext, IUnitofWork
    {
        public ITodoListRepository Todorepo { get; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) => Todorepo = new TodoRepository(this);

        public DbSet<Todo> Todo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            seedData(modelBuilder);
            queryFilter(modelBuilder);
        }

        private void queryFilter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasQueryFilter(item => !item.isRemoved);
        }
        private void seedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo { ID = 1, Title = "Read the book Clean Architecture", IsCompleted = false, date = new DateOnly(2025, 7, 11) });
            modelBuilder.Entity<Todo>().HasData(new Todo { ID = 2, Title = "Do ASP.NET project exercises", IsCompleted = false, date = new DateOnly(2025, 7, 10) });
            modelBuilder.Entity<Todo>().HasData(new Todo { ID = 3, Title = "Buy a new book", IsCompleted = false, date = new DateOnly(2025, 7, 10) });
            modelBuilder.Entity<Todo>().HasData(new Todo { ID = 4, Title = "Write an article about the Repository Pattern", IsCompleted = true, date = new DateOnly(2025, 7, 10) });

        }
        public async Task<int> CommitAsync() => await SaveChangesAsync();
    }
}
