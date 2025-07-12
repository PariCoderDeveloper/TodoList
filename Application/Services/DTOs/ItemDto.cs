namespace Application.Services.DTOs
{
    public record ItemDto
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateOnly date { get; set; }
    }
}
