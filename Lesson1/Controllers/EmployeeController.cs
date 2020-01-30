using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeesService;

        public EmployeeController(IEmployeeService employeesService)
        {
            _employeesService = employeesService;
        }

        [Route("employees")]
        public IActionResult Index()
        {
            return View(_employeesService.GetAll());
        }

        [Route("employees/{id}")]
        public IActionResult EmployeeDetails(int id)
        {
            var employee = _employeesService.GetById(id);
            if (employee != null)
                return View(employee);
            return NotFound();
        }

        [HttpGet]
        [Route("employees/edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new EmployeeView());

            var model = _employeesService.GetById(id.Value);
            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        [Route("employees/edit/{id?}")]

        public IActionResult Edit(EmployeeView model)
        {
            if (model.Id > 0)
            {
                var dbItem = _employeesService.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound();

                dbItem.Name = model.Name;
                dbItem.Surname = model.Surname;
                dbItem.Age = model.Age;
            }
            else
            {
                _employeesService.Add(model);
            }
            _employeesService.Commit(); 

            return RedirectToAction(nameof(Index));
        }

        [Route("employees/delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeesService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }   
}