using Application.Services.Queries.GetAllItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.FacadInterface
{
    public interface IFacadPattern
    {
        // Commands 

        // Queries
        IGetAllItems getAllItems { get; }
    }
}
