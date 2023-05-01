namespace demo.Data.Models
{
    public class AppartmentModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int MeterId { get; set; }
        public virtual MeterModel Meter { get; set; }
    }
}
