using PCT.Backened.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backend.Entities
{
    [Table("mst_product_category")]
    public class ProductCategory : Entity
    {
        public string? Name { get; set; }
    }
}
