using Application.Services.Commands.addItem;
using Application.Services.Commands.Completed;
using Application.Services.Commands.deleteItem;
using Application.Services.Commands.EidtItem;
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
        EditItemService editItemService { get; }
        DeleteItemService deleteItemService { get; }
        CompeletedService CompeletedService { get; }
        // Queries
        IGetAllItems getAllItems { get; }
    }
}
