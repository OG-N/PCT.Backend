using PCT.Backend.Entities;
using PCT.Backened;
using PCT.Backened.Repository;

namespace PCT.Backend.Repository
{
    public class ProductUnitRepository : Repository<ProductUnit>
    {
        public ProductUnitRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
