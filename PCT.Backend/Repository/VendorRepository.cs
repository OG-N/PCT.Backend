using PCT.Backend.Entities;
using PCT.Backened;
using PCT.Backened.Repository;

namespace PCT.Backend.Repository
{
    public class VendorRepository : Repository<Vendor>
    {
        public VendorRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
