using PCT.Backend.Entities;
using PCT.Backend;
using PCT.Backend.Repository;

namespace PCT.Backend.Repository
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
