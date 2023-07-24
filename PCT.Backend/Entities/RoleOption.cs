using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("icl_role_options")]
    public class RoleOption : Entity
    {
        public Guid RoleId { get; set; }
        public Guid OptionId { get; set; }
        public bool ReadPermission { get; set; }
        public bool WritePermission { get; set; }
        public bool UpdatePermission { get; set; }
    }
}
