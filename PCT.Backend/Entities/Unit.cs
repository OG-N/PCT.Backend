using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backend.Entities
{
    [Table("mst_unit")]
    public class Unit : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
