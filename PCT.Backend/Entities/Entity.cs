using System.ComponentModel.DataAnnotations;

namespace PCT.Backened.Entities
{
    public class Entity
    {
        [Key]
        public virtual Guid Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
            if(IsDeleted == null)
                IsDeleted = false;
            if(CreateDate == null)
                CreateDate = DateTime.Now;
        }
    }
}
