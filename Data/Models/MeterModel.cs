namespace demo.Data.Models
{
    public class MeterModel
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public DateTime? LastVerifiedDate { get; set; }
        public DateTime? NextVerifyDate { get; set; }

        public virtual AppartmentModel Appartment { get; set; } 
    }
}
