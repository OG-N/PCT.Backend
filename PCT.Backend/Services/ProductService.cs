using PCT.Backend.Entities;
using PCT.Backend.Repository;
using PCT.Backend.Utils;

namespace PCT.Backend.Services
{
    public class ProductService
    {
        private readonly ProductRepository _repository;
        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public Product GetProductByUuid(Guid Id)
        {
            return _repository.GetById(Id);
        }

        public IEnumerable<Product> GetProductByCategoryId(Guid categoryId)
        {
            return _repository.GetAll().Where(x => x.Category == categoryId);
        }

        public IEnumerable<Product> SaveProducts(IEnumerable<Product> products)
        {
            List<Product> savedproducts = new List<Product>();
            try
            {
                foreach (var product in products)
                {
                    savedproducts.Add(_repository.Create(product));
                }

                return savedproducts;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Product SaveProduct(Product product)
        {
            try
            {
                return _repository.Create(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Product UpdateProduct(Product product)
        {
            try
            {
               return _repository.Update(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _repository.GetAll().Where(x => x.IsDeleted == false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Delete(Guid ProductId)
        {
            try
            {
                Product product = _repository.GetById(ProductId);
                product.IsDeleted = true;
                _repository.Update(product);
                return "Product deleted successfully";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Product GetById(Guid id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double GetAllCount()
        {
            try
            {
                return _repository.GetAll().Count();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double GetPendingCount()
        {
            try
            {
                return _repository.GetAll().Where(x => x.Status == Status.Pending).Count();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double GetApprovedCount()
        {
            try
            {
                return _repository.GetAll().Where(x => x.Status == Status.Approved).Count();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public double GetRjectedCount()
        {
            try
            {
                return _repository.GetAll().Where(x => x.Status == Status.Rejected).Count();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
