using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backend.Entities
{
    [Table("mst_category")]
    public class Category : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Group Group { get; set; }
    }

    public enum Group
    {
        Product,
        Carrier,
        Location,
        Vendor
    }
}
