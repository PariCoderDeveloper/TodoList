using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options):base(options) {   }
        public DbSet<Todo> Todo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            seedData(modelBuilder);
        }
        private void seedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo {ID = 1, Title = "خواندن کتاب Clean Architecture", IsCompleted = false, date = new DateOnly(2025, 7, 11) });
            modelBuilder.Entity<Todo>().HasData(new Todo { ID = 2, Title = "انجام تمرینات پروژه ASP.NET", IsCompleted = false, date = new DateOnly(2025, 7, 10) });
            modelBuilder.Entity<Todo>().HasData(new Todo { ID = 3, Title = "خرید کتاب جدید", IsCompleted = false, date = new DateOnly(2025, 7, 10) });
            modelBuilder.Entity<Todo>().HasData(new Todo { ID = 4, Title = "نوشتن مقاله درباره‌ی Repository Pattern", IsCompleted = true, date = new DateOnly(2025, 7, 10) });
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
