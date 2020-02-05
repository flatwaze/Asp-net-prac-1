using System.Collections.Generic;
using WebStore.DomainNew.Entities;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductService
    {
        public IEnumerable<Category> GetCategories();
        public IEnumerable<Brand> GetBrands();
    }
}
