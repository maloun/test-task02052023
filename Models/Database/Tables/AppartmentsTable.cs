namespace demo.Models.Database
{
    public class AppartmentsTable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int MeterId { get; set; }

        public virtual MetersTable Meter { get; set; }
    }
}
