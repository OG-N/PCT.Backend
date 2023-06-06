using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("mst_product")]
    public class Product : Entity
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int? Category { get; set; }
        public int? Unit { get; set; }
        public string? Description { get; set; }
        public ProductStatus Status { get; set; }
    }

    public enum ProductStatus
    {
        Pending,
        Approved
    }
}
