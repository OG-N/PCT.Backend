﻿using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("cms_content_roles")]
    public class CMSContentRoles : Entity
    {
        public Guid? Id_roles { get; set; }
        public Guid? Id_content { get; set; }
        public int? Type { get; set; }
        public bool? Status { get; set; }
    }

}
