using System.Collections.Generic;
using WebStore.Domain.Entities.Base;

namespace WebStore.Infrastructure.Interfaces
{
    public interface IProductService
    {
        public IEnumerable<Category> GetCategories();
        public IEnumerable<Brand> GetBrands();
    }
}
