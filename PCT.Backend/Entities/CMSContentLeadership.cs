using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("cms_content_leadership")]
    public class CMSContentLeadership : Entity
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public string? Image { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public string? Alignment { get; set; }
    }
}
