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
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
