using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.UnitofWork
{
    public interface IUnitofWork
    {
        ITodoListRepository Todorepo { get; }
        Task<int> CommitAsync();
    }
}
