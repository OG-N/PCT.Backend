using PCT.Backend.Entities;
using PCT.Backened;
using PCT.Backened.Repository;

namespace PCT.Backend.Repository
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
