using PCT.Backend.Entities;

namespace PCT.Backend.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
