using Application.Services.DTOs;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Commands.addItem
{
    public class AddItemService : IAddItemService
    {
        private readonly ITodoListRepository _todorep;
        public AddItemService(ITodoListRepository todorep)
        {
            _todorep = todorep;
        }
        public async Task<bool> Execute(ItemDto item)
        {
           var result = await _todorep.AddAsync(new Todo
           {
               ID = item.ID,
               Title = item.Title,
               IsCompleted = false,
               date = item.date
           });
           if ( result == 0 ) return false;
           else return true;
        }
    }
}
