namespace Peresentation.Models
{
    public record EditItemModel
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime date { get; set; }
    }

}
