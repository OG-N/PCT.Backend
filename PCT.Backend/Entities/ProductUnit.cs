using PCT.Backened.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backend.Entities
{
    [Table("mst_product_unit")]
    public class ProductUnit : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
