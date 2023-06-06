using System.ComponentModel.DataAnnotations;

namespace PCT.Backened.Entities
{
    public class Entity
    {
        [Key]
        public virtual Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean IsDeleted { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
