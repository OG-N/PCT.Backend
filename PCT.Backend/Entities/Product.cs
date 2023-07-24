using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backend.Entities
{
    [Table("mst_product")]
    public class Product : Entity
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public Guid Category { get; set; }
        public Guid Unit { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Pending,
        Approved,
        Rejected
    }
}
