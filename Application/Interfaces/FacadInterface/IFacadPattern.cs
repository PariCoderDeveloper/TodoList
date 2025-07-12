using Application.Services.Commands.addItem;
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
        AddItemService addItemService { get; }
        // Queries
        IGetAllItems getAllItems { get; }
    }
}
