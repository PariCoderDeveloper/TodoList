using Application.Interfaces.FacadInterface;
using Application.Interfaces.UnitofWork;
using Application.Services.Commands.addItem;
using Application.Services.Queries.GetAllItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FacadPattern
{
    public class FacadPattern : IFacadPattern
    {
        private readonly IUnitofWork _unitofWork;
        public FacadPattern(IUnitofWork unitofWork) => _unitofWork = unitofWork;
        private IGetAllItems _getAllItems;
        public IGetAllItems getAllItems
        {
            get
            {
                return _getAllItems = _getAllItems ?? new GetAllItems(_unitofWork.Todorepo);
            }
        }
        private AddItemService _addItemService;
        public AddItemService addItemService
        {
            get
            {
                return _addItemService = _addItemService ?? new AddItemService(_unitofWork.Todorepo);
            }
        }
    }
}
