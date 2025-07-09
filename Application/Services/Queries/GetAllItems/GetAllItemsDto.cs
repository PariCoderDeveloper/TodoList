namespace Application.Services.Queries.GetAllItems
{
    public record GetAllItemsDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateOnly date { get; set; }
    }
}
