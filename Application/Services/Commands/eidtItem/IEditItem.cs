using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Commands.EidtItem
{
    public interface IEditItem
    {
        Task<bool> ExecuteAsync(EditItemDto item);
    }
}
