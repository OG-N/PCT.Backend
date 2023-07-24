using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("icl_options_routes")]
    public class OptionRoute : Entity
    {
        public string? Category { get; set; }
        public string? Name { get; set; }
        public string? Route { get; set; }
    }
}
