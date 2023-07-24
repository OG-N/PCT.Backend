using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("icl_users")]
    public class User : Entity
    {
        public string? Email { get; set; }
        public string? FullName { get; set; }

    }
}
