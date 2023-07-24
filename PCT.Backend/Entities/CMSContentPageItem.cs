using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("cms_content_page_item")]
    public class CMSContentPageItem : Entity
    {
        public Guid? Id_section { get; set; }
        public string? Text { get; set; }
        public string? Link { get; set; }
        public int? Type { get; set; }
        public int? Order { get; set; }
    }
}
