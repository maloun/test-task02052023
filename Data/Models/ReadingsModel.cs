namespace demo.Data.Models
{
    public class ReadingsModel
    {
        public int Id { get; set; }
        public int MeterId { get; set; }
        public string? Value { get; set; }
        public DateTime? Date { get; set; }
    }
}
