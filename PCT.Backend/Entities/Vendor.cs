using PCT.Backened.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backend.Entities
{
    [Table("mst_vendor")]
    public class Vendor : Entity
    {
        public string? Name { get; set; }
        public string? Country { get; set; }
    }
}
