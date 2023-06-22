using PCT.Backend.Entities;
using PCT.Backend;
using PCT.Backend.Repository;

namespace PCT.Backend.Repository
{
    public class VendorRepository : Repository<Vendor>
    {
        public VendorRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
