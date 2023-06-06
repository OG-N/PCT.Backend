using PCT.Backened.Entities;

namespace PCT.Backened.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
