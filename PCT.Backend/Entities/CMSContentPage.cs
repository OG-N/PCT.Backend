using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backened.Entities
{
    [Table("cms_content_page")]
    public class CMSContentPage : Entity
    {
        public string? Title { get; set; }
        public string? Banner { get; set; }
        public string? Icon { get; set; }
        public string? Color { get; set; }
        public int? Order { get; set; }
    }
}
