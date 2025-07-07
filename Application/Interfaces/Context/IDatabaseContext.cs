using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces.Context
{
    public interface IDatabaseContext
    {
        DbSet<Todo> Todo { get; set; }
        int SaveChanges();
        // Because this is just a simple project, we dont use Async 
    }
}
