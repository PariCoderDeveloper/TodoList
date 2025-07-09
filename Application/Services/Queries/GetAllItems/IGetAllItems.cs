using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Queries.GetAllItems
{
    public interface IGetAllItems
    {
       public List<GetAllItemsDto> GetAllItemService(int? idItems);
    }
}
