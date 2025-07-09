using Application.Interfaces.Context;

namespace Application.Services.Queries.GetAllItems
{
    public class GetAllItems : IGetAllItems
    {
        private readonly IDatabaseContext _context;
        public GetAllItems(IDatabaseContext context) { _context = context; }
        public List<GetAllItemsDto> GetAllItemService(int? idItems = 0)
        {
            return _context.Todo.Where(item => idItems == 0 || item.ID == idItems)
            .Select(item => new GetAllItemsDto
            {
                ID = item.ID,
                Title = item.Title,
                IsCompleted = item.IsCompleted,
                date = item.date,
            }).ToList();
        }
    }
}
