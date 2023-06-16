using PCT.Backened.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backend.Entities
{
    [Table("mst_location")]
    public class Location : Entity
    {
        public string? Country { get; set; }
        public string? Name { get; set; }
        public Guid Category { get; set; }
        public Guid Unit { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; }
    }
}
