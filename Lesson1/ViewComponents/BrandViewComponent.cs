using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.ViewComponents
{
    [ViewComponent(Name = "Brands")]
    public class BrandViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        public BrandViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var brands = GetBrands();
            return View(brands);
        }

        private List<BrandViewModel> GetBrands()
        {
            var brands = _productService.GetBrands();
            return brands.Select(x => new BrandViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Order = x.Order,
                ProductsCount = 0
            }).OrderBy(x => x.Order).ToList();
        }
    }
}
