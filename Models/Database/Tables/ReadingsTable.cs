namespace demo.Models.Database
{
    public class ReadingsTable
    {
        public int Id { get; set; }

        public int MeterId { get; set; }

        public string? Value { get; set; }

        public DateTime? Date { get; set; }

        public virtual MetersTable Meter { get; set; }
    }
}