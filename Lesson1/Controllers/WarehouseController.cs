using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.Infrastructure.Implementations;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseService _warehouseService;
        public WarehouseController(IWarehouseService warehousesService)
        {
            _warehouseService = warehousesService;
        }

        [Route("warehouses")]
        public IActionResult Index()
        {
            return View(_warehouseService.GetAll());
        }

        [Route("warehouses/{id}")]
        public IActionResult WarehouseDetails(int id)
        {
            var warehouse = _warehouseService.GetById(id);
            if (warehouse != null)
                return View(warehouse);
            return NotFound();
        }

        [HttpGet]
        [Route("warehouses/edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new WarehouseView());
            var warehouse = _warehouseService.GetById(id.Value);
            if (warehouse != null)
                return View(warehouse);
            return NotFound();
        }

        [HttpPost]
        [Route("warehouses/edit/{id?}")]
        public IActionResult Edit(WarehouseView model)
        {
            return View();
        }

        [Route("warehouses/delete/{id}")]
        public IActionResult Delete(int id)
        {
            _warehouseService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}