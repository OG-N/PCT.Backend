using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("cms_content_page_section")]
    public class CMSContentPageSection : Entity
    {
        public Guid? Id_page { get; set; }
        public string? Text { get; set; }
        public int? Order { get; set; }
    }
}
