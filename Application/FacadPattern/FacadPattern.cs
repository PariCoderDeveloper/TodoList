using Application.Interfaces.Context;
using Application.Interfaces.FacadInterface;
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
        private readonly IDatabaseContext _context;
        public FacadPattern(IDatabaseContext context)
        {
            _context = context;
        }

        private IGetAllItems _getAllItems;
        public IGetAllItems getAllItems
        {
            get
            {
                return _getAllItems = _getAllItems ?? new GetAllItems(_context);
            }
        }
    }
}
