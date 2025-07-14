namespace Application.Services.Commands.EidtItem
{
    public record EditItemDto
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateOnly date { get; set; }
    }
}
