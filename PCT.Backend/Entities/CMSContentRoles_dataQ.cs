using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{

    public class CMSContentRoles_dataQ : Entity
    {
        public string? Name{ get; set; }
        public Guid? CMS_content_roles_id { get; set; }
        public bool? Status { get; set; }

    }
}
