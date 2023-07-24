using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("icl_roles")]
    public class Role: Entity
    {
        public string? Name { get; set; }
        public string? Category { get; set; }
    }
}