using demo.Models.Database;

namespace demo.Models.Database
{
    public class MetersTable
    {        
        public MetersTable()
        {
            Readings = new HashSet<ReadingsTable>();
        }       

        public int Id { get; set; }
        public string? Number { get; set; }
        public DateTime? LastVerifiedDate { get; set; }
        public DateTime? NextVerifyDate { get; set; }

        public virtual AppartmentsTable Appartment { get; set; } 

        public virtual ICollection<ReadingsTable> Readings { get; set; }
    }
}
