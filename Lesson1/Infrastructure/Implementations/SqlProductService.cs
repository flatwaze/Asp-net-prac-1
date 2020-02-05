using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Interfaces;
using WebStore.DomainNew.Entities;
using WebStore.DAL;
using WebStore.DomainNew.FIlters;

namespace WebStore.Infrastructure.Implementations
{
    public class SqlProductService : IProductService
    {
        private readonly WebStoreContext _context;
        public SqlProductService(WebStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products.AsQueryable();
            if (filter.BrandId.HasValue)
                query = query.Where(x => x.BrandId.HasValue && x.BrandId.Equals(filter.BrandId));
            if (filter.CategoryId.HasValue)
                query = query.Where(x => x.CategoryId.Equals(filter.CategoryId));
            return query.ToList();
        }
    }
}
