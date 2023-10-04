namespace Domain.Models
{
    public class Resume
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public byte[]? File { get; set; }
    }
}
